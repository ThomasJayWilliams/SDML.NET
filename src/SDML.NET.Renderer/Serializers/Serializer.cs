using SDML.NET.Renderer.DataStructures;
using SDML.NET.Renderer.DTOs;
using SDML.NET.Renderer.VisualComponents;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SDML.NET.Renderer
{
    public static class Serializer
    {
		// Builds and return tree of elements
        public static ElementTree SerializeData(DataElementDTO data, RenderOptions options) =>
            BuildTree(data, options);  
        
        public static async Task<ElementTree> SerializeDataAsync(DataElementDTO data, RenderOptions options) =>
            await Task.Run(() => BuildTree(data, options));

		// Returns whole document as a string
        public static string GetData(ElementTree tree)
        {
            if (tree == null || tree.Root == null)
                throw new ArgumentException("Tree cannot be null!");

            return tree.Root.Data;
        }

		// Builds tree and parses each element
        private static ElementTree BuildTree(DataElementDTO data, RenderOptions options, RenderAccumulator accumulator = null)
        {
			// Tree, that will exported to SdmlGenerator and will be containing all elements
            var tree = new ElementTree();

			// Recursion accumulator. Allows to render tabulations, based on layer count
            var acc = accumulator;

            if (accumulator == null)
                acc = new RenderAccumulator();

			// If data has value that means this element donesn't have childs
            if (!string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLTag(data);
				options.TargetType = RenderTargetTypes.Value;

                tree.Add(new ElementNode()
                {
                    Data = RenderManager.Render(tag, options, acc),
                    Element = tag,
                    Parent = new SDMLTag(data.Parent)
                });
            }

			// If data contains at least one child it has to be serialized in a different way than value element
            else if (data.Childs.Any())
            {
                var tag = new SDMLTag(data);
				options.TargetType = RenderTargetTypes.OpenTag;

                var elementNode = new ElementNode()
                {
                    Data = RenderManager.Render(tag, options, acc),
                    Element = tag,
                    Parent = new SDMLTag(data.Parent)
                };

				// Add tab to accumulator
                RenderManager.AddTab(acc);

                foreach (var item in data.Childs)
                {
                    var temp = BuildTree(item, options, acc);

                    foreach (var node in temp.Elements)
                    {
                        elementNode.Childs.Add(node);
                        elementNode.Data += node.Data;
                    }
                }

				options.TargetType = RenderTargetTypes.ClosedTag;

                elementNode.Data += RenderManager.Render(tag, options, acc);
                tree.Add(elementNode);
            }

			// If data has no value and no childs it will be rendered as bodyless tag
            else
            {
                var tag = new SDMLTag(data);
				options.TargetType = RenderTargetTypes.BodylessTag;

                tree.Add(new ElementNode()
                {
                    Data = RenderManager.Render(tag, options, acc),
                    Element = tag,
                    Parent = new SDMLTag(data.Parent)
                });
            }

			// Removes tabs from accumulator
            RenderManager.RemoveTab(acc);

            return tree;
        }
    }
}

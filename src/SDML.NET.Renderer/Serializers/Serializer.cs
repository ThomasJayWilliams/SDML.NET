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
        public static ElementTree SerializeData(DataElementDTO data, RenderOptions options) =>
            BuildTree(data, options);  
        
        public static async Task<ElementTree> SerializeDataAsync(DataElementDTO data, RenderOptions options) =>
            await Task.Run(() => BuildTree(data, options));

        public static string GetData(ElementTree tree)
        {
            if (tree == null || tree.Root == null)
                throw new ArgumentException("Tree cannot be null!");

            return tree.Root.Data;
        }

        public static ElementTree BuildTree(DataElementDTO data, RenderOptions options)
        {
            var tree = new ElementTree();

            if (!string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLBodyTag(data);
                tree.Add(new ElementNode()
                {
                    Data = $"{tag.OpenTag}{data.Value}{tag.CloseTag}",
                    Element = tag,
                    Parent = new SDMLBodyTag(data.Parent)
                });
            }

            else if (data.Childs.Any())
            {
                var tag = new SDMLBodyTag(data);
                var elementNode = new ElementNode()
                {
                    Data = tag.OpenTag,
                    Element = tag,
                    Parent = new SDMLBodyTag(data.Parent)
                };

                foreach (var item in data.Childs)
                {
                    var temp = BuildTree(item, options);

                    foreach (var node in temp.Elements)
                    {
                        elementNode.Childs.Add(node);
                        elementNode.Data += node.Data;
                    }
                }

                elementNode.Data += tag.CloseTag;
                tree.Add(elementNode);
            }

            else
            {
                var tag = new SDMLBodylessTag(data);
                tree.Add(new ElementNode()
                {
                    Data = $"{tag.Tag}",
                    Element = tag,
                    Parent = new SDMLBodyTag(data.Parent)
                });
            }

            return tree;
        }
    }

    public class RenderOptions
    {
        public RenderTypes RenderType { get; set; } = RenderTypes.Escaped;
    }
}

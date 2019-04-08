using SDML.NET.Renderer.DataStructures;
using SDML.NET.Renderer.DTOs;
using SDML.NET.Renderer.VisualComponents;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDML.NET.Renderer.Formatters
{
	public static class Serializer
    {
        private static int _tabCounter = 0;

        public static ElementTree SerializeData(DataElementDTO data) => BuildTree(data);        
        public static async Task<ElementTree> SerializeDataAsync(DataElementDTO data) => await Task.Run(() => BuildTree(data));

        public static ElementTree BuildTree(DataElementDTO data)
        {
            var tree = new ElementTree();

            if (!string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLBodyTag(data);
                tree.Elements.Add(new ElementNode()
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
                    var temp = BuildTree(item);

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
                tree.Elements.Add(new ElementNode()
                {
                    Data = $"{tag.Tag}",
                    Element = tag,
                    Parent = new SDMLBodyTag(data.Parent)
                });
            }

            return tree;
        }
    }
}

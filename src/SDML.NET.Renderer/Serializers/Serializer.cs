﻿using SDML.NET.Renderer.DataStructures;
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

        private static ElementTree BuildTree(DataElementDTO data, RenderOptions options, RenderAccumulator accumulator = null)
        {
            var tree = new ElementTree();

            var acc = accumulator;

            if (accumulator == null)
                acc = new RenderAccumulator();

            if (!string.IsNullOrEmpty(data.Value))
            {
                var tag = new SDMLTag(data);
				options.TargetType = RenderTargetTypes.Value;

                tree.Add(new ElementNode()
                {
                    Data = RendererManager.Render(tag, options, acc),
                    Element = tag,
                    Parent = new SDMLTag(data.Parent)
                });
            }

            else if (data.Childs.Any())
            {
                var tag = new SDMLTag(data);
				options.TargetType = RenderTargetTypes.OpenTag;

                var elementNode = new ElementNode()
                {
                    Data = RendererManager.Render(tag, options, acc),
                    Element = tag,
                    Parent = new SDMLTag(data.Parent)
                };

                RendererManager.AddTab(acc);

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

                elementNode.Data += RendererManager.Render(tag, options, acc);
                tree.Add(elementNode);
            }

            else
            {
                var tag = new SDMLTag(data);
				options.TargetType = RenderTargetTypes.BodylessTag;

                tree.Add(new ElementNode()
                {
                    Data = RendererManager.Render(tag, options, acc),
                    Element = tag,
                    Parent = new SDMLTag(data.Parent)
                });
            }

            RendererManager.RemoveTab(acc);

            return tree;
        }
    }
}

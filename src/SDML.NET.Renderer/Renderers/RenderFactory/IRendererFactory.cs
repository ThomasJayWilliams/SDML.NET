namespace SDML.NET.Renderer.Factory
{
    internal interface IRendererFactory
    {
        IRenderer CreateOpenRenderer();
        IRenderer CreateClosedRenderer();
        IRenderer CreateValueRenderer();
        IRenderer CreateBodylessRenderer();
    }
}

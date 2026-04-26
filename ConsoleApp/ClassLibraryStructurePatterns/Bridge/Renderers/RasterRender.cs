namespace ClassLibraryStructurePatterns.Bridge.Renderers
{
    public class RasterRender : IRenderer
    {
        public void RenderShape(string shapeName) => Console.WriteLine($"Drawing {shapeName} as pixels");
    }
}

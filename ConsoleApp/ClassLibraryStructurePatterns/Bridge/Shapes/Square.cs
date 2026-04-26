using ClassLibraryStructurePatterns.Bridge.Renderers;

namespace ClassLibraryStructurePatterns.Bridge.Shapes
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw() => _renderer.RenderShape("Square");
    }
}

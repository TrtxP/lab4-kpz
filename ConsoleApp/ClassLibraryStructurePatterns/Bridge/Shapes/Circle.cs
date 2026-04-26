using ClassLibraryStructurePatterns.Bridge.Renderers;

namespace ClassLibraryStructurePatterns.Bridge.Shapes
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw() => _renderer.RenderShape("Circle");
    }
}

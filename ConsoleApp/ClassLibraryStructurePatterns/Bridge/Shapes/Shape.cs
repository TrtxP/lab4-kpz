using ClassLibraryStructurePatterns.Bridge.Renderers;

namespace ClassLibraryStructurePatterns.Bridge.Shapes
{
    public abstract class Shape
    {
        protected IRenderer _renderer;

        public Shape (IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}

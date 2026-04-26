using ClassLibraryStructurePatterns.Composite.Enums;

namespace ClassLibraryStructurePatterns.Flyweight
{
    public class LightElementFactory
    {
        private readonly Dictionary<(string, DisplayType, ClosingType), LightElementInfo> _flyweights = new();

        public LightElementInfo GetElementInfo(string tagName, DisplayType display, ClosingType closing)
        {
            var key = (tagName, display, closing);

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new LightElementInfo(tagName, display, closing);
            }

            return _flyweights[key];
        }
    }
}

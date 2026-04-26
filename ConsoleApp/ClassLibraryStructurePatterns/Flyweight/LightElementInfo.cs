using ClassLibraryStructurePatterns.Composite.Classes;
using ClassLibraryStructurePatterns.Composite.Enums;

namespace ClassLibraryStructurePatterns.Flyweight
{
    public class LightElementInfo
    {
        public string _tagName { get; }
        public DisplayType _dispay { get; }
        public ClosingType _closing { get; }

        public LightElementInfo(string tagName, DisplayType dispay, ClosingType closing)
        {
            _tagName = tagName;
            _dispay = dispay;
            _closing = closing;
        }
    }
}

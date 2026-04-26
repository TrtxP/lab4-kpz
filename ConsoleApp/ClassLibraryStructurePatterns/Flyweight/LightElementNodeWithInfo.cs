using ClassLibraryStructurePatterns.Composite.Classes;
using ClassLibraryStructurePatterns.Composite.Enums;
using System.Text;

namespace ClassLibraryStructurePatterns.Flyweight
{
    public class LightElementNodeWithInfo : LightNode
    {
        private readonly LightElementInfo _info;
        private List<string> _cssClasses = new();
        private List<LightNode> _children = new();

        public LightElementNodeWithInfo(LightElementInfo info)
        {
            _info = info;
        }

        public override string InnerHTML()
        {
            StringBuilder htmlBuilder = new StringBuilder();

            foreach (var htmlElementChild in _children)
            {
                htmlBuilder.Append(htmlElementChild.OuterHTML());
            }

            return htmlBuilder.ToString();
        }

        public override string OuterHTML()
        {
            StringBuilder result = new StringBuilder();

            if (_info._dispay == DisplayType.Block)
            {
                result.Append(Environment.NewLine);
            }

            result.Append($"<{_info._tagName}");

            if (_cssClasses.Any())
            {
                result.Append($" class=\"{string.Join(" ", _cssClasses)}\"");
            }

            result.Append(">");

            if (_info._closing == ClosingType.Normal)
            {
                result.Append(InnerHTML());
                result.Append($"</{_info._tagName}>");
            }

            return result.ToString();
        }

        public void TextContent(LightTextNode textNode)
        {
            _children.Add(textNode);
        }

        public void AppendChild(LightElementNodeWithInfo elementNode)
        {
            _children.Add(elementNode);
        }
    }
}

using ClassLibraryStructurePatterns.Composite.Enums;
using System.Text;

namespace ClassLibraryStructurePatterns.Composite.Classes
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private DisplayType _displayType;
        private ClosingType _closingType;
        private List<string> _cssClasses = new List<string>();
        private List<LightNode> _children = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
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

            if (_displayType == DisplayType.Block)
            {
                result.Append(Environment.NewLine);
            }

            result.Append($"<{_tagName}");

            if (_cssClasses.Any())
            {
                result.Append($" class=\"{string.Join(" ", _cssClasses)}\"");
            }

            result.Append(">");

            if (_closingType == ClosingType.Normal)
            {
                result.Append(InnerHTML());
                result.Append($"</{_tagName}>");
            }

            return result.ToString();
        }

        public void ClassName(string className)
        {
            if (!string.IsNullOrWhiteSpace(className))
            {
                _cssClasses.Add(className);
            }
        }

        public void TextContent(LightTextNode textNode)
        {
            if (textNode != null)
            {
                _children.Add(textNode);
            }
        }

        public void AppendChild(LightElementNode elementNode)
        {
            if (elementNode != null)
            {
                _children.Add(elementNode);
            }
        }

        public void Click()
        {
            DispatchEvent("click");
        }

        public void MouseOver()
        {
            DispatchEvent("mouseover");
        }
    }
}

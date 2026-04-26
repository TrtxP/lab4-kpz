using ClassLibraryBehavioralPatterns.Strategy;
using ClassLibraryStructurePatterns.Composite.Enums;
namespace ClassLibraryStructurePatterns.Composite.Classes
{
    public class LightImageNode : LightElementNode
    {
        private string? _src;
        private ImageLoadingStrategy? _imageLoadingStrategy;

        public LightImageNode() : base ("img", DisplayType.Inline, ClosingType.Single)
        {

        }

        public void SetSrc(string src)
        {
            _src = src;

            if (Uri.TryCreate(src, UriKind.Absolute, out var uri))
            {
                if (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps)
                {
                    SetImageLoadingStrategy(new NetworkLoadingStrategy());
                }
                else
                {
                    SetImageLoadingStrategy(new FileLoadingStrategy());
                }
            }
            else
            {
                throw new ArgumentException("Invalid URI format.", nameof(src));
            }
        }

        public void SetImageLoadingStrategy(ImageLoadingStrategy imageLoadingStrategy)
        {
            _imageLoadingStrategy = imageLoadingStrategy;
        }

        public void Load()
        {
            if (_src == null)
            {
                throw new InvalidOperationException("Source is not set.");
            }
            if (_imageLoadingStrategy == null)
            {
                throw new InvalidOperationException("Image loading strategy is not set.");
            }
            _imageLoadingStrategy.Load(_src);
        }

        public override string OuterHTML()
        {
            if (_src == null)
            {
                throw new InvalidOperationException("Source is not set.");
            }
            return $"<img src=\"{_src}\" />";
        }

        public override string InnerHTML()
        {
            return string.Empty;
        }
    }
}

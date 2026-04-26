using System.Text.RegularExpressions;
namespace ClassLibraryBehavioralPatterns.Strategy
{
    public class NetworkLoadingStrategy : ImageLoadingStrategy
    {
        private string? _src;
        public void Load(string src)
        {
            var pattern = @"^https?:\/\/[\w\-]+(\.[\w\-]+)+[/#?]?.*$";

            if (Regex.IsMatch(src, pattern))
            {
                _src = src;
            }
            else
            {
                throw new ArgumentException("Invalid URL format.", nameof(src));
            }
        }
    }
}

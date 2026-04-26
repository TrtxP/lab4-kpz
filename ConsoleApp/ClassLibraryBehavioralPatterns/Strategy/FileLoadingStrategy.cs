using System.Text.RegularExpressions;
namespace ClassLibraryBehavioralPatterns.Strategy
{
    public class FileLoadingStrategy : ImageLoadingStrategy
    {
        private string? _src;
        public void Load(string src)
        {
            var pattern = @"^[a-zA-Z]:\\(?:[^\\\/:*?""<>|\r\n]+\\)*[^\\\/:*?""<>|\r\n]+$";

            if (Regex.IsMatch(src, pattern))
            {
                _src = src;
            }
            else
            {
                throw new ArgumentException("Invalid file path format.", nameof(src));
            }
        }
    }
}

namespace ClassLibraryStructurePatterns.Proxy
{
    public class SmartTextChecker : ISmartTextReader
    {
        private ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string path)
        {
            Console.WriteLine("Opening file...");

            char[][] result = _reader!.ReadFile(path);

            if (result == null)
            {
                Console.WriteLine("File is not found");
                return Array.Empty<char[]>();
            }

            int totalLines = result.Length;
            int totalChars = 0;

            for (int i = 0; i < totalLines; i++)
            {
                totalChars += result[i].Length;
            }

            Console.WriteLine("File is read successfully.");
            Console.WriteLine($"Lines: {totalLines}\nChars: {totalChars}");

            Console.WriteLine("File is closed");

            return result;
        }
    }
}

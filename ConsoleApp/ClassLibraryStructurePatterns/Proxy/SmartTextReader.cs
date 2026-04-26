namespace ClassLibraryStructurePatterns.Proxy
{
    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadFile(string path)
        {
            path = Path.GetFullPath(path);

            var nullArr = new char[0][];

            if (!File.Exists(path))
            {
                Console.WriteLine("File not found");
                return nullArr;
            }

            string[] lines = File.ReadAllLines(path);

            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}

namespace ClassLibraryStructurePatterns.Adapter
{
    public class FileWriter
    {
        public void Write(string path, string content)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.Write(content);
                Console.WriteLine(content);
            }
        }

        public void WriteLine(string path, string content)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(content);
                Console.WriteLine(content);
            }
        }
    }
}

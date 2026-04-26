namespace ClassLibraryStructurePatterns.Adapter
{
    public class FileLogger : Logger
    {
        private readonly FileWriter _fileWriter = new FileWriter();
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public override void Log(string message)
        {
            _fileWriter.WriteLine(_path, $"[LOG] {message}");
        }

        public override void Error(string message)
        {
            _fileWriter.WriteLine(_path, $"[ERROR] {message}");
        }

        public override void Warn(string message)
        {
            _fileWriter.WriteLine(_path, $"[WARN] {message}");
        }
    }
}

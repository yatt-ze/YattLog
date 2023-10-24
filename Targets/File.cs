using YattLog.Configs;

namespace YattLog.Targets
{
    internal class File : BaseLog
    {
        private readonly string _path;

        public File(string? path = null)
        {
            if (!Path.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Logs")))
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Logs"));

            _path = path ?? Path.Combine(Directory.GetCurrentDirectory(), "Logs", $"{DateTime.Now.ToString("yyyMMdd")}.log");
        }

        public override void Log(LogLevel level, string message)
        {
            lock (_lock)
            {
                using (StreamWriter sw = new StreamWriter(_path, true))
                {
                    sw.WriteLine($"[{DateTime.Now}] [{level}] {message}");
                    sw.Close();
                }
            }
        }
    }
}
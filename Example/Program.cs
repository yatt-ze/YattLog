using YattLog;
using YattLog.Configs;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NoneExample();
            DefaultExample();
            StdExample();
            DefaultFileExample();
            PathFileExample();
        }

        private static void NoneExample()
        {
            Config stdConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.None
            };
            Logger stdLog = new Logger(stdConfig);

            stdLog.Debug("This is a none debug log");
            stdLog.Info("This is a none info log");
            stdLog.Warn("This is a none warn log");
            stdLog.Error("This is a none error log");
            stdLog.Fatal("This is a none fatal log");
        }

        private static void DefaultExample()
        {
            Logger stdLog = new Logger();

            stdLog.Debug("This is a default debug log");
            stdLog.Info("This is a default info log");
            stdLog.Warn("This is a default warn log");
            stdLog.Error("This is a default error log");
            stdLog.Fatal("This is a default fatal log");
        }

        private static void StdExample()
        {
            Config stdConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.Std
            };
            Logger stdLog = new Logger(stdConfig);

            stdLog.Debug("This is a std debug log");
            stdLog.Info("This is a std info log");
            stdLog.Warn("This is a std warn log");
            stdLog.Error("This is a std error log");
            stdLog.Fatal("This is a std fatal log");
        }

        private static void DefaultFileExample()
        {
            Config stdConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.File
            };
            Logger stdLog = new Logger(stdConfig);

            stdLog.Debug("This is a default file debug log");
            stdLog.Info("This is a default file info log");
            stdLog.Warn("This is a default file warn log");
            stdLog.Error("This is a default file error log");
            stdLog.Fatal("This is a default file fatal log");
        }

        private static void PathFileExample()
        {
            Config stdConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.File,
                Path = Path.Combine(Directory.GetCurrentDirectory(), "Yatt.log")
            };
            Logger stdLog = new Logger(stdConfig);

            stdLog.Debug("This is a file debug log with a specified path");
            stdLog.Info("This is a file info log with a specified path");
            stdLog.Warn("This is a file warn log with a specified path");
            stdLog.Error("This is a file error log with a specified path");
            stdLog.Fatal("This is a file fatal log with a specified path");
        }
    }
}

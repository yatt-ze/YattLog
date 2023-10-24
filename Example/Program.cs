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

        /// <summary>
        /// Wont do anything
        /// </summary>
        private static void NoneExample()
        {
            Config noneConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.None
            };
            Logger noneLog = new Logger(noneConfig);

            noneLog.Debug("This is a none debug log");
            noneLog.Info("This is a none info log");
            noneLog.Warn("This is a none warn log");
            noneLog.Error("This is a none error log");
            noneLog.Fatal("This is a none fatal log");
        }

        /// <summary>
        /// Uses the default configuration
        /// Target = Std
        /// Level = Info
        /// </summary>
        private static void DefaultExample()
        {
            Logger defaultLog = new Logger();

            defaultLog.Debug("This is a default debug log");
            defaultLog.Info("This is a default info log");
            defaultLog.Warn("This is a default warn log");
            defaultLog.Error("This is a default error log");
            defaultLog.Fatal("This is a default fatal log");
        }

        /// <summary>
        /// Logs to std with a debug level
        /// </summary>
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

        /// <summary>
        /// Logs to file in the default location (<Exe Location>/Logs/<date>.log)
        /// Level = Debug
        /// </summary>
        private static void DefaultFileExample()
        {
            Config dFileConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.File
            };
            Logger dFileLog = new Logger(dFileConfig);

            dFileLog.Debug("This is a default file debug log");
            dFileLog.Info("This is a default file info log");
            dFileLog.Warn("This is a default file warn log");
            dFileLog.Error("This is a default file error log");
            dFileLog.Fatal("This is a default file fatal log");
        }

        /// <summary>
        /// Logs to file in a specified location
        /// Level = Debug
        /// </summary>
        private static void PathFileExample()
        {
            Config pFileConfig = new Config
            {
                Level = LogLevel.Debug,
                Target = LogTarget.File,
                Path = Path.Combine(Directory.GetCurrentDirectory(), "Yatt.log")
            };
            Logger pFileLog = new Logger(pFileConfig);

            pFileLog.Debug("This is a file debug log with a specified path");
            pFileLog.Info("This is a file info log with a specified path");
            pFileLog.Warn("This is a file warn log with a specified path");
            pFileLog.Error("This is a file error log with a specified path");
            pFileLog.Fatal("This is a file fatal log with a specified path");
        }
    }
}
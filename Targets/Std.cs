using YattLog.Configs;

namespace YattLog.Targets
{
    internal class Std : BaseLog
    {
        public override void Log(LogLevel level, string message)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    writeToStd(ConsoleColor.Gray, level, message);
                    break;

                case LogLevel.Info:
                    writeToStd(ConsoleColor.Blue, level, message);
                    break;

                case LogLevel.Warn:
                    writeToStd(ConsoleColor.Yellow, level, message);
                    break;

                case LogLevel.Error:
                    writeToStd(ConsoleColor.Red, level, message);
                    break;

                case LogLevel.Fatal:
                    writeToStd(ConsoleColor.Magenta, level, message);
                    break;
            }
        }

        private void writeToStd(ConsoleColor color, LogLevel level, string message)
        {
            lock (_lock)
            {
                Console.Write("[");
                Console.ForegroundColor = color;
                Console.Write(level.ToString().ToUpper());
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"] {message}\n");
            }
        }
    }
}
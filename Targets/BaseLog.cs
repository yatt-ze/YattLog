using YattLog.Configs;

namespace YattLog.Targets
{
    internal abstract class BaseLog
    {
        protected readonly object _lock = new object();

        public abstract void Log(LogLevel level, string message);
    }
}
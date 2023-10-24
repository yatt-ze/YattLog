using YattLog.Configs;

namespace YattLog.Targets
{
    internal class None : BaseLog
    {
        public override void Log(LogLevel level, string message)
        {
            return;
        }
    }
}
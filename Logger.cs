using YattLog.Configs;
using YattLog.Targets;

namespace YattLog
{
    public class Logger
    {
        private Config _config;
        private BaseLog _logger;

        public Logger(Config? config = null)
        {
            _config = config ?? new Config() { Target = LogTarget.Std, Level = LogLevel.Info };

            switch (_config.Target)
            {
                case LogTarget.Std:
                    _logger = new Targets.Std();
                    break;

                case LogTarget.File:
                    _logger = new Targets.File(_config.Path);
                    break;

                case LogTarget.None:
                    _logger = new Targets.None();
                    break;

                default:
                    _logger = new Targets.Std();
                    break;
            }
        }

        public void Debug(string message)
        {
            if (_config.Level > LogLevel.Debug) return;
            _logger.Log(LogLevel.Debug, message);
        }

        public void Info(string message)
        {
            if (_config.Level > LogLevel.Info) return;
            _logger.Log(LogLevel.Info, message);
        }

        public void Warn(string message)
        {
            if (_config.Level > LogLevel.Warn) return;
            _logger.Log(LogLevel.Warn, message);
        }

        public void Error(string message)
        {
            if (_config.Level > LogLevel.Error) return;
            _logger.Log(LogLevel.Error, message);
        }

        public void Fatal(string message)
        {
            if (_config.Level > LogLevel.Fatal) return;
            _logger.Log(LogLevel.Fatal, message);
        }
    }
}
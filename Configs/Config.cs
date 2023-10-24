namespace YattLog.Configs
{
    public struct Config
    {
        public LogTarget Target { get; set; }
        public LogLevel Level { get; set; }
        public string? Path { get; set; }
    }
}
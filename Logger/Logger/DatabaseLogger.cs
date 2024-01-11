using Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class DatabaseLogger : ILogger
    {
        private readonly HashSet<LogLevel> supportedLevels;
        public DatabaseLogger(IEnumerable<LogLevel> supportedLevels)
        {
            this.supportedLevels = new HashSet<LogLevel>(supportedLevels);
        }
        public void LogMessage(LogMessage message)
        {
            if (supportedLevels.Contains(message.Level))
            {
                // Implement actual logging to Database
                Console.WriteLine($"[DataBaseSink] [{message.Level}] {message.Content}");
            }
        }
    }
}

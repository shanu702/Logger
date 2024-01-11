using Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class ConsoleLogger : ILogger
    {
        private readonly HashSet<LogLevel> supportedLevels;

        public ConsoleLogger(IEnumerable<LogLevel> supportedLevels)
        {
            this.supportedLevels = new HashSet<LogLevel>(supportedLevels);
        }

        public void LogMessage(LogMessage message)
        {
            if (supportedLevels.Contains(message.Level))
            {
                Console.WriteLine($"[ConsoleSink] [{message.Level}]  {message.Content}");
                // Implement actual logging to console
            }
        }
    }
}

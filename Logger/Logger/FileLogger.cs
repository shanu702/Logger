using Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class FileLogger : ILogger
    {
        private readonly HashSet<LogLevel> supportedLevels;

        public FileLogger(IEnumerable<LogLevel> supportedLevels)
        {
            this.supportedLevels = new HashSet<LogLevel>(supportedLevels);
        }

        public void LogMessage(LogMessage message)
        {
            if (supportedLevels.Contains(message.Level))
            {
                // Implement actual logging to file
                Console.WriteLine($"[FileSink] [{message.Level}] {message.Content}");
            }
        }
    }
}

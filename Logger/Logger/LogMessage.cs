using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class LogMessage
    {
        public string Content { get; set; }
        public LogLevel Level { get; set; }

        public LogMessage(string content, LogLevel level)
        {
            Content = content;
            Level = level;
        }

    }

}

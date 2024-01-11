using Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{

    public class Logger
    {
        private readonly List<LoggerConfiguration> configurations = new List<LoggerConfiguration>();

        public void Configure(LoggerConfiguration config)
        {
            configurations.Add(config);
        }

        public void LogMessage(LogMessage message)
        {
            foreach (var config in configurations)
            {
                foreach (var sink in config.Sinks)
                {
                    sink.LogMessage(message);
                }
            }
        }
    }
}


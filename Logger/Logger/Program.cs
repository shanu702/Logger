using System;
using System.Collections.Generic;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create logger configuration
            var config = new LoggerConfiguration();
            
            config.AddSink(new ConsoleLogger(new[] { LogLevel.FATAL, LogLevel.ERROR, LogLevel.WARN, LogLevel.INFO, LogLevel.DEBUG }));

            config.AddSink(new FileLogger(new[] { LogLevel.ERROR, LogLevel.WARN, LogLevel.INFO }));
            
            // Create logger library and configure it
            var logger = new Logger();
            logger.Configure(config);

            // Send messages
            
            logger.LogMessage(new  LogMessage("This is information Message", LogLevel.INFO));
            logger.LogMessage(new LogMessage ( "This is an error message." ,LogLevel.ERROR));
        }
    }
}

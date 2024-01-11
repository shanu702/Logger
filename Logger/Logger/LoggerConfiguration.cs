using Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{

    //Logs th co
    public class LoggerConfiguration
    {
        public List<ILogger> Sinks { get; } = new List<ILogger>();

        public void AddSink(ILogger sink)
        {
            Sinks.Add(sink);
        }
    }
}

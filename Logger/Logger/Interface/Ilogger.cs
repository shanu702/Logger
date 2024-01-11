using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interface
{
   public interface ILogger
    {

        //Log the message
        void LogMessage(LogMessage message);
    }
}

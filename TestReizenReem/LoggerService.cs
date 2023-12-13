using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
   public static class LoggerService
   {
       
        private static  LogMessage[] logs = new LogMessage[0];
        public static LogMessage[] Logs => logs;

       public static void AddLogMessage(LogMessage logMessage)
       {
         Array.Resize(ref logs, logs.Length +1);
            logs[logs.Length - 1] = logMessage;
       }
     
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class ReisReservatie:ILoggable
    {
        public LogMessage LogMessage { get;  set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }

        public ReisReservatie( Persoon persoon, Reis reis, Reisbureau reisbureau, LogMessage logMessage) 
        {
            LogMessage = new LogMessage("Reservation created.");
            LoggerService.AddLogMessage(LogMessage);
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
            AddLogMessage();
        }
        private void AddLogMessage()
        {
            LogMessage = new LogMessage($"Reservatie door {Persoon.Naam} via reisbureau{Reisbureau.Naam}");
            LoggerService.AddLogMessage( LogMessage );
        }

        public LogMessage GetLogMessage()
        {
            throw new NotImplementedException();
        }

        public void SetLogMessage(LogMessage value)
        {
            throw new NotImplementedException();
        }

       
    }
}

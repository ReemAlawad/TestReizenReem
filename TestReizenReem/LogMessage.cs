using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class LogMessage
    {
        public string BoodSchap { get; set; }
        public int ID { get; set; }
        
       
        public LogMessage(string boodSchap)
        {
            BoodSchap = boodSchap;
            ID = GenereerID();
        }
        static int GenereerID()
        {
            int hoogsteID = 0;
            return hoogsteID +1;
        }

      
    }
}

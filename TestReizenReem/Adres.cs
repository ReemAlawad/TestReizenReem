using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class Adres
    {
        public string Gemeente { get; set; }
        public string HuisNr { get; set; }
        public int Postcode { get; set; }
        public string Straat { get; set; }
        public Adres(string gemeente, string huisNr, int postCode, string straat) 
        {

            Gemeente = gemeente;
            HuisNr = huisNr;
            Postcode = postCode;
            Straat = straat;
        }
    }
}

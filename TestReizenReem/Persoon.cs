using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string VoorNaam { get; set; }
        public string FamilieNaam { get; set; }
        public string Naam { get; set; }//{ get { return $"{VoorNaam} {FamilieNaam}"; } }

        public Persoon(string voorNaam, string familieNaam,Adres adres)
        {
            VoorNaam = voorNaam;
            FamilieNaam = familieNaam;
            Adres = adres;
            

        }
       

       
    }
}

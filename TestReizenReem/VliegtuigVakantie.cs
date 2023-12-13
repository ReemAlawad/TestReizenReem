using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class VliegtuigVakantie : Reis
    {
        public double VliegtuigTicket { get; set; }
       
        public VliegtuigVakantie(DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen ,double vliegtuigTicket):base(vertrekDatum, terugKeerDatum, aantalPersonen) 
        {
            VliegtuigTicket = vliegtuigTicket;
        }

        public override double BerekenPrijs()
        {
            int aantalDagen = AantalDagen;
            double basisPrijs = aantalDagen * BasisDagPrijs;
            return basisPrijs + VliegtuigTicket;
        }

    }
}

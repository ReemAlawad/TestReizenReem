using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class Cruise : Reis
    {
        private const double CruisePrijsExtra = 10;
        public bool Vip { get; set; }

        public Cruise(DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPerson, bool vip) : base(vertrekDatum, terugKeerDatum, aantalPerson)
        {
            Vip = vip;
        }
        public override double BerekenPrijs()
        {
            int aantalDagen = AantalDagen;
            double basisPrijs = aantalDagen * BasisDagPrijs;
            double extraDagKost = aantalDagen * CruisePrijsExtra;
            if (Vip)
            {
                extraDagKost *= 1.5;
            }
            return basisPrijs + extraDagKost;
        }
        

       

       
    }
}

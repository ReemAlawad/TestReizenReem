using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public class Autovakantie : Reis
    {
        private const double ExtraPrijsHuurAuto = 10;
        public bool EigenWagen { get; set; }
        public Autovakantie(DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen ,bool eigenWagen):base(vertrekDatum, terugKeerDatum, aantalPersonen)
        {
            EigenWagen = EigenWagen;
        }
       
       

        public override  double BerekenPrijs()
        {
            int aantalDagen = AantalDagen;
            double basisPrijs = aantalDagen * BasisDagPrijs;
            //double huurAutoPrijs = EigenWagen ? 0 : aantalDagen * ExtraPrijsHuurAuto;
            //int aantalAutos = (int)Math.Ceiling((double)AantalPersonen / 5);
            if ( EigenWagen ) 
            {
                return basisPrijs + (AantalDagen * ExtraPrijsHuurAuto);
            }

            return basisPrijs;
        }

      
    }
}

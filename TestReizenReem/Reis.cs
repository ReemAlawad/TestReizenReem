using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    public abstract class Reis
    {
        protected const double BasisDagPrijs = 40;
       // public int AantalDagen { get; set; }
        public int AantalPersonen { get; set; }
        public DateTime TerugKeerDatum { get; set; }
        public DateTime VertrekDatum { get; set; }

        protected Reis(DateTime vertrekDatum, DateTime terugKeerDatum, int aantalPersonen)
        {
           
            if(vertrekDatum > DateTime.Now || terugKeerDatum > DateTime.Now || vertrekDatum < terugKeerDatum || aantalPersonen > 0 )
            {
                VertrekDatum = vertrekDatum;
                TerugKeerDatum = terugKeerDatum;
                AantalPersonen = aantalPersonen;
            }
            else
            {
                Console.WriteLine("Ongeldige data voor vertrek en of terug keer");
            }
        }
        public int AantalDagen { get { return (TerugKeerDatum - VertrekDatum).Days; } }
        public abstract double BerekenPrijs();
       

        //public  double BerekenPrijs()
        //{
        //    return 0;
        //}

       

        //public  Reis()
        //{

        //}
    }
}

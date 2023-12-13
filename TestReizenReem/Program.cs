using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReizenReem
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ReisReservatie reservatie1 = new ReisReservatie
            (

                 new Persoon("Wauter", "Hilkens", new Adres("", "", 2060, "")),
                 new Autovakantie(new DateTime(30 / 12 / 2023), new DateTime(20 / 12 / 2020), 60, false),
                 new Reisbureau { Naam = "Jetair" },
                 new LogMessage("")

            );
            Reis reis = new Autovakantie(new DateTime(30 / 12 / 2023), new DateTime(20 / 12 / 2020), 60, true);
          // reis.AantalDagen.ToString();
            reis.BerekenPrijs();
            Console.WriteLine(reis.BerekenPrijs());
            ReisReservatie reservatie2 = new ReisReservatie
                (
                     new Persoon("Tony", "Montana", new Adres("", "", 2060, "")),
                     new VliegtuigVakantie(new DateTime(30 / 12 / 2023), new DateTime(20 / 12 / 2023), 4, 120.0),
                     new Reisbureau { Naam = "Thomas Cook" },
                     new LogMessage("")

                );
           

            ReisReservatie reservatie3 = new ReisReservatie
            (
                new Persoon("Wauter", "Hilkens",new Adres ( "","",2060,"")),
                 new Cruise(new DateTime( 01/10/2023), new DateTime(10/10/2023),4, true),
                 new Reisbureau { Naam = "Neckermann" },
                 new LogMessage("")
            );
            
            ReisReservatie reservatie4 = new ReisReservatie
            (
                 new Persoon("Tony", "Montana", new Adres("", "", 2060, "")),
                 new VliegtuigVakantie(new DateTime(30 / 12 / 2023), new DateTime(20 / 12 / 2023), 4, 200.0),
                 new Reisbureau { Naam = "Jetair" },
                 new LogMessage("")
            );

            // عرض بيانات الحجز وتكلفة الرحلة
            DisplayReservationInfo(1,reservatie1);
            DisplayReservationInfo(2,reservatie2);
            DisplayReservationInfo(3,reservatie3);
            DisplayReservationInfo(4,reservatie4);

            PrintKostPrijs(1,reservatie1);
            PrintKostPrijs(2,reservatie2);
            PrintKostPrijs(3,reservatie3);
            PrintKostPrijs(4,reservatie4 );

            Console.ReadLine();

        }
        static void DisplayReservationInfo(int numer, ReisReservatie reservatie)
        {
           Console.WriteLine($"{numer}: Reis gereserveerd door {reservatie.Persoon.VoorNaam} {reservatie.Persoon.FamilieNaam} via reisbureau {reservatie.Reisbureau.Naam}");
        }
        static void PrintKostPrijs(int numer, ReisReservatie reservatie)
        {
          Console.WriteLine($"kostPrijs reis {numer}: {reservatie.Reis.BerekenPrijs():F2} euro");
        }
    }
}

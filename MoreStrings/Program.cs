using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonna nime
            //programm tervitab kasutajat kautades tema initsiaale

            Console.WriteLine("sisestage oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisestage oma perekonna nimi");
            string lastname = Console.ReadLine();
            Console.WriteLine($"tere {firstname[0]}. {lastname[0]}.");            
        }
    }
}

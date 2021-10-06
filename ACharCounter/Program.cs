using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt siesesada eesnimi
            //programm küsib kasutajalt seisestada perkonnanimi
            //programm kuvab mitu, 'a' täthe kasutaja éesnimes ja 
            //perekonna nimes on

            int counter = 0;
            
            Console.WriteLine("sisestage eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisestage perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}".ToLower();

            for (int i = i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {
                    counter++;
                }

                
            }
            if (counter == 1)
            {
                Console.WriteLine($"sinu nimes on {counter} 'a' täht");
            }
            else
            {
                Console.WriteLine($"sinu nimes on {counter} 'a' tähte");
            }

           
            
            
                


            
            
            
            
        }
    }
}

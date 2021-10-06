using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o' ja 'l' tähte on lauses "Hello, World!"

            string helloW = "Hello World!".ToLower();

            int counter1 = 0;
            int counter = 0;
            int counter2 = 0;
            for (int i = 0; i < helloW.Length; i++)             
            {
                if (helloW[i] == 'h')
                {
                    counter++;
                }                                   
                if (helloW[i] == 'l')
                {
                    counter1++;
                }                                    
                if (helloW[i] == 'o')
                {
                    counter2++;
                }
            }
            Console.WriteLine($"Hello worldis on {counter} h {counter1} l ja {counter2} o");
        }
    }
}

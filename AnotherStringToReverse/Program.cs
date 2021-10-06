using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab tagurpidi hello world
            string helloW = "hello world!";

            for (int i = helloW.Length - 1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }

            
           
            
        }
    }
}

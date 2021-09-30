using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis 
            //i will not skateboard in the hall
            //10 korda

            //i++ = i + 1
            for (int i = 0; i < 10; i++) //int i = 0 - start, i < 10 - end; i++ step
            {
                Console.WriteLine($"{i + 1}. I will not skateboard int the hall.");
            }

            
        }
    }
}

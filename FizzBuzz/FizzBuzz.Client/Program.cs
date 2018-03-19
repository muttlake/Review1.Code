using System;

namespace FizzBuzz.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }

        static void FizzBuzz()
        {
            int beginning, end;
            Console.WriteLine("Enter beginning: ");
            beginning = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end: ");
            end = Convert.ToInt32(Console.ReadLine());

            if(beginning <= 0) { beginning = 0; }
            if(end < beginning + 10) { end = beginning + 10;}

            int numF = 0, numB = 0, numFB = 0;

            for (int i = beginning; i <= end; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine(i.ToString() + " " + "FizzBuzz");
                    numFB++;
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine(i.ToString() + " " + "Fizz");
                    numF++;
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine(i.ToString() + " " + "Buzz");
                    numB++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Fizz Count: " + numF.ToString());
            Console.WriteLine("Buzz Count: " + numB.ToString());
            Console.WriteLine("FizzBuzz Count: " + numFB.ToString());
        }
    }
}

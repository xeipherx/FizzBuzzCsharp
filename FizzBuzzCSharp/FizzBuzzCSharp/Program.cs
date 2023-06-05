using System;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 31; i++)
            {
                FizzBuzz(i);
            }
        }

        public static void FizzBuzz(int nmbr)
        {
            string text = "";
            if (nmbr % 3 == 0)
            {
                text += "Fizz";
            }
            if (nmbr % 5 == 0)
            {
                text += "Buzz";
            }
            string output = String.IsNullOrEmpty(text) ? nmbr.ToString() : text;
            Console.WriteLine(output);
        }
    }
}

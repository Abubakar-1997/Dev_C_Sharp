using System;

namespace DevCSharp.Chapter3
{
    internal class OddEven324
    {
        public int UserValue;

        public void OddOrEven()
        {
            Console.Write("Enter Value for Even or Odd: ");
            UserValue = int.Parse(Console.ReadLine());
            if (UserValue <= 0)
                Console.WriteLine($"{UserValue} is an invalid Number");
            else if (UserValue % 2 == 0)
                Console.WriteLine($"{UserValue} is an Even Number");

            else
                Console.WriteLine($"{UserValue} is an Odd Number");
        }
    }
}
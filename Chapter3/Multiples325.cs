using System;


namespace DevCSharp.Chapter3
{
    class Multiples325
    {
        /* Write an app that reads two integers, determines whether
         the first is a multipleof the second and displays the result*/

        public int ValueOne;
        public int ValueTwo;

        public void PromptValue()
        {
            Console.Write("Enter Value one: ");
            ValueOne = int.Parse(Console.ReadLine());

            Console.Write("Enter Value Two: ");
            ValueTwo = int.Parse(Console.ReadLine());
        }

        public void CalculateAndPrint()
        {
            if (ValueOne % ValueTwo == 0)
            {
                Console.WriteLine($" {ValueOne} is a multiple of {ValueTwo}");
            }

            else
            {
                Console.WriteLine($" {ValueOne} is not multiple of {ValueTwo}");
            }
        }
    }
}

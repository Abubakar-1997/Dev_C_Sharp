using System;

namespace DevCSharp.Chapter3
{
    internal class ArithmeticSmallestLargest317
    {

        /*
         * Write an app that inputs three integers from the user and displays
         * the sum, average, product, and smallest and largest of the numbers.
         */
        public int Largest;
        public int Smallest;
        public int ValueOne;
        public int ValueThree;
        public int ValueTwo;

        public void GetUserInput()
        {
            Console.Write("Enter value one: ");
            ValueOne = int.Parse(Console.ReadLine());

            Console.Write("Enter value two: ");
            ValueTwo = int.Parse(Console.ReadLine());

            Console.Write("Enter value three: ");
            ValueThree = int.Parse(Console.ReadLine());
        }

        public void LargestAndLowest()
        {
            Largest = ValueOne;
            Smallest = ValueOne;

            if (Largest < ValueTwo || Largest < ValueThree)
            {
                if (Largest < ValueTwo && ValueTwo > ValueThree)
                    Largest = ValueTwo;

                else
                    Largest = ValueThree;
            }

            if (Smallest > ValueTwo || Smallest > ValueThree)
            {
                if (Smallest > ValueTwo && ValueTwo < ValueThree)
                    Smallest = ValueTwo;

                else
                    Smallest = ValueThree;
            }
        }

        public void PrintValues()
        {
            Console.WriteLine($"Sum value: {ValueTwo + ValueOne + ValueThree}");
            Console.WriteLine($"Average value: {(ValueTwo + ValueOne + ValueThree) / 3}");
            Console.WriteLine($"Product value: {ValueTwo * ValueOne * ValueThree}");
            Console.WriteLine($"largest value: {Largest}");
            Console.WriteLine($"smallest value: {Smallest}");
        }
    }
}
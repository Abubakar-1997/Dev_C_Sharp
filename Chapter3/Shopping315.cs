using System;


namespace DevCSharp.Chapter3
{
    public class Shopping315
    {
        /*Write an app that asks the buyer to enter the price of three items,
         calculates an applicable 10% discount on the items,
         and displays the net amount payable.*/


        public double FirstItem;
        public double SecondItem;
        public double ThirdItem;

        public void GetInput()
        {
            Console.Write("Enter value one: ");
            FirstItem = double.Parse(Console.ReadLine());

            Console.Write("Enter value two: ");
            SecondItem = double.Parse(Console.ReadLine());

            Console.Write("Enter value three: ");
            ThirdItem = double.Parse(Console.ReadLine());

        }

        public void CalculateDiscount()
        {
            FirstItem = FirstItem - (FirstItem * 0.10);
            SecondItem = SecondItem - (SecondItem * 0.10);
            ThirdItem = ThirdItem - (ThirdItem * 0.10);
        }

        public void DisplayNetAmount()
        {
            Console.WriteLine($"Net value one: {FirstItem}");
            Console.WriteLine($"Net value two: {SecondItem}");
            Console.WriteLine($"Net value three: {ThirdItem}");
        }
    }
}

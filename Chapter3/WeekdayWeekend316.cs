using System;


namespace DevCSharp.Chapter3
{
    class WeekdayWeekend316
    {
        /*
         * Write an app that asks the user to enter an integer and
         * displays the words "working day" if the input is from 1 to 5 or
         * "weekend" if the input is 6 or 7.
         * Any other input should display "invalid"
         */

        public int UserInput;

        public void GetUserInput()
        {
            Console.Write("Enter value: ");
            UserInput = int.Parse(Console.ReadLine() ?? string.Empty);
        }

        public void DisplayDay()
        {
            if (UserInput is >= 1 and <= 7)
            {
                if (UserInput is 6 or 7)
                {
                    Console.WriteLine("This is a weekend");
                }
                else
                {
                    Console.WriteLine("This is a working day");
                }
            }

            else
            {
                Console.WriteLine("This input is invalid");
            }
        }
    }
}

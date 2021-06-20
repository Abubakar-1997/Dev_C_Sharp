using System;
namespace DevCSharp.Chapter4
{
    class Coaching412
    {
        public Coaching412(string coachingType, int numberOfPlayers, string classTimings, decimal charges)
        {
            CoachingType = coachingType;
            NumberOfPlayers = numberOfPlayers;
            ClassTimings = classTimings;
            Charges = charges;
        }

        private string CoachingType { get; set; }
        private int NumberOfPlayers { get; set; }
        private string ClassTimings { get; set; }
        private decimal Charges { get; set; }


        public void DisplayDetails()
        {
            Console.Write("Coaching type: ");
            Console.WriteLine(CoachingType);
            Console.Write("Number Of Players : ");
            Console.WriteLine(NumberOfPlayers);
            Console.Write("Class Timings: ");
            Console.WriteLine(ClassTimings);
            Console.Write("Charges: ");
            Console.WriteLine(Charges);
        }

    }
}
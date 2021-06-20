using System;

namespace DevCSharp.Chapter4
{
    public class HeartRates
    {
        private const int HeartBeatConstRate = 220;
        private int _currentYear;
        private string _firstName;
        private string _lastName;
        private int _yearOfBirth;


        //Constructors
        public HeartRates(string firstName, string lastName, int birthYear, int currentyear)
        {
            _firstName = firstName;
            _lastName = lastName;
            _yearOfBirth = birthYear;
            _currentYear = currentyear;
        }


        //Properties for Info
        public string FirstName
        {
            get => _firstName;
            private set
            {
                if (value != "") _firstName = value;
            }
        }

        public int YearOfBirth
        {
            get => _yearOfBirth;
            private set
            {
                if (value > 1900) _yearOfBirth = value;
            }
        }

        public int CurrentYear
        {
            get => _currentYear;
            private set
            {
                if (value > YearOfBirth) _currentYear = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            private set
            {
                if (value != "") _lastName = value;
            }
        }


        //Methods for Prompting 
        public string PromptName(string prompt)
        {
            Console.Write($"Please Enter your {prompt} here: ");
            var name = Console.ReadLine();
            return name;
        }

        public int PromptNum(string prompt)
        {
            var num = int.Parse(PromptName(prompt));
            return num;
        }


        //Methods to Assign
        public string AssignFirstName()
        {
            FirstName = PromptName("First Name");
            return FirstName;
        }

        public string AssignLastName()
        {
            LastName = PromptName("Last Name");
            return LastName;
        }

        public int AssignYearOfBirth()
        {
            YearOfBirth = PromptNum("Year of Birth");
            return YearOfBirth;
        }

        public int AssignCurrentYear()
        {
            CurrentYear = PromptNum("Current Year");
            return CurrentYear;
        }


        //Calculating the age of Person and their heart beats
        private int AgeOfPerson()
        {
            return CurrentYear - YearOfBirth;
        }

        private int MaximumHeartRate()
        {
            return HeartBeatConstRate - AgeOfPerson();
        }

        private double TargetMinimumHeartRate()
        {
            return MaximumHeartRate() * 0.5;
        }

        private double TargetMaximumHeartRate()
        {
            return MaximumHeartRate() * 0.85;
        }


        //Displaying their personal docs
        public void DisplayPersonRecords()
        {
            Console.WriteLine("This will display records: ");
            Console.Write("First Name: ");
            Console.WriteLine(FirstName);
            Console.Write("Last Name: ");
            Console.WriteLine(LastName);
            var age = AgeOfPerson();
            Console.Write("Age: ");
            Console.WriteLine(age);
            var maxrate = MaximumHeartRate();
            Console.Write("HeartRate: ");
            Console.WriteLine(maxrate);
            var mintar = TargetMinimumHeartRate();
            Console.Write("Target Min: ");
            Console.WriteLine(mintar);
            var maxtar = TargetMaximumHeartRate();
            Console.Write("Target Max: ");
            Console.WriteLine(maxtar);
        }
    }
}
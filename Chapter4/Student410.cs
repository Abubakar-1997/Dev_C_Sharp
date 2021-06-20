using System;

namespace DevCSharp.Chapter4
{
    internal class Student410
    {
        private decimal SubjectOne;
        private decimal SubjectThree;
        private decimal SubjectTwo;

        public Student410(string studentName, string studentID, decimal initiSubjectOne, decimal initiSubjectTwo,
            decimal initiSubjectThree)
        {
            Name = studentName;
            ID = studentID;
            SubjectOne = initiSubjectOne;
            SubjectTwo = initiSubjectTwo;
            SubjectThree = initiSubjectThree;
        }

        /*
         * A Student record should include five pieces of information  as  either  instance  variables
         * or auto-implemented  properties:
         * a  student's  id  (type string), a student's name (type string) and
         * three separate variables for scores in three subjects (type decimal).
         * Your class should have a constructor that initializes the five values.
         * Provide a property with a get and set accessor for any instance variables.
 * For the scores in subjects, if the value passed to the set accessor is negative,the value of the instance variable should be left unchanged.
         * Also, provide methods named GetAggregate and GetPercentage that calculate the aggregate marks in the three subjects
         * (sum of three subject marks) and the percentage (i.e., sum divided by the maximum marks, 50, and then multiplied by 100),
         * and then return the aggregate and percentage as decimal value.
         * Write a test app named  StudentRecordTest that demonstrates class Student’s capabilities.
         */
        private string Name { get; }
        private string ID { get; }


        public decimal SubjectOneScore
        {
            get => SubjectOne;

            private set
            {
                if (value > 0) SubjectOne = value;
            }
        }

        public decimal SubjectTwoScore
        {
            get => SubjectTwo;

            private set
            {
                if (value > 0) SubjectTwo = value;
            }
        }

        public decimal SubjectThreeScore
        {
            get => SubjectThree;

            private set
            {
                if (value > 0) SubjectThree = value;
            }
        }

        public decimal SetDecimal(decimal number)
        {
            return number;
        }

        private decimal GetAggregate()
        {
            var TotalScore = SubjectOne + SubjectTwo + SubjectThree;
            return TotalScore;
        }

        private decimal GetPercentage()
        {
            var sum = GetAggregate();
            var PercentageScore = sum / 50 * 100;
            return PercentageScore;
        }

        public void StudentRecordTest()
        {
            var sumIs = GetAggregate();
            var percen = GetPercentage();
            Console.WriteLine("This is for printing records");
            Console.WriteLine($"Name of student: {Name}, ID: {ID}");
            Console.WriteLine($"Sum: {sumIs}  Percentage: {percen}");
        }
    }
}
using DevCSharp.Chapter4;


namespace DevCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HeartRates Abubakar = new HeartRates("a", "b", 0, 2020);
            Abubakar.AssignFirstName();
            Abubakar.AssignLastName();
            Abubakar.AssignYearOfBirth();
            Abubakar.AssignCurrentYear();

            Abubakar.DisplayPersonRecords();
        }
    }
}

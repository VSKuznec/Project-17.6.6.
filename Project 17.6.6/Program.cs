using Project_17._6._6_.Profiles;

namespace Project_17._6._6_
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ordinary = new Calculator();
            ordinary.Calculate(new OrdinaryProfile());

            Console.WriteLine();

            var salary = new Calculator();
            salary.Calculate(new SalaryProfile());
        }
    }
}
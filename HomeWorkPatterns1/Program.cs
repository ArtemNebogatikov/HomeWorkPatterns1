namespace HomeWorkPatterns1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 1500;

            IAccount regularAccount = new RegularAccount(balance);
            double regularInterest = regularAccount.CalculateInterest();

            IAccount salaryAccount = new SalaryAccount(balance);
            double salaryInterest = salaryAccount.CalculateInterest();

            Console.WriteLine($"Проценты по обычному счету: {regularInterest}");
            Console.WriteLine($"Проценты по зарплатному счету: {salaryInterest}");

            Console.ReadLine();
        }
    }
}
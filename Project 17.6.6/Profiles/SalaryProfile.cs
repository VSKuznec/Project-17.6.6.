using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17._6._6_.Profiles
{
    public class SalaryProfile : IProfile
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Зарплатный");
            Account account = new Account();
            account.Interest = account.Balance * 0.5;
        }
    }
}

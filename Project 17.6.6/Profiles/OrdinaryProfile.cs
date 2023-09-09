using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17._6._6_.Profiles
{
    public class OrdinaryProfile : IProfile
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Обычный");
            Account account = new Account();
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}

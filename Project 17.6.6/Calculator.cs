using Project_17._6._6_.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_17._6._6_
{
    public class Calculator
    {
        public void Calculate(IProfile calc)
        {
            calc.CalculateInterest();
        }
    }
}

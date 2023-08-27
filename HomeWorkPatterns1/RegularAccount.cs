using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPatterns1
{
    internal class RegularAccount : IAccount
    {
        public double Balance{get;set;}

        public RegularAccount(double balance)
        {
            Balance = balance;
        }

        public double CalculateInterest()
        {
            double interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;

            if (Balance >= 1000)
                interest -= Balance * 0.4;

            return interest;
        }
    }
}

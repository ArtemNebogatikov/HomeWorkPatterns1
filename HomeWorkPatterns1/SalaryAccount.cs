using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPatterns1
{
    internal class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        public SalaryAccount(double balance)
        {
            Balance = balance;
        }

        public double CalculateInterest()
        {

            return Balance * 0.5;
        }
    }
}

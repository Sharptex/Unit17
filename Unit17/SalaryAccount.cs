using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    public class SalaryAccount : Account
    {
        public SalaryAccount(double balance) : base(balance)
        { }

        public override void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}

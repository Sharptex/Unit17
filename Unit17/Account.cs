using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    public abstract class Account : ICalculate
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; protected set; }

        public Account(double balance)
        {
            Balance = balance;
        }

        public abstract void CalculateInterest();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    class Program
    {
        static void Main(string[] args)
        {
            var commonAcc = new CommonAccount(1000000);
            var salaryAcc = new SalaryAccount(10000);

            Calculator.CalculateInterest(commonAcc);
            Calculator.CalculateInterest(salaryAcc);

            Console.WriteLine(commonAcc.Interest);
            Console.WriteLine(salaryAcc.Interest);

            Console.ReadKey();
        }
    }
}

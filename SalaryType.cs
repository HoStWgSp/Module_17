using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class SalaryType : IInterest
    {
        Account account;
        public SalaryType(Account account) { this.account = account; }
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;

            Console.WriteLine($"Тип аккаунта {account.Type} и его процентная ставка {account.Interest}");
        }
    }
}

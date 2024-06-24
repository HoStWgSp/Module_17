using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class GeneralType : IInterest
    {
        Account account;
        public GeneralType(Account account) { this.account = account; }
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;

            Console.WriteLine($"Тип аккаунта {account.Type} и его процентная ставка {account.Interest}");
        }
    }
}

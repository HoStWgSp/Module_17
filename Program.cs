
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = new Type();

            type.CalculateInterest(new GeneralType(new Account() { Type = "Обычный", Balance = 900 }));

            Console.WriteLine();

            type.CalculateInterest(new SalaryType(new Account() { Type = "Зарплатный", Balance = 1500 }));

            Console.ReadKey();
        }
    }
}

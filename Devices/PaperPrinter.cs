using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Devices
{
    internal class PaperPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Печатаем на бумаге");
        }
    }
}

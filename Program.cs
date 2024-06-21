using Module_17.Components;
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

            IdeFacade ideFacade = new IdeFacade(new Editor(), new Compiller(), new Runtime());

            ideFacade.Start("Console.WriteLine(\"Hello World!\");");
            ideFacade.Stop();

            Console.ReadKey();
        }
    }
}

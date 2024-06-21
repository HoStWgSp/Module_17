using Module_17.Factories;
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
            var dragon = new Monster(new DragonFactory());
            dragon.Move();
            dragon.Hit();

            Console.WriteLine();

            var orc = new Monster(new OrcFactory());
            orc.Move();
            orc.Hit();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

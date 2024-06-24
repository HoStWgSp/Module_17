
using Module_17.States;
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
                // инициализируем лифт (находится на земле)
                Elevator elevator = new Elevator(new GroundElevatorState());

                elevator.Up(); // подъем наверх
                elevator.Down(); // спуск на землю
                elevator.Down(); // спуск в подвал
            

            Console.ReadKey();
        }
    }
}

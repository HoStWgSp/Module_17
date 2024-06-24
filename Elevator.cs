using Module_17.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class Elevator
    {
        public IElevatorState ElevatorState { get; set; }
        public Elevator(IElevatorState elevatorState)
        {
            ElevatorState = elevatorState;
        }
        // Подъем
        public void Up()
        {
            ElevatorState.Up(this);
        }

        // Спуск
        public void Down()
        {
            ElevatorState.Down(this);
        }
    }
}

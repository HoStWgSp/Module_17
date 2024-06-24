using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.States
{
    public interface IElevatorState
    {
        void Up(Elevator elevator);
        void Down(Elevator elevator);
    }
}

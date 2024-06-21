using Module_17.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    internal class ImageDrawer
    {
        public void DrawWith(IPrinter printer)
        {
            printer.Print();
        }
    }
}

using Module_17.Devices;
using Module_17;
using Module_17;
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
            var imageDrawer = new ImageDrawer();

            PaperPrinter paperPrinter = new PaperPrinter();

            imageDrawer.DrawWith(paperPrinter);

            CanvasPainter canvasPainter = new CanvasPainter();

            IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
            imageDrawer.DrawWith(imagePrinter);

            Console.ReadKey();
        }
    }
}

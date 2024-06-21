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
            
            Component rootFolder = new Folder("Root");

            Component myFile = new File("NewFile.txt");

            Folder documentFolder = new Folder("MyDocuments");

            rootFolder.Add(myFile);
            rootFolder.Add(documentFolder);

            Component MyFile2 = new File("NewFile2.txt");
            documentFolder.Add(MyFile2);


            rootFolder.Display();

            Console.ReadKey();
        }
    }
}

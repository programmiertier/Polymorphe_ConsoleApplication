using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Polymorphe_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Wurzel myRoot = new Wurzel();
            Wurzel anotherRoot = new Wurzel(42);
            WriteLine("Das Objekt hat die Eigenschaft _gekapselteGanzzahl = {0}", anotherRoot.gekapselteGanzzahl);
            
            // anotherRoot.gekapselteGanzzahl = 33;
            WriteLine("Das Objekt hat die Eigenschaft _gekapselteGanzzahl = {0}", anotherRoot.Ganzzahlbeschaffer());
            WriteLine("-----");
            ReadLine();

            Ableitung myDerivat = new Ableitung(55);
            WriteLine(myDerivat.Ganzzahlbeschaffer());
            Ableitung hier = new Ableitung();
            ReadLine();
            
        }
    }
}

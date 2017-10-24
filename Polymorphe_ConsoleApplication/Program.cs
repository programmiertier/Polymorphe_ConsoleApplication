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
            WriteLine("Wert des Attributes Ganzzahlbeschaffer() {0}", myDerivat.Ganzzahlbeschaffer());
            Ableitung hier = new Ableitung();
            WriteLine("-----");
            ReadLine();
            WeitereAbleitung anotherDerivat = new WeitereAbleitung(111);
            WriteLine("Wert des Attributes Ganzzahlbeschaffer() {0}", anotherDerivat.Ganzzahlbeschaffer());
            WeitereAbleitung dort = new WeitereAbleitung();
            WriteLine("-----");
            ReadLine();
            // Ein Array mit gemischten Objekten aus
            // allen drei Klassen
            object[] alleZusammen = new object[5];
            WriteLine("Das Array ist {0} lang", alleZusammen.Length);
            alleZusammen[0] = new Wurzel(99);
            alleZusammen[1] = new Ableitung(11);
            alleZusammen[2] = new WeitereAbleitung(22);
            alleZusammen[3] = new Wurzel(33);
            alleZusammen[4] = new Ableitung(44);
            WriteLine("Das erste Element im Array {0}", alleZusammen[0]);
            WriteLine("Das zweite Element im Array {0}", alleZusammen[1]);
            WriteLine("Das dritte Element im Array {0}", alleZusammen[2]);
            WriteLine("Das vierte Element im Array {0}", alleZusammen[3]);
            WriteLine("Das letzte Element im Array {0}", alleZusammen[4]);
            WriteLine("-----");
            ReadLine();

            WriteLine("-----");
            foreach(Wurzel platzhalterHierher in alleZusammen)  // wenn object statt Wurzel, dann verliert er Informationen
            {
                WriteLine("Typ des Elements {0}", platzhalterHierher);
                WriteLine("Darin gekapselte Ganzzahl : {0}", platzhalterHierher.gekapselteGanzzahl);    // Attributliste
                platzhalterHierher.normalVerhalten();
            }
            WriteLine("-----");
            ReadLine();

        }
    }
}

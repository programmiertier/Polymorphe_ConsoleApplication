using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Polymorphe_ConsoleApplication
{
    class Ableitung : Wurzel
    {
        // durch die Vererbung hat Ableitung
        // die public Attribute ganzzahl
        // die Methoden gekapselteGanzzahl und Ganzzahlbeschaffer

        // und ruft bei siner Instanziereung
        // den Konstruktor Wurzel() auf
        

        public Ableitung(int zaehler)   // überladener Konstruktor
        {
            gekapselteGanzzahl = zaehler;   // nutzt den geerbten setter
        }

        public Ableitung()
        {

        }
    }
}

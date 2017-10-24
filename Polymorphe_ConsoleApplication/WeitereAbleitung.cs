using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Polymorphe_ConsoleApplication
{
    class WeitereAbleitung : Wurzel     // abgeleitet von Wurzel
    {
        public WeitereAbleitung(int zaehler)   // überladener Konstruktor
        {
            gekapselteGanzzahl = zaehler;   // nutzt den geerbten setter
        }

        public WeitereAbleitung()
        {

        }

        public override void normalVerhalten()
        {
            WriteLine("Ich bin so richtig super");
        }
    }
}

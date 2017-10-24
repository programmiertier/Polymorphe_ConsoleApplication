using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Polymorphe_ConsoleApplication
{
    internal class Wurzel
    {
        public int ganzzahl;    // standard private
                                // erst Schutzgrad (private, protected, public) DANN der Datentyp

        private int _gekapselteGanzzahl;


        public Wurzel()
        {
            WriteLine("Es wurde der Konstruktor Wurzel() aufgerufen");
            WriteLine("Der Auslöder des Aufrufes war ein Objekt vom");
            WriteLine(this);    //this ist Zeiger auf das aufrufende Objekt
        }

        public Wurzel(int persoenlicherParameter)
        {
            // ganzzahl = persoenlicherParameter;
            _gekapselteGanzzahl = persoenlicherParameter;
            WriteLine("Es wurde der Konstruktor Wurzel({0}) aufgerufen", gekapselteGanzzahl);
        }

        public int gekapselteGanzzahl
        {
            get
            {
                return _gekapselteGanzzahl;
            }
            set
            {
                _gekapselteGanzzahl = value;
            }
            
        }

        // 'klassische' Variante zum getter 
        public int Ganzzahlbeschaffer()
        {
            return _gekapselteGanzzahl;
        }
        
    }
}

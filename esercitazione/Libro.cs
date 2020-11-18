using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione
{
    class Libro
    {
        /*Alunno 1: sviluppare la classe libro per la memorizzazione delle informazioni indicate, che preveda
        l’aggiunta di proprietà sia per la restituzione che per la modifica dei valori degli attributi contenuti e dei
         metodi
         • toString che restituisce una stringa con tutti i dati dell'oggetto su cui è invocato
         • readingTime che restituisce un tempo di lettura pari a 1h se le pagine sono inferiori a 100, un valore
          pari a 2h se le pagine sono comprese tra 100 e 200 e un tempo superiore alle 2h se le pagine sono in
         quantitativo superiore a 200.*/

        public string _titoloLibro;
        public string _autore;
        public int _anno;
        public string _editore;
        public int _numeroPagine;

    }
}

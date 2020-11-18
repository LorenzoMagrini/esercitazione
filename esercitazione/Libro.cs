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
        List<Libro> libro = new List<Libro>();
        public Libro(string titolo, string autore, int anno, string editore, int numeroPagine)
        {
            _titoloLibro = titolo;
            _autore = autore;
            _anno = anno;
            _editore = editore;
            _numeroPagine = numeroPagine;
        }

        public string TitoloLibro
        {
            set;
            get;
        }
        public string Autore
        {
            set;
            get;
        }
        public int anno
        {
            set
            {
                if (value > 2020)
                {
                    throw new Exception("annoo non riconosciuto");
                }
            }
            
                get => default;
            
           
        }
        public string Editore
        {
            set;
            get;
        }
        public int NumeroPagine
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("pagine non riconosciute");
                }
            }
            get => default;
        }
        public int ReadingTime(int numeroPagine)
        {
            if(numeroPagine<100)
            {
                return 1;
            }
            if (numeroPagine <= 100 || numeroPagine <= 200)
            {
                return 2;
            }
            if (numeroPagine > 200)
            {
                return 3;//numero superiore a 2
            }
            else
            {
                throw new Exception("tempo troppo breve");
            }
        }

    }
}

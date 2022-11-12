using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica
{
    class Libro
    {
        string autore, titolo, editore;
        int annoDiPubblicazione, numeroDiPagine;
        public Libro(string autore, string titolo, string editore, int annoDiPubblicazione, int numeroDiPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.editore = editore;
            this.annoDiPubblicazione = annoDiPubblicazione;
            this.numeroDiPagine = numeroDiPagine;
        }
        public string toString()
        {
            string a = "Autore --> " + this.autore + " ";
            a += "Titolo --> " + this.titolo + " ";
            a += "Editore --> " + this.editore + " ";
            a += "Anno di pubblicazione --> " + this.annoDiPubblicazione + " ";
            a += "Numero di Pagine --> " + this.numeroDiPagine + " ";
            return a;
        }
        public string readingTime()
        {
            if(this.numeroDiPagine < 100)
            {
                return "1h";
            }else if (this.numeroDiPagine >=  100 && this.numeroDiPagine < 200)
            {
                return "2h";
            }
            else
            {
                return "più di 2h";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica
{
    class Biblioteca
    {
        string nome, indirizzo, orarioLavorativo;
        public List<Libro> elencoLibri;
        public Biblioteca(string nome, string indirizzo, string orarioLavorativo)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioLavorativo = orarioLavorativo;
            elencoLibri = new List<Libro>();
        }
        public bool aggiungiLibro(Libro libroDaAggiungere)
        {
            try
            {
                elencoLibri.Add(libroDaAggiungere);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string cercaLibro(string titolo)
        {
            foreach(Libro l in elencoLibri)
            {
                string tit = l.getTitolo();
                if(tit == titolo)
                {
                    return l.toString();
                }
            }
            return "il libro non è presente nell'elenco";
        }
        public string cercaLibriDiAutore(string autore)
        {
            string elenco = "Elenco libri dell'autore " + autore + ":" + "\n";
            foreach (Libro l in elencoLibri)
            {
                string aut = l.getAutore();
                if (aut == autore)
                {
                    elenco += l.getTitolo() + "\n";
                }
            }
            return elenco;
        }
        public int getNumLibri()
        {
            return elencoLibri.Count();
        }
    }
}

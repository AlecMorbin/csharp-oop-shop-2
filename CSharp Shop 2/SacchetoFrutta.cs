using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_2
{
    internal class SacchetoFrutta : Prodotto
    {
        //Attributi
        private static int volume = 5;
        private List<string> pezzi = new List<string>();
        //Costruttore
        public SacchetoFrutta(string nome, string descrizione, float prezzo, float iva) : base(nome, descrizione, prezzo, iva)
        {
        }
        //Metodi di accesso
        public int getVolume()
        {
            return volume;
        }
        public string getPezzi()
        {
            string pezzi = "";
            foreach (string pezzo in this.pezzi)
            {
                pezzi += pezzo + "\n";
            }
            return pezzi;
        }
       

        //Metodi utili
        public void inserisciFrutta(string frutto)
        {
            if(pezzi.Count() < 5)
                pezzi.Add(frutto);
        }

        public void rimuoviFrutto(string frutto)
        {
            if (pezzi.Contains(frutto))
                pezzi.Remove(frutto);
            else
                Console.WriteLine("\nIl frutto che vuoi rimuovere non c'è");
        }
    }
}

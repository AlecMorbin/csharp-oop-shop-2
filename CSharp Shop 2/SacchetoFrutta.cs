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
        private string[] pezzi = new string[volume];
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
        public void setPezzi()
        {
            for (int i = 0; i < this.pezzi.Length; i++)
                pezzi[i] = "vuoto";
        }

        //Metodi utili
        public void inserisciFrutta(string frutto)
        {
            for (int i = 0; i < pezzi.Length; i++)
            {
                if (!(pezzi[i]=="vuoto"))
                    pezzi[i] = frutto;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_2
{
    internal class Aqcua : Prodotto
    {
        //Attributi
        private string sorgente;
        private int ph;
        private float quantity;

        //Costruttore
        public Aqcua(string nome, string descrizione, float prezzo, float iva, float quantity, string sorgente, int ph) : base(nome, descrizione, prezzo, iva)
        {
            this.quantity = quantity;
            this.sorgente = sorgente;
            this.ph = ph;
        }

        //Metodi di accesso
        public string getSorgente()
        {
            return sorgente;
        }
        public void setSorgente(string source)
        {
            this.sorgente = source;
        }
        public  int getPh()
        {
            return ph;
        }
        public void setPh(int ph)
        {
            this.ph = ph;
        }
        public float getQuantity()
        {
            return quantity;
        }
        public void setQuantity(float quantity)
        {
            this.quantity = quantity;
        }

        //Metodi utili
        public void bevi(float amount)
        {
            if (quantity >= amount )
                quantity -= amount;
        }
        public void riempi(float amount)
        {
            if(amount <= quantity)
                quantity += amount;
        }
        public void svuota()
        {
            quantity = 0;
        }
        public string ToString()
        {
            return base.ToString() + "\nSorgente: "+sorgente+"\nQuantità: "+quantity+"\nPH: "+ph;
        }
    }
}

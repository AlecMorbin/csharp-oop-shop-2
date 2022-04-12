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
        private readonly string sorgente = "Monte Cervino";
        private readonly float ph = 1.2f;
        private float quantity;

        //Costruttore
        public Aqcua(string nome, string descrizione, float prezzo, float iva, float quantity) : base(nome, descrizione, prezzo, iva)
        {
            setQuantity( quantity);
        }

        //Metodi di accesso
        public string getSorgente()
        {
            return sorgente;
        }

        public float getPh()
        {
            return ph;
        }

        public float getQuantity()
        {
            return quantity;
        }
        public void setQuantity(float quantity)
        {
            if (quantity > 1.5)
                this.quantity = 1.5f;
            else
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
        public override string ToString()
        {
            return base.ToString() + "Sorgente: "+sorgente+"\nQuantità: "+quantity+"\nPH: "+ph;
        }
    }
}

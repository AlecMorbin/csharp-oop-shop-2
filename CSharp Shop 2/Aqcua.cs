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
            if (quantity >= amount)
                quantity -= amount;
            else
                Console.WriteLine("Non c'è abbastanza acqua per te");
        }
        public void riempi(float amount)
        {
            if(amount <= 1.5)
            {
                quantity += amount;
                Console.WriteLine("La bottiglia è stata riempita della quantità desiderata");
            }
            else
                Console.WriteLine("Hai usato troppa acqua e sei andato oltre il limite\nLa bottiglia non può contenere cosi tanta acqua");
        }
        public void svuota()
        {
            quantity = 0;
            Console.WriteLine("La bottiglia è stata svuotata");
        }
        public override string ToString()
        {
            return base.ToString() + "Sorgente: "+sorgente+"\nQuantità: "+quantity+"\nPH: "+ph;
        }
    }
}

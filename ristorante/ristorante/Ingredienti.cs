using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Ingredienti
    {
        private string nomeIngr
        {
            get
            {
                return nomeIngr;
            }
            set
            {
                this.nomeIngr = value;
            }
        }

        private string descrizione
        {
            get
            {
                return descrizione;
            }
            set
            {
                this.descrizione = value;
            }
        }

        private string allergeni    //o prenderlo da un enum/tabella?
        {
            get
            {
                return allergeni;
            }
            set
            {
                this.allergeni = value;
            }
        }

        private bool esaurito
        {
            get
            {
                return esaurito;
            }
            set
            {
                this.esaurito = value;
            }
        }

        public Ingredienti(string nomeIngr, string descrizione)
        {
            this.nomeIngr = nomeIngr;
            this.descrizione = descrizione;
            this.esaurito = false;
        }

        public Ingredienti(string nomeIngr, string descrizione, string allergeni)
        {
            this.nomeIngr = nomeIngr;
            this.descrizione = descrizione;
            this.allergeni = allergeni;
            this.esaurito = false;
        }

        public void dispTerm()
        {
            if (this.esaurito)
                this.esaurito = false;
            else this.esaurito = true;

        }
    }
}

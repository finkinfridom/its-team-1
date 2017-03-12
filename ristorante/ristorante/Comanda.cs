using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Comanda
    {
        private int numComanda
        {
            get
            {
                return numComanda;
            }
            set
            {
                this.numComanda = value;
            }
        }

        private DateTime giornoOra
        {
            get
            {
                return giornoOra;
            }
            set
            {
                this.giornoOra = value;
            }
        }

        private Servizio codServizio
        {
            get
            {
                return codServizio;
            }
            set
            {
                this.codServizio = value;
            }
        }

        public Comanda()
        { }

        public Comanda(int numComanda, Servizio codServizio)
        {
            this.numComanda = numComanda;    //come lo autoincremento???
            this.giornoOra=DateTime.Now;
            this.codServizio = codServizio;
        }
    }
}

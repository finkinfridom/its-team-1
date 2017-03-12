using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Tavolo
    {
        private int numTavolo
        {
            get
            {
                return numTavolo;
            }
            set
            {
                this.numTavolo = value;
            }
        }

        private bool libero
        {
            get
            {
                return libero;
            }
            set
            {
                this.libero = value;
            }
        }

        public Tavolo()
        { }

        public Tavolo(int numTavolo)
        {
            this.numTavolo = numTavolo;
            this.libero = true;
        }

        public void cambiaStato()
        {
            if (this.libero)
                this.libero = false;
            else this.libero = true;
        }
    }
}

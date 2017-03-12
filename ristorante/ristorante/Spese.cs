using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Spese
    {
        private int codSpesa
        {
            get
            {
                return codSpesa;
            }
            set
            {
                this.codSpesa = value;
            }
        }

        private string nomeSpesa
        {
            get
            {
                return nomeSpesa;
            }
            set
            {
                this.nomeSpesa = value;
            }
        }

        private bool moltiplicatore
        {
            get
            {
                return moltiplicatore;
            }
            set
            {
                this.moltiplicatore = value;
            }
        }

        public Spese()
        { }

        public Spese(int codSpesa, string nomeSpesa)
        {
            this.codSpesa = codSpesa;
            this.nomeSpesa = nomeSpesa;
            this.moltiplicatore = false;
        }

        public Spese(int codSpesa, string nomeSpesa, bool moltiplicatore)
        {
            this.codSpesa = codSpesa;
            this.nomeSpesa = nomeSpesa;
            this.moltiplicatore = moltiplicatore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{

    public class Servizio
    {
        private DateTime inizio
        {
            get
            {
                return inizio;
            }
            set
            {
                inizio = DateTime.Now;
            }
        }

        private int numPersone
        {
            get
            {
                return numPersone;
            }
            set
            {
                numPersone = value;
            }
        }

        private DateTime oraFine
        {
            get
            {
                return oraFine;
            }
            set
            {
                this.oraFine = value;
            }
        }

        private Servizio numServizio
        {
            get
            {
                return numServizio;
            }
            set
            {
                this.numServizio = value;
            }
        }

        private Tavolo numTavolo
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

        private Clienti codCliente
        {
            get
            {
                return codCliente;
            }
            set
            {
                this.codCliente = value;
            }
        }
        private Prenotazione codPrenotazione { get; set; }

        private float totale
        {
            get
            {
                return totale;
            }
            set
            {
                this.totale = value;
            }
        }

        public Servizio()
        {
        }

        public Servizio(int numPersone, Tavolo numTavolo)
        {
            this.numPersone = numPersone;
            this.numTavolo = numTavolo;
            this.inizio = DateTime.Now;
            this.totale = 0;
        }

        public Servizio(int numPersone, Tavolo numTavolo, Clienti codCliente)
        {
            this.numPersone = numPersone;
            this.numTavolo = numTavolo;
            this.inizio = DateTime.Now;
            this.codCliente = codCliente;
            this.totale = 0;

            numTavolo.cambiaStato();
        }

        public Servizio(int numPersone, Tavolo numTavolo, Prenotazione numPrenotazione)
        {
            this.numPersone = numPersone;
            this.numTavolo = numTavolo;
            this.inizio = DateTime.Now;
            this.totale = 0;
            //this.codCliente=  //prendere codCliente da prenotazione
            this.codPrenotazione = codPrenotazione;

            numTavolo.cambiaStato();
        }

        public void chiudiServizio()
        {
            this.numTavolo.cambiaStato();
        }

    }
}

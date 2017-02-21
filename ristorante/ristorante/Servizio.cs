using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{

public class Servizio
    {
        public DateTime giorno_ora { get; set; }
        public DateTime ora_fine { get; set; }
        public int num_persone { get; set; }
        public Servizio num_servizio { get; set; }
        public Tavolo num_tavolo { get; set; }
        public Clienti cod_cliente { get; set; }
        public float totale { get; set; }

        public Servizio()
        {
            this.giorno_ora = DateTime.Now;
            this.totale = 0;
        }

    }
}

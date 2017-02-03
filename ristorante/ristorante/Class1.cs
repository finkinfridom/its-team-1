using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    class Servizio
    {
        DateTime giorno_ora;
        time ora_fine;
        int num_persone;
        float totale;
        int num_servizio;
        int num_tavolo;

        public Servizio()
        {
            DateTime giorno_ora = DateTime.Now;
        }
    }
}

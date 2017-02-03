using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{

public class Servizio
    {
        DateTime giorno_ora;
        DateTime ora_fine;
        int num_persone;
        int num_servizio;
        int num_tavolo;
        int cod_cliente;
        float totaleAPagare()
        {
            float totale;
            
            //totale = select somma prodotti legati a servizio/comanda;
            return totale;
        }

        public Servizio()
        {
            DateTime giorno_ora = DateTime.Now;
        }
    }
}

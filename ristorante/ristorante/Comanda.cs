using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Comanda
    {
        public int num_comanda { get; set; }
        public DateTime giorno_ora { get; set; }
        public Servizio cod_servizio { get; set; }
    }
}

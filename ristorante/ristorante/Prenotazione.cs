using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Prenotazione
    {
        public int cod_prenotazione { get; set; }
        public DateTime gg_prenotazione { get; set; }
        public DateTime giorno { get; set; }
        public DateTime ora { get; set; }
        public short int num_persone { get; set; }
        public int cod_cliente { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class ServSpese
    {
        public int cod_spesa { get; set; }
        public DateTime giorno_ora { get; set; }
        public Spese cod_spese { get; set; }
    }
}

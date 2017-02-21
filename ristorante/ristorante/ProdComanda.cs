using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class ProdComanda
    {
        public Comanda num_comanda { get; set; }
        public Prodotti num_prodotto { get; set; }
        public StatoPiatto stato { get; set; }
    }
}

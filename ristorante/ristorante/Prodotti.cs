using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Prodotti
    {
        public int cod_prodotto { get; set; }
        public String nome_prod { get; set; }
        public String descrizione { get; set; }
        public bool nel_menu { get; set; }
        public String nome_cat { get; set; }
        public short int giacenza { get; set; }
        public float prezzo { get; set; }
        public bool featured { get; set; }
    }
}

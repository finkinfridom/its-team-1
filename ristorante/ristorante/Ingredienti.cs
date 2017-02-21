using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Ingredienti
    {
        public string nome_ingr { get; set; }
        public string descrizione { get; set; }
        public string allergeni { get; set; } //o prenderlo da un enum/tabella?
        public bool esaurito { get; set; }
    }
}

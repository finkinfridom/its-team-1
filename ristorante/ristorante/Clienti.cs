using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Clienti
    {
        public int codCliente { get; set; }
        public oauthProvider provider { get; set; }
        public string oauthUid { get; set; }
        public string cognome { get; set; }
        public string nome { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public short punti { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public gender sesso { get; set; }


    }
}

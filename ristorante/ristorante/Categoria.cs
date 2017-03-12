using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Categoria
    {
        private string nomeCat;


        public string NomeCat
        {
            get
            {
                return nomeCat;
            }
            set
            {
                nomeCat = value;
            }
        }

        public Categoria()
        {
        }

        public Categoria(String nomeCat)
        {
            this.nomeCat=nomeCat;
        }
    }
}

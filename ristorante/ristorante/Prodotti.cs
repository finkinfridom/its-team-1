using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ristorante
{
    public class Prodotti
    {
        private int codProdotto
        {
            get
            {
                return codProdotto;
            }
            set
            {
                this.codProdotto = value;
            }
        }

        private string nomeProd
        {
            get
            {
                return nomeProd;
            }
            set
            {
                this.nomeProd = value;
            }
        }

        private string descrizione
        {
            get
            {
                return descrizione;
            }
            set
            {
                this.descrizione = value;
            }
        }

        private bool nelMenu
        {
            get
            {
                return nelMenu;
            }
            set
            {
                this.nelMenu = value;
            }
        }

        private Categoria nomeCat
        {
            get
            {
                return nomeCat;
            }
            set
            {
                this.nomeCat=value;
            }
        }

        private short giacenza
        {
            get
            {
                return giacenza;
            }
            set
            {
                this.giacenza = value;
            }
        }

        private float prezzo
        {
            get
            {
                return prezzo;
            }
            set
            {
                this.prezzo = value;
            }
        }

        private bool featured
        {
            get
            {
                return featured;
            }
            set
            {
                this.featured = value;
            }
        }

        public Prodotti()
        { }

        public Prodotti(int codProdotto, string nomeProd, string descrizione, bool nelMenu, Categoria nomeCat, short giacenza, float prezzo, bool featured)
        {
            this.codProdotto=codProdotto;
            this.nomeProd = nomeProd;
            this.descrizione = descrizione;
            this.nelMenu = nelMenu;
            this.nomeCat = nomeCat;
            this.giacenza = giacenza;
            this.prezzo = prezzo;
            this.featured = featured;
        }

        public void favoriti()
        {
            if (this.featured)
                this.featured = false;
            else this.featured = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ristorante
{
    public partial class Cassa : Form
    {
        public Cassa()
        {
            InitializeComponent();
        }

        private void creaServizio_Click(object sender, EventArgs e)
        {
            Servizio service = new Servizio();
        }

        private void Cassa_Load(object sender, EventArgs e)
        {

        }
    }
}

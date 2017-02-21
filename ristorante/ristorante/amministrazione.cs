using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ristorante
{
    public partial class amministrazione : Form
    {
        public amministrazione()
        {
            InitializeComponent();
        }

        private void amministrazione_Load(object sender, TabControlEventArgs e)
        {
            //contenuto tab Categorie
            elencoCat.DataSource = Program.GetAllCategory();

            //subTab del tab prodotti
            List<Categoria> result = new List<Categoria>();
            result = Program.GetAllCategory(); 
            foreach (Categoria value in result)
            {
            TabPage tp = new TabPage(value.ToString());      //crea schede in base ad estrazione da db
            subMenuProd.TabPages.Add(tp);
            }

            //contenuti subtabs
            Categoria obj = menu.SelectedTab as Categorie;
            if (obj != null)
                elencoCat.DataSource = Program.GetProductByCategory(obj.nome_cat);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

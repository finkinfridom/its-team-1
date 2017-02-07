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
    public partial class amministrazione : Form
    {
        public amministrazione()
        {
            InitializeComponent();
        }

        private void amministrazione_Load(object sender, TabControlEventArgs e)
        {
            String result = new Array();
            result[] = Program.GetAllCategory;
            foreach (result[] as tab)
            {
                TabPage tp = new TabPage(tab);      //crea schede in base ad estrazione da db
                menu.TabPages.Add(tp); 
            }
            
            Categoria obj = menu.SelectedTab as Categorie;
            if (obj != null)
                dataGridView1.DataSource = Program.GetProductByCategory(obj.nome_cat);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

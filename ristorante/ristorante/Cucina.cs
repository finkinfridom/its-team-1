using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ristorante
{
    public partial class Cucina : Form
    {
        public Cucina()
        {
            InitializeComponent();
        }

        private void GetData(string selectCommand, BindingSource a)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["db4free"].ConnectionString;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand, conn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                a.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void SetData(string selectCommand, BindingSource a)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["db4free"].ConnectionString;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand, conn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                GetData("SELECT num_servizio, num_tavolo, prod_comanda.num_comanda, nome_prod, note FROM prod_comanda JOIN prodotti ON prod_comanda.cod_prodotto=prodotti.cod_prodotto JOIN comanda ON prod_comanda.num_comanda=comanda.num_comanda JOIN servizio ON comanda.inizio_servizio=servizio.inizio WHERE stato='preparazione'", a);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Cucina_Load(object sender, EventArgs e)
        {
            GetData("SELECT id_prod_comanda, num_servizio, num_tavolo, prod_comanda.num_comanda, nome_prod, note FROM prod_comanda JOIN prodotti ON prod_comanda.cod_prodotto=prodotti.cod_prodotto JOIN comanda ON prod_comanda.num_comanda=comanda.num_comanda JOIN servizio ON comanda.inizio_servizio=servizio.inizio WHERE stato='preparazione'", bindingPiatti);
        }

        private void elencoPiatti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (elencoPiatti.CurrentRow.Cells[4].Selected)
            {
                SetData("UPDATE prod_comanda SET stato='consegnare' WHERE id_prod_comanda='"+ elencoPiatti.CurrentRow.Cells[4].Value.ToString() + "'", bindingPiatti);
            }
        }
    }
}

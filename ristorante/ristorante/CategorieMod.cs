using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ristorante
{
    public partial class CategorieMod : Form
    {
        DataTable tableCategorie = new DataTable();

        public CategorieMod(string id)
        {
            InitializeComponent();
            GetData(tableCategorie, "SELECT * FROM categoria WHERE nome_cat=" + id, bindingCategorie);
            DataRowView current = (DataRowView)bindingCategorie.Current;
            categoria.Text = current["nome_cat"].ToString();
            if (current["attivo"].ToString() == "1")
                attiva.Checked = true;
            else attiva.Checked = false;
        }

        private void GetData(DataTable table, string selectCommand, BindingSource a)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["db4free"].ConnectionString;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectCommand, conn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                //DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                a.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

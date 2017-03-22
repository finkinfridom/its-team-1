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
    public partial class ClientiMod : Form
    {
        DataTable tableClienti = new DataTable();

        public ClientiMod(string id)
        {
            InitializeComponent();
            GetData(tableClienti,"SELECT * FROM tavolo WHERE num_tavolo="+id,bindingClienti);
            DataRowView current = (DataRowView)bindingClienti.Current;
            codice.Text= current["cod_cliente"].ToString();
            provider.Text = current["oauth_provider"].ToString();
            uid.Text = current["oauth_uid"].ToString();
            nome.Text = current["nome"].ToString();
            cognome.Text = current["cognome"].ToString();
            mail.Text = current["mail"].ToString();
            telefono.Text = current["telefono"].ToString();
            indirizzo.Text = current["indirizzo"].ToString();
            punti.Text = current["punti"].ToString();
            nome.Text = current["nome"].ToString();
            sesso.SelectedItem = current["gender"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////ModData();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

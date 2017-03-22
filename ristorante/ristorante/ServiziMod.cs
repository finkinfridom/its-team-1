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
    public partial class ServiziMod : Form
    {
        DataTable tableServizi = new DataTable();
        DataTable tableClienti = new DataTable();
        DataTable tablePrenotazioni = new DataTable();

        public ServiziMod(string id)
        {
            InitializeComponent();
            GetData(tableClienti, "SELECT cod_cliente, CONCAT(cognome, ' ', nome) AS cliente FROM cliente ORDER BY cognome, nome", bindingClienti);
            GetData(tablePrenotazioni, "SELECT cod_prenotazione, CONCAT(cognome, ' ', nome, ' - ', giorno, ':', ora) AS prenotazione FROM prenotazione JOIN cliente ON prenotazione.cod_cliente=cliente.cod_cliente ORDER BY cognome, nome, cod_prenotazione, giorno, ora", bindingPrenotazioni);
            GetData(tableServizi, "SELECT * FROM servizio WHERE inizio=" +  id, bindingServizi);
            DataRowView current = (DataRowView)bindingServizi.Current;
            inizio.Text = current["inizio"].ToString();
            numServizio.Text = current["num_servizio"].ToString();
            fine.Text = current["fine"].ToString();
            numPersone.Text = current["num_persone"].ToString();
            totale.Text = current["totale"].ToString();
            numTavolo.Text = current["num_tavolo"].ToString();
            prenotazione.ValueMember = "cod_cliente";
            prenotazione.DisplayMember = "cliente";
            cliente.SelectedItem = current["cod_cliente"].ToString();
            prenotazione.ValueMember ="cod_prenotazione";
            prenotazione.DisplayMember = "prenotazione";
            prenotazione.SelectedItem = current["cod_prenotazione"].ToString();

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

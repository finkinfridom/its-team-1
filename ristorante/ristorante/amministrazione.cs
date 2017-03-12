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
using System.IO;

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

        }

        private void elencoCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void amministrazione_Load(object sender, EventArgs e)
        {
            GetData("SELECT * FROM categoria", bindingCategorie);
            GetData("SELECT nome_prod, descrizione, nel_menu, giacenza, prezzo, featured FROM prodotti WHERE nome_cat=" + elencoCatProd.CurrentRow.Cells[0].Selected, bindingProdotti);
            GetData("SELECT * FROM cliente", bindingClienti);
            GetData("SELECT num_tavolo, max_posti FROM tavolo", bindingTavoli);
            GetData("SELECT inizio, num_servizio, fine, servizio.num_persone, totale, servizio.num_tavolo, CONCAT(cognome, ' ', nome) AS cliente, CONCAT(servizio.cod_prenotazione, ' del ', gg_prenotazione) AS prenotazione FROM servizio JOIN cliente ON servizio.cod_cliente=cliente.cod_cliente JOIN prenotazione ON servizio.cod_prenotazione=prenotazione.cod_prenotazione", bindingServizi);
            GetData("SELECT * FROM comanda", bindingComande);
            GetData("SELECT cod_prenotazione, gg_prenotazione, giorno, ora, num_persone, CONCAT(cognome, ' ', nome) AS cliente, num_tavolo FROM prenotazione JOIN cliente ON prenotazione.cod_cliente=cliente.cod_cliente", bindingPrenotazioni);
        }

        private void GetData(string selectCommand, BindingSource a)
        {
            try
            {
                string conn= ConfigurationManager.ConnectionStrings["db4free"].ConnectionString;
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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void elencoCatProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            elencoProd.DataSource = bindingProdotti;
            GetData("SELECT nome_prod, descrizione, nel_menu, giacenza, prezzo, featured FROM prodotti WHERE nome_cat=" + elencoCatProd.CurrentRow.Cells[0].Selected.ToString(), bindingProdotti);

        }

        private void elencoProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
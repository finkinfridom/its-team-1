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
    public partial class Amministrazione : Form
    {
        DataTable tablePrenotazioni = new DataTable();
        DataTable tableServizi = new DataTable();
        DataTable tableClienti = new DataTable();
        DataTable tableCategoria = new DataTable();
        DataTable tableProdotti = new DataTable();
        DataTable tableTavoli = new DataTable();
        DataTable tableComande = new DataTable();

        public Amministrazione()
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
            GetData(tableCategoria, "SELECT * FROM categoria", bindingCategorie);
            elencoCatProd.Rows[0].Selected = true;
            GetData(tableProdotti, "SELECT nome_prod, cod_prodotto, descrizione, nel_menu, giacenza, prezzo, featured, nome_cat FROM prodotti", bindingProdotti);
            bindingProdotti.Filter = "nome_cat = '" + elencoCatProd.CurrentRow.Cells[0].Value.ToString() + "'";
            GetData(tableClienti, "SELECT * FROM cliente", bindingClienti);
            GetData(tableTavoli, "SELECT num_tavolo, max_posti FROM tavolo", bindingTavoli);
            GetData(tableServizi, "SELECT inizio, num_servizio, fine, servizio.num_persone, totale, servizio.num_tavolo, CONCAT(cognome, ' ', nome) AS cliente, CONCAT(servizio.cod_prenotazione, ' del ', gg_prenotazione) AS prenotazione FROM servizio JOIN cliente ON servizio.cod_cliente=cliente.cod_cliente JOIN prenotazione ON servizio.cod_prenotazione=prenotazione.cod_prenotazione", bindingServizi);
            elencoServCom.Rows[0].Selected = true;
            GetData(tableComande, "SELECT inizio_servizio, prod_comanda.num_comanda, GROUP_CONCAT(prodotti.nome_prod) AS prod FROM prod_comanda JOIN prodotti ON prod_comanda.cod_prodotto=prodotti.cod_prodotto JOIN comanda ON comanda.num_comanda=prod_comanda.num_comanda GROUP BY prod_comanda.num_comanda", bindingComande);
            GetData(tablePrenotazioni, "SELECT cod_prenotazione, gg_prenotazione, giorno, ora, num_persone, CONCAT(cognome, ' ', nome) AS cliente, num_tavolo FROM prenotazione JOIN cliente ON prenotazione.cod_cliente=cliente.cod_cliente", bindingPrenotazioni);
        }

        private void GetData(DataTable table, string selectCommand, BindingSource a)
        {
            try
            {
                string conn= ConfigurationManager.ConnectionStrings["db4free"].ConnectionString;
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

        private void ModData(DataTable table, string queryCommand, BindingSource a)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["db4free"].ConnectionString;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(queryCommand, conn);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                //DataTable table = new DataTable();
                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                //dataAdapter.Fill(table);
                DataTable changes = table.GetChanges();
                dataAdapter.Update(table);
                table.AcceptChanges();
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
            bindingProdotti.RemoveFilter();
            bindingProdotti.Filter = "nome_cat = '" + elencoCatProd.CurrentRow.Cells[0].Value.ToString() + "'";
        }

        private void elencoProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrenotazioni.Checked)
            {
                bindingPrenotazioni.Filter = "giorno = '" + datePrenotazioni.Value.ToShortDateString() + "'";
            }
            else
            {
                bindingPrenotazioni.RemoveFilter();
            }
        }

        private void elencoServCom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingComande.RemoveFilter();
            bindingComande.Filter = "inizio_servizio LIKE '" + elencoServCom.CurrentRow.Cells[0].Value.ToString() + "%'";
        }

        private void datePrenotazioni_ValueChanged(object sender, EventArgs e)
        {
            if(checkPrenotazioni.Checked)
            {
            bindingPrenotazioni.RemoveFilter();
            bindingPrenotazioni.Filter = "giorno LIKE '" + datePrenotazioni.Value.ToShortDateString() + "%'";
            }
        }

        private void dateServizi_ValueChanged(object sender, EventArgs e)
        {
            if(checkServizi.Checked)
            {
            bindingServizi.RemoveFilter();
            bindingServizi.Filter = "inizio_servizio LIKE '" + dateServizi.Value.ToShortDateString() + "%'";
            }
        }

        private void checkServizi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkServizi.Checked)
            {
                 bindingServizi.Filter = "inizio LIKE '" + dateServizi.Value.ToShortDateString()+"%'";
            }
            else
            {
                bindingServizi.RemoveFilter();
            }
        }

        private void dateComande_ValueChanged(object sender, EventArgs e)
        {
            bindingServizi.RemoveFilter();
            bindingServizi.Filter = "inizio_servizio LIKE '" + dateServizi.Value.ToShortDateString() + "'";
        }

        private void checkComande_CheckedChanged(object sender, EventArgs e)
        {
            if (checkComande.Checked)
            {
                bindingServizi.Filter = "inizio_servizio LIKE '" + dateServizi.Value.ToShortDateString() + "'";
            }
            else
            {
                bindingServizi.RemoveFilter();
            }
        }

        private void btnCancPrenotazione_Click(object sender, EventArgs e)
        {

        }

        private void prodDel_Click(object sender, EventArgs e)
        {
            //SetData(tableProdotti, "DELETE FROM prodotti WHERE cod_prodotto = '" + elencoProd.CurrentRow.Cells[2].Value.ToString() + "'", bindingProdotti);
        }

        private void btnCancClienti_Click(object sender, EventArgs e)
        {
            //SetData(tableClienti, "DELETE FROM cliente WHERE cod_cliente = '" + elencoClienti.CurrentRow.Cells[0].Value.ToString() + "'", bindingClienti);
        }

        private void btnModClienti_Click(object sender, EventArgs e)
        {
            ClientiMod clientiMod = new ClientiMod(elencoClienti.CurrentRow.Cells[0].Value.ToString());
            clientiMod.Show();
        }

        private void elencoClienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModTavoli_Click(object sender, EventArgs e)
        {
            TavoliMod tavoliMod = new TavoliMod(elencoTavoli.CurrentRow.Cells[0].Value.ToString());
            tavoliMod.Show();
        }

        private void btnModoServizi_Click(object sender, EventArgs e)
        {
            ServiziMod serviziMod = new ServiziMod(elencoServizi.CurrentRow.Cells[1].Value.ToString());
            serviziMod.Show();
        }

        private void Categorie_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategorieMod categorieMod = new CategorieMod(elencoCategorie.CurrentRow.Cells[0].Value.ToString());
            categorieMod.Show();
        }
    }
}
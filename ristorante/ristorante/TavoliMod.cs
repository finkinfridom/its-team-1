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
    public partial class TavoliMod : Form
    {
        DataTable tableTavoli = new DataTable();

        public TavoliMod(string id)
        {
            InitializeComponent();
            GetData(tableTavoli, "SELECT * FROM tavolo WHERE num_tavolo=" + id, bindingTavoli);
            DataRowView current = (DataRowView)bindingTavoli.Current;
            numTavolo.Text = current["num_tavolo"].ToString();
            maxPosti.Text = current["max_posti"].ToString();
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

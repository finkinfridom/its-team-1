﻿using MySql.Data.MySqlClient;
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
    public partial class Cassa : Form
    {
        public Cassa()
        {
            InitializeComponent();
        }

        private void creaServizio_Click(object sender, EventArgs e)
        {
            
        }

        private void Cassa_Load(object sender, EventArgs e)
        {
            GetData("SELECT ora, cognome, num_persone, num_tavolo FROM prenotazione JOIN cliente ON prenotazione.cod_cliente=cliente.cod_cliente WHERE giorno=CURDATE() AND cod_prenotazione NOT IN (SELECT cod_prenotazione FROM servizio WHERE DATE(inizio) LIKE CURDATE()) ORDER BY ora", bindingPrenotazioni);
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
    }
}

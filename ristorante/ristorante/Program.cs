using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;
using System.Configuration;

namespace ristorante
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //avvio forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new amministrazione());
        }

        public static List<Categoria> GetAllCategory()
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ristorante_db4free"].ConnectionString))
            {
                /*try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }*/
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn.Query<Categoria>("SELECT nome_cat FROM categoria ORDER BY nome_cat").ToList();
            }
        }

        public static List<Prodotti> GetProductByCategory(String categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ristorante_db4free"].ConnectionString))
            {
                /*try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }*/
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn.Query<Prodotti>("SELECT * FROM rodotti WHERE " + categoria + " ORDER BY nome_cat").ToList();
            }
        }
    }
}

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
    public partial class LogIn : Form
    {
        string codamm="11111";
        string codcassa="66666";

        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (codice.Text.Length == 5)
            {
                if (codice.Text != codamm && codice.Text != codcassa)
                {
                    erroreLbl.Show();
                }
                else
                {
                    if (codice.Text == codamm)
                    {
                        Amministrazione ammForm = new Amministrazione();
                        ammForm.Show();
                    }
                    else if (codice.Text != codcassa)
                    {
                        Cassa cassaForm = new Cassa();
                        cassaForm.Show();
                    }
                    this.Hide();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pressNum(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pressNum(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pressNum(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pressNum(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pressNum(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pressNum(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pressNum(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pressNum(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pressNum(btn9.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pressNum(btn0.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (codice.Text.Length > 0)
            {
                codice.Text = codice.Text.Substring(0, codice.Text.Length - 1);
            }
            if (erroreLbl.Visible)
                erroreLbl.Hide();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            codice.Text = "";
            if (erroreLbl.Visible)
                erroreLbl.Hide();
        }

        public void pressNum(string numero)
        {
            if (codice.Text.Length < codice.MaxLength)
            {
                codice.Text += numero;
            }
        }

        private void erroreLbl_Click(object sender, EventArgs e)
        {

        }

        private void verifica_Click(object sender, EventArgs e)
        {
            
        }
    }
}

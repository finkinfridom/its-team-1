namespace ristorante
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.categorie = new System.Windows.Forms.TabPage();
            this.prodotti = new System.Windows.Forms.TabPage();
            this.clienti = new System.Windows.Forms.TabPage();
            this.ordini = new System.Windows.Forms.TabPage();
            this.tavoli = new System.Windows.Forms.TabPage();
            this.comande = new System.Windows.Forms.TabPage();
            this.servizi = new System.Windows.Forms.TabPage();
            this.prenotazioni = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.categorie);
            this.tabControl1.Controls.Add(this.prodotti);
            this.tabControl1.Controls.Add(this.clienti);
            this.tabControl1.Controls.Add(this.ordini);
            this.tabControl1.Controls.Add(this.tavoli);
            this.tabControl1.Controls.Add(this.servizi);
            this.tabControl1.Controls.Add(this.comande);
            this.tabControl1.Controls.Add(this.prenotazioni);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 321);
            this.tabControl1.TabIndex = 3;
            // 
            // categorie
            // 
            this.categorie.Location = new System.Drawing.Point(4, 22);
            this.categorie.Name = "categorie";
            this.categorie.Padding = new System.Windows.Forms.Padding(3);
            this.categorie.Size = new System.Drawing.Size(919, 295);
            this.categorie.TabIndex = 0;
            this.categorie.Text = "Categorie";
            this.categorie.UseVisualStyleBackColor = true;
            // 
            // prodotti
            // 
            this.prodotti.Location = new System.Drawing.Point(4, 22);
            this.prodotti.Name = "prodotti";
            this.prodotti.Padding = new System.Windows.Forms.Padding(3);
            this.prodotti.Size = new System.Drawing.Size(919, 295);
            this.prodotti.TabIndex = 1;
            this.prodotti.Text = "Prodotti";
            this.prodotti.UseVisualStyleBackColor = true;
            // 
            // clienti
            // 
            this.clienti.Location = new System.Drawing.Point(4, 22);
            this.clienti.Name = "clienti";
            this.clienti.Size = new System.Drawing.Size(919, 295);
            this.clienti.TabIndex = 2;
            this.clienti.Text = "Clienti";
            this.clienti.UseVisualStyleBackColor = true;
            // 
            // ordini
            // 
            this.ordini.Location = new System.Drawing.Point(4, 22);
            this.ordini.Name = "ordini";
            this.ordini.Size = new System.Drawing.Size(919, 295);
            this.ordini.TabIndex = 3;
            this.ordini.Text = "Ordini";
            this.ordini.UseVisualStyleBackColor = true;
            // 
            // tavoli
            // 
            this.tavoli.Location = new System.Drawing.Point(4, 22);
            this.tavoli.Name = "tavoli";
            this.tavoli.Size = new System.Drawing.Size(919, 295);
            this.tavoli.TabIndex = 4;
            this.tavoli.Text = "Tavoli";
            this.tavoli.UseVisualStyleBackColor = true;
            // 
            // comande
            // 
            this.comande.Location = new System.Drawing.Point(4, 22);
            this.comande.Name = "comande";
            this.comande.Size = new System.Drawing.Size(919, 295);
            this.comande.TabIndex = 5;
            this.comande.Text = "Comande";
            this.comande.UseVisualStyleBackColor = true;
            // 
            // servizi
            // 
            this.servizi.Location = new System.Drawing.Point(4, 22);
            this.servizi.Name = "servizi";
            this.servizi.Size = new System.Drawing.Size(919, 295);
            this.servizi.TabIndex = 6;
            this.servizi.Text = "Servizi";
            this.servizi.UseVisualStyleBackColor = true;
            // 
            // prenotazioni
            // 
            this.prenotazioni.Location = new System.Drawing.Point(4, 22);
            this.prenotazioni.Name = "prenotazioni";
            this.prenotazioni.Size = new System.Drawing.Size(919, 295);
            this.prenotazioni.TabIndex = 7;
            this.prenotazioni.Text = "Prenotazioni";
            this.prenotazioni.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 321);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Amministratione / Gestione contenuti";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage categorie;
        private System.Windows.Forms.TabPage prodotti;
        private System.Windows.Forms.TabPage clienti;
        private System.Windows.Forms.TabPage ordini;
        private System.Windows.Forms.TabPage tavoli;
        private System.Windows.Forms.TabPage servizi;
        private System.Windows.Forms.TabPage comande;
        private System.Windows.Forms.TabPage prenotazioni;
    }
}


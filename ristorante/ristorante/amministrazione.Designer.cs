namespace ristorante
{
    partial class amministrazione
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
            this.prenotazioni = new System.Windows.Forms.TabPage();
            this.comande = new System.Windows.Forms.TabPage();
            this.servizi = new System.Windows.Forms.TabPage();
            this.tavoli = new System.Windows.Forms.TabPage();
            this.clienti = new System.Windows.Forms.TabPage();
            this.prodotti = new System.Windows.Forms.TabPage();
            this.submenu1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.categorie = new System.Windows.Forms.TabPage();
            this.menu = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodotti.SuspendLayout();
            this.submenu1.SuspendLayout();
            this.categorie.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // tavoli
            // 
            this.tavoli.Location = new System.Drawing.Point(4, 22);
            this.tavoli.Name = "tavoli";
            this.tavoli.Size = new System.Drawing.Size(919, 295);
            this.tavoli.TabIndex = 4;
            this.tavoli.Text = "Tavoli";
            this.tavoli.UseVisualStyleBackColor = true;
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
            // prodotti
            // 
            this.prodotti.Controls.Add(this.submenu1);
            this.prodotti.Location = new System.Drawing.Point(4, 22);
            this.prodotti.Name = "prodotti";
            this.prodotti.Padding = new System.Windows.Forms.Padding(3);
            this.prodotti.Size = new System.Drawing.Size(919, 295);
            this.prodotti.TabIndex = 1;
            this.prodotti.Text = "Prodotti";
            this.prodotti.UseVisualStyleBackColor = true;
            // 
            // submenu1
            // 
            this.submenu1.Controls.Add(this.tabPage1);
            this.submenu1.Controls.Add(this.tabPage2);
            this.submenu1.Location = new System.Drawing.Point(9, 6);
            this.submenu1.Name = "submenu1";
            this.submenu1.SelectedIndex = 0;
            this.submenu1.Size = new System.Drawing.Size(902, 281);
            this.submenu1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // categorie
            // 
            this.categorie.Controls.Add(this.dataGridView1);
            this.categorie.Location = new System.Drawing.Point(4, 22);
            this.categorie.Name = "categorie";
            this.categorie.Padding = new System.Windows.Forms.Padding(3);
            this.categorie.Size = new System.Drawing.Size(919, 295);
            this.categorie.TabIndex = 0;
            this.categorie.Text = "Categorie";
            this.categorie.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.categorie);
            this.menu.Controls.Add(this.prodotti);
            this.menu.Controls.Add(this.clienti);
            this.menu.Controls.Add(this.tavoli);
            this.menu.Controls.Add(this.servizi);
            this.menu.Controls.Add(this.comande);
            this.menu.Controls.Add(this.prenotazioni);
            this.menu.Location = new System.Drawing.Point(-1, 0);
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(927, 321);
            this.menu.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // amministrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 321);
            this.Controls.Add(this.menu);
            this.Name = "amministrazione";
            this.Text = "Amministratione / Gestione contenuti";
            this.prodotti.ResumeLayout(false);
            this.submenu1.ResumeLayout(false);
            this.categorie.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage prenotazioni;
        private System.Windows.Forms.TabPage comande;
        private System.Windows.Forms.TabPage servizi;
        private System.Windows.Forms.TabPage tavoli;
        private System.Windows.Forms.TabPage clienti;
        private System.Windows.Forms.TabPage prodotti;
        private System.Windows.Forms.TabControl submenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage categorie;
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


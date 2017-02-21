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
            this.components = new System.ComponentModel.Container();
            this.prenotazioni = new System.Windows.Forms.TabPage();
            this.comande = new System.Windows.Forms.TabPage();
            this.servizi = new System.Windows.Forms.TabPage();
            this.tavoli = new System.Windows.Forms.TabPage();
            this.clienti = new System.Windows.Forms.TabPage();
            this.prodotti = new System.Windows.Forms.TabPage();
            this.prodDel = new System.Windows.Forms.Button();
            this.prodNew = new System.Windows.Forms.Button();
            this.prodMod = new System.Windows.Forms.Button();
            this.subMenuProd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprodottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nelmenuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomecatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giacenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.categorie = new System.Windows.Forms.TabPage();
            this.elencoCat = new System.Windows.Forms.DataGridView();
            this.nomecatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.TabControl();
            this.categoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prodotti.SuspendLayout();
            this.subMenuProd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            this.categorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elencoCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).BeginInit();
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
            this.prodotti.Controls.Add(this.prodDel);
            this.prodotti.Controls.Add(this.prodNew);
            this.prodotti.Controls.Add(this.prodMod);
            this.prodotti.Controls.Add(this.subMenuProd);
            this.prodotti.Location = new System.Drawing.Point(4, 22);
            this.prodotti.Name = "prodotti";
            this.prodotti.Padding = new System.Windows.Forms.Padding(3);
            this.prodotti.Size = new System.Drawing.Size(919, 295);
            this.prodotti.TabIndex = 1;
            this.prodotti.Text = "Prodotti";
            this.prodotti.UseVisualStyleBackColor = true;
            // 
            // prodDel
            // 
            this.prodDel.Location = new System.Drawing.Point(748, 86);
            this.prodDel.Name = "prodDel";
            this.prodDel.Size = new System.Drawing.Size(75, 23);
            this.prodDel.TabIndex = 3;
            this.prodDel.Text = "Cancella";
            this.prodDel.UseVisualStyleBackColor = true;
            // 
            // prodNew
            // 
            this.prodNew.Location = new System.Drawing.Point(748, 28);
            this.prodNew.Name = "prodNew";
            this.prodNew.Size = new System.Drawing.Size(75, 23);
            this.prodNew.TabIndex = 2;
            this.prodNew.Text = "Nuovo";
            this.prodNew.UseVisualStyleBackColor = true;
            // 
            // prodMod
            // 
            this.prodMod.Location = new System.Drawing.Point(748, 57);
            this.prodMod.Name = "prodMod";
            this.prodMod.Size = new System.Drawing.Size(75, 23);
            this.prodMod.TabIndex = 1;
            this.prodMod.Text = "Modifica";
            this.prodMod.UseVisualStyleBackColor = true;
            // 
            // subMenuProd
            // 
            this.subMenuProd.Controls.Add(this.tabPage1);
            this.subMenuProd.Controls.Add(this.tabPage2);
            this.subMenuProd.Location = new System.Drawing.Point(9, 6);
            this.subMenuProd.Name = "subMenuProd";
            this.subMenuProd.SelectedIndex = 0;
            this.subMenuProd.Size = new System.Drawing.Size(732, 281);
            this.subMenuProd.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprodottoDataGridViewTextBoxColumn,
            this.nomeprodDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.nelmenuDataGridViewCheckBoxColumn,
            this.nomecatDataGridViewTextBoxColumn1,
            this.giacenzaDataGridViewTextBoxColumn,
            this.prezzoDataGridViewTextBoxColumn,
            this.featuredDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.prodottiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // codprodottoDataGridViewTextBoxColumn
            // 
            this.codprodottoDataGridViewTextBoxColumn.DataPropertyName = "cod_prodotto";
            this.codprodottoDataGridViewTextBoxColumn.HeaderText = "cod_prodotto";
            this.codprodottoDataGridViewTextBoxColumn.Name = "codprodottoDataGridViewTextBoxColumn";
            // 
            // nomeprodDataGridViewTextBoxColumn
            // 
            this.nomeprodDataGridViewTextBoxColumn.DataPropertyName = "nome_prod";
            this.nomeprodDataGridViewTextBoxColumn.HeaderText = "nome_prod";
            this.nomeprodDataGridViewTextBoxColumn.Name = "nomeprodDataGridViewTextBoxColumn";
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            // 
            // nelmenuDataGridViewCheckBoxColumn
            // 
            this.nelmenuDataGridViewCheckBoxColumn.DataPropertyName = "nel_menu";
            this.nelmenuDataGridViewCheckBoxColumn.HeaderText = "nel_menu";
            this.nelmenuDataGridViewCheckBoxColumn.Name = "nelmenuDataGridViewCheckBoxColumn";
            // 
            // nomecatDataGridViewTextBoxColumn1
            // 
            this.nomecatDataGridViewTextBoxColumn1.DataPropertyName = "nome_cat";
            this.nomecatDataGridViewTextBoxColumn1.HeaderText = "nome_cat";
            this.nomecatDataGridViewTextBoxColumn1.Name = "nomecatDataGridViewTextBoxColumn1";
            // 
            // giacenzaDataGridViewTextBoxColumn
            // 
            this.giacenzaDataGridViewTextBoxColumn.DataPropertyName = "giacenza";
            this.giacenzaDataGridViewTextBoxColumn.HeaderText = "giacenza";
            this.giacenzaDataGridViewTextBoxColumn.Name = "giacenzaDataGridViewTextBoxColumn";
            // 
            // prezzoDataGridViewTextBoxColumn
            // 
            this.prezzoDataGridViewTextBoxColumn.DataPropertyName = "prezzo";
            this.prezzoDataGridViewTextBoxColumn.HeaderText = "prezzo";
            this.prezzoDataGridViewTextBoxColumn.Name = "prezzoDataGridViewTextBoxColumn";
            // 
            // featuredDataGridViewCheckBoxColumn
            // 
            this.featuredDataGridViewCheckBoxColumn.DataPropertyName = "featured";
            this.featuredDataGridViewCheckBoxColumn.HeaderText = "featured";
            this.featuredDataGridViewCheckBoxColumn.Name = "featuredDataGridViewCheckBoxColumn";
            // 
            // prodottiBindingSource
            // 
            this.prodottiBindingSource.DataSource = typeof(ristorante.Prodotti);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // categorie
            // 
            this.categorie.Controls.Add(this.elencoCat);
            this.categorie.Location = new System.Drawing.Point(4, 22);
            this.categorie.Name = "categorie";
            this.categorie.Padding = new System.Windows.Forms.Padding(3);
            this.categorie.Size = new System.Drawing.Size(919, 295);
            this.categorie.TabIndex = 0;
            this.categorie.Text = "Categorie";
            this.categorie.UseVisualStyleBackColor = true;
            // 
            // elencoCat
            // 
            this.elencoCat.AutoGenerateColumns = false;
            this.elencoCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elencoCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomecatDataGridViewTextBoxColumn});
            this.elencoCat.DataSource = this.categoriaBindingSource;
            this.elencoCat.Location = new System.Drawing.Point(0, 1);
            this.elencoCat.Name = "elencoCat";
            this.elencoCat.Size = new System.Drawing.Size(240, 150);
            this.elencoCat.TabIndex = 0;
            this.elencoCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomecatDataGridViewTextBoxColumn
            // 
            this.nomecatDataGridViewTextBoxColumn.DataPropertyName = "nome_cat";
            this.nomecatDataGridViewTextBoxColumn.HeaderText = "nome_cat";
            this.nomecatDataGridViewTextBoxColumn.Name = "nomecatDataGridViewTextBoxColumn";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(ristorante.Categoria);
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
            // categoriaBindingSource1
            // 
            this.categoriaBindingSource1.DataSource = typeof(ristorante.Categoria);
            // 
            // amministrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 321);
            this.Controls.Add(this.menu);
            this.Name = "amministrazione";
            this.Text = "Amministratione / Gestione contenuti";
            this.prodotti.ResumeLayout(false);
            this.subMenuProd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            this.categorie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elencoCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage prenotazioni;
        private System.Windows.Forms.TabPage comande;
        private System.Windows.Forms.TabPage servizi;
        private System.Windows.Forms.TabPage tavoli;
        private System.Windows.Forms.TabPage clienti;
        private System.Windows.Forms.TabPage prodotti;
        private System.Windows.Forms.TabControl subMenuProd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage categorie;
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.DataGridView elencoCat;
        private System.Windows.Forms.Button prodDel;
        private System.Windows.Forms.Button prodNew;
        private System.Windows.Forms.Button prodMod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nelmenuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giacenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn featuredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource1;
    }
}


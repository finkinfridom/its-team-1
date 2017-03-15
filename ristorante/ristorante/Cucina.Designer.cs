namespace ristorante
{
    partial class Cucina
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
            this.elencoPiatti = new System.Windows.Forms.DataGridView();
            this.bindingPiatti = new System.Windows.Forms.BindingSource(this.components);
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingIngredienti = new System.Windows.Forms.BindingSource(this.components);
            this.elencoIngredienti = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elencoPiatti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPiatti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingIngredienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elencoIngredienti)).BeginInit();
            this.SuspendLayout();
            // 
            // elencoPiatti
            // 
            this.elencoPiatti.AllowUserToAddRows = false;
            this.elencoPiatti.AllowUserToDeleteRows = false;
            this.elencoPiatti.AllowUserToOrderColumns = true;
            this.elencoPiatti.AllowUserToResizeColumns = false;
            this.elencoPiatti.AllowUserToResizeRows = false;
            this.elencoPiatti.AutoGenerateColumns = false;
            this.elencoPiatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elencoPiatti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.elencoPiatti.DataSource = this.bindingPiatti;
            this.elencoPiatti.EnableHeadersVisualStyles = false;
            this.elencoPiatti.Location = new System.Drawing.Point(0, 0);
            this.elencoPiatti.Name = "elencoPiatti";
            this.elencoPiatti.ReadOnly = true;
            this.elencoPiatti.RowHeadersVisible = false;
            this.elencoPiatti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elencoPiatti.Size = new System.Drawing.Size(508, 344);
            this.elencoPiatti.TabIndex = 0;
            this.elencoPiatti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elencoPiatti_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id_prod_comanda";
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "num_tavolo";
            this.Column1.HeaderText = "Tavolo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "num_comanda";
            this.Column2.HeaderText = "Comanda";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nome_prod";
            this.Column3.HeaderText = "Prodotto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "note";
            this.Column5.HeaderText = "Note";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stato";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "Da Consegnare";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // elencoIngredienti
            // 
            this.elencoIngredienti.AllowUserToAddRows = false;
            this.elencoIngredienti.AllowUserToDeleteRows = false;
            this.elencoIngredienti.AllowUserToOrderColumns = true;
            this.elencoIngredienti.AllowUserToResizeColumns = false;
            this.elencoIngredienti.AllowUserToResizeRows = false;
            this.elencoIngredienti.AutoGenerateColumns = false;
            this.elencoIngredienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elencoIngredienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.elencoIngredienti.DataSource = this.bindingIngredienti;
            this.elencoIngredienti.Location = new System.Drawing.Point(515, 0);
            this.elencoIngredienti.Name = "elencoIngredienti";
            this.elencoIngredienti.RowHeadersVisible = false;
            this.elencoIngredienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elencoIngredienti.Size = new System.Drawing.Size(248, 150);
            this.elencoIngredienti.TabIndex = 1;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ingrediente";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Disponibile";
            this.Column8.Name = "Column8";
            // 
            // Cucina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 344);
            this.Controls.Add(this.elencoIngredienti);
            this.Controls.Add(this.elencoPiatti);
            this.Name = "Cucina";
            this.Text = "Cucina";
            this.Load += new System.EventHandler(this.Cucina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elencoPiatti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPiatti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingIngredienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elencoIngredienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView elencoPiatti;
        private System.Windows.Forms.BindingSource bindingPiatti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.BindingSource bindingIngredienti;
        private System.Windows.Forms.DataGridView elencoIngredienti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
    }
}
namespace ristorante
{
    partial class Cassa
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
            this.servizi = new System.Windows.Forms.Button();
            this.bindingPrenotazioni = new System.Windows.Forms.BindingSource(this.components);
            this.prenotazioni = new System.Windows.Forms.Button();
            this.cucina = new System.Windows.Forms.Button();
            this.ricevute = new System.Windows.Forms.Button();
            this.elencoPrenotazioni = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trasformaPrenotazione = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPrenotazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elencoPrenotazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // servizi
            // 
            this.servizi.Location = new System.Drawing.Point(12, 12);
            this.servizi.Name = "servizi";
            this.servizi.Size = new System.Drawing.Size(100, 100);
            this.servizi.TabIndex = 0;
            this.servizi.Text = "SERVIZI";
            this.servizi.UseVisualStyleBackColor = true;
            this.servizi.Click += new System.EventHandler(this.creaServizio_Click);
            // 
            // prenotazioni
            // 
            this.prenotazioni.Location = new System.Drawing.Point(118, 12);
            this.prenotazioni.Name = "prenotazioni";
            this.prenotazioni.Size = new System.Drawing.Size(100, 100);
            this.prenotazioni.TabIndex = 1;
            this.prenotazioni.Text = "PRENOTAZIONI";
            this.prenotazioni.UseVisualStyleBackColor = true;
            // 
            // cucina
            // 
            this.cucina.Location = new System.Drawing.Point(224, 12);
            this.cucina.Name = "cucina";
            this.cucina.Size = new System.Drawing.Size(100, 100);
            this.cucina.TabIndex = 2;
            this.cucina.Text = "CUCINA";
            this.cucina.UseVisualStyleBackColor = true;
            // 
            // ricevute
            // 
            this.ricevute.Location = new System.Drawing.Point(12, 118);
            this.ricevute.Name = "ricevute";
            this.ricevute.Size = new System.Drawing.Size(100, 100);
            this.ricevute.TabIndex = 3;
            this.ricevute.Text = "RICEVUTE";
            this.ricevute.UseVisualStyleBackColor = true;
            // 
            // elencoPrenotazioni
            // 
            this.elencoPrenotazioni.AllowUserToAddRows = false;
            this.elencoPrenotazioni.AllowUserToDeleteRows = false;
            this.elencoPrenotazioni.AllowUserToOrderColumns = true;
            this.elencoPrenotazioni.AllowUserToResizeColumns = false;
            this.elencoPrenotazioni.AllowUserToResizeRows = false;
            this.elencoPrenotazioni.AutoGenerateColumns = false;
            this.elencoPrenotazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.elencoPrenotazioni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.elencoPrenotazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elencoPrenotazioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.elencoPrenotazioni.DataSource = this.bindingPrenotazioni;
            this.elencoPrenotazioni.EnableHeadersVisualStyles = false;
            this.elencoPrenotazioni.Location = new System.Drawing.Point(330, 12);
            this.elencoPrenotazioni.MultiSelect = false;
            this.elencoPrenotazioni.Name = "elencoPrenotazioni";
            this.elencoPrenotazioni.ReadOnly = true;
            this.elencoPrenotazioni.RowHeadersVisible = false;
            this.elencoPrenotazioni.Size = new System.Drawing.Size(414, 365);
            this.elencoPrenotazioni.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ora";
            this.Column1.HeaderText = "Ora";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cognome";
            this.Column2.HeaderText = "Cognome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 77;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "num_persone";
            this.Column3.HeaderText = "Num Persone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 96;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "num_tavolo";
            this.Column4.HeaderText = "Tavolo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 65;
            // 
            // trasformaPrenotazione
            // 
            this.trasformaPrenotazione.Location = new System.Drawing.Point(330, 383);
            this.trasformaPrenotazione.Name = "trasformaPrenotazione";
            this.trasformaPrenotazione.Size = new System.Drawing.Size(414, 23);
            this.trasformaPrenotazione.TabIndex = 5;
            this.trasformaPrenotazione.Text = "Avvia servizio da prenotazione";
            this.trasformaPrenotazione.UseVisualStyleBackColor = true;
            // 
            // Cassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 418);
            this.Controls.Add(this.trasformaPrenotazione);
            this.Controls.Add(this.elencoPrenotazioni);
            this.Controls.Add(this.ricevute);
            this.Controls.Add(this.cucina);
            this.Controls.Add(this.prenotazioni);
            this.Controls.Add(this.servizi);
            this.Name = "Cassa";
            this.Text = "Cassa";
            this.Load += new System.EventHandler(this.Cassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingPrenotazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elencoPrenotazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingPrenotazioni;
        private System.Windows.Forms.Button servizi;
        private System.Windows.Forms.Button prenotazioni;
        private System.Windows.Forms.Button cucina;
        private System.Windows.Forms.Button ricevute;
        private System.Windows.Forms.DataGridView elencoPrenotazioni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button trasformaPrenotazione;
    }
}
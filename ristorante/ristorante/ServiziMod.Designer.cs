namespace ristorante
{
    partial class ServiziMod
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
            this.inizio = new System.Windows.Forms.Label();
            this.lblInizio = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.prenotazione = new System.Windows.Forms.ComboBox();
            this.lblPrenotazione = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.numTavolo = new System.Windows.Forms.TextBox();
            this.lblNumTavolo = new System.Windows.Forms.Label();
            this.totale = new System.Windows.Forms.TextBox();
            this.lblTotale = new System.Windows.Forms.Label();
            this.numPersone = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.numServizio = new System.Windows.Forms.Label();
            this.lblNumServizio = new System.Windows.Forms.Label();
            this.fine = new System.Windows.Forms.DateTimePicker();
            this.cliente = new System.Windows.Forms.ComboBox();
            this.bindingServizi = new System.Windows.Forms.BindingSource(this.components);
            this.bindingClienti = new System.Windows.Forms.BindingSource(this.components);
            this.bindingPrenotazioni = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingServizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPrenotazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // inizio
            // 
            this.inizio.AutoSize = true;
            this.inizio.Location = new System.Drawing.Point(88, 53);
            this.inizio.Name = "inizio";
            this.inizio.Size = new System.Drawing.Size(35, 13);
            this.inizio.TabIndex = 43;
            this.inizio.Text = "label2";
            // 
            // lblInizio
            // 
            this.lblInizio.AutoSize = true;
            this.lblInizio.Location = new System.Drawing.Point(12, 53);
            this.lblInizio.Name = "lblInizio";
            this.lblInizio.Size = new System.Drawing.Size(34, 13);
            this.lblInizio.TabIndex = 42;
            this.lblInizio.Text = "Inizio:";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(91, 228);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 23);
            this.update.TabIndex = 41;
            this.update.Text = "Salva Modifiche";
            this.update.UseVisualStyleBackColor = true;
            // 
            // prenotazione
            // 
            this.prenotazione.FormattingEnabled = true;
            this.prenotazione.Items.AddRange(new object[] {
            "M",
            "F"});
            this.prenotazione.Location = new System.Drawing.Point(91, 201);
            this.prenotazione.Name = "prenotazione";
            this.prenotazione.Size = new System.Drawing.Size(201, 21);
            this.prenotazione.TabIndex = 40;
            // 
            // lblPrenotazione
            // 
            this.lblPrenotazione.AutoSize = true;
            this.lblPrenotazione.Location = new System.Drawing.Point(11, 210);
            this.lblPrenotazione.Name = "lblPrenotazione";
            this.lblPrenotazione.Size = new System.Drawing.Size(72, 13);
            this.lblPrenotazione.TabIndex = 39;
            this.lblPrenotazione.Text = "Prenotazione:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(11, 182);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 35;
            this.lblCliente.Text = "Cliente:";
            // 
            // numTavolo
            // 
            this.numTavolo.Location = new System.Drawing.Point(91, 149);
            this.numTavolo.Name = "numTavolo";
            this.numTavolo.Size = new System.Drawing.Size(201, 20);
            this.numTavolo.TabIndex = 34;
            // 
            // lblNumTavolo
            // 
            this.lblNumTavolo.AutoSize = true;
            this.lblNumTavolo.Location = new System.Drawing.Point(11, 156);
            this.lblNumTavolo.Name = "lblNumTavolo";
            this.lblNumTavolo.Size = new System.Drawing.Size(68, 13);
            this.lblNumTavolo.TabIndex = 33;
            this.lblNumTavolo.Text = "Num Tavolo:";
            // 
            // totale
            // 
            this.totale.Location = new System.Drawing.Point(91, 123);
            this.totale.Name = "totale";
            this.totale.Size = new System.Drawing.Size(201, 20);
            this.totale.TabIndex = 32;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(11, 130);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(40, 13);
            this.lblTotale.TabIndex = 31;
            this.lblTotale.Text = "Totale:";
            // 
            // numPersone
            // 
            this.numPersone.Location = new System.Drawing.Point(91, 97);
            this.numPersone.Name = "numPersone";
            this.numPersone.Size = new System.Drawing.Size(201, 20);
            this.numPersone.TabIndex = 30;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(11, 104);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(74, 13);
            this.lblCognome.TabIndex = 29;
            this.lblCognome.Text = "Num Persone:";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(11, 78);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(30, 13);
            this.lblFine.TabIndex = 27;
            this.lblFine.Text = "Fine:";
            // 
            // numServizio
            // 
            this.numServizio.AutoSize = true;
            this.numServizio.Location = new System.Drawing.Point(88, 29);
            this.numServizio.Name = "numServizio";
            this.numServizio.Size = new System.Drawing.Size(35, 13);
            this.numServizio.TabIndex = 25;
            this.numServizio.Text = "label2";
            // 
            // lblNumServizio
            // 
            this.lblNumServizio.AutoSize = true;
            this.lblNumServizio.Location = new System.Drawing.Point(12, 29);
            this.lblNumServizio.Name = "lblNumServizio";
            this.lblNumServizio.Size = new System.Drawing.Size(72, 13);
            this.lblNumServizio.TabIndex = 23;
            this.lblNumServizio.Text = "Num Servizio:";
            // 
            // fine
            // 
            this.fine.Location = new System.Drawing.Point(91, 70);
            this.fine.Name = "fine";
            this.fine.Size = new System.Drawing.Size(200, 20);
            this.fine.TabIndex = 44;
            // 
            // cliente
            // 
            this.cliente.DataSource = this.bindingClienti;
            this.cliente.FormattingEnabled = true;
            this.cliente.Location = new System.Drawing.Point(90, 174);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(201, 21);
            this.cliente.TabIndex = 45;
            // 
            // ServiziMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 281);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.fine);
            this.Controls.Add(this.inizio);
            this.Controls.Add(this.lblInizio);
            this.Controls.Add(this.update);
            this.Controls.Add(this.prenotazione);
            this.Controls.Add(this.lblPrenotazione);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.numTavolo);
            this.Controls.Add(this.lblNumTavolo);
            this.Controls.Add(this.totale);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.numPersone);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.numServizio);
            this.Controls.Add(this.lblNumServizio);
            this.Name = "ServiziMod";
            this.Text = "ServiziMod";
            ((System.ComponentModel.ISupportInitialize)(this.bindingServizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPrenotazioni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inizio;
        private System.Windows.Forms.Label lblInizio;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox prenotazione;
        private System.Windows.Forms.Label lblPrenotazione;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox numTavolo;
        private System.Windows.Forms.Label lblNumTavolo;
        private System.Windows.Forms.TextBox totale;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.TextBox numPersone;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label numServizio;
        private System.Windows.Forms.Label lblNumServizio;
        private System.Windows.Forms.BindingSource bindingServizi;
        private System.Windows.Forms.DateTimePicker fine;
        private System.Windows.Forms.ComboBox cliente;
        private System.Windows.Forms.BindingSource bindingClienti;
        private System.Windows.Forms.BindingSource bindingPrenotazioni;
    }
}
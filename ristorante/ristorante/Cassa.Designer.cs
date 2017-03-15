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
            this.listaPrenotazioni = new System.Windows.Forms.BindingSource(this.components);
            this.creaServizio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrenotazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // listaPrenotazioni
            // 
            this.listaPrenotazioni.DataSource = typeof(ristorante.Prenotazione);
            // 
            // creaServizio
            // 
            this.creaServizio.Location = new System.Drawing.Point(12, 12);
            this.creaServizio.Name = "creaServizio";
            this.creaServizio.Size = new System.Drawing.Size(100, 100);
            this.creaServizio.TabIndex = 0;
            this.creaServizio.Text = "SERVIZI";
            this.creaServizio.UseVisualStyleBackColor = true;
            this.creaServizio.Click += new System.EventHandler(this.creaServizio_Click);
            // 
            // Cassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 296);
            this.Controls.Add(this.creaServizio);
            this.Name = "Cassa";
            this.Text = "Cassa";
            this.Load += new System.EventHandler(this.Cassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPrenotazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource listaPrenotazioni;
        private System.Windows.Forms.Button creaServizio;
    }
}
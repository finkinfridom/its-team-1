namespace ristorante
{
    partial class TavoliMod
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
            this.update = new System.Windows.Forms.Button();
            this.maxPosti = new System.Windows.Forms.TextBox();
            this.lblPosti = new System.Windows.Forms.Label();
            this.numTavolo = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.bindingTavoli = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingTavoli)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(82, 102);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 23);
            this.update.TabIndex = 41;
            this.update.Text = "Salva Modifiche";
            this.update.UseVisualStyleBackColor = true;
            // 
            // maxPosti
            // 
            this.maxPosti.Location = new System.Drawing.Point(71, 56);
            this.maxPosti.Name = "maxPosti";
            this.maxPosti.Size = new System.Drawing.Size(201, 20);
            this.maxPosti.TabIndex = 30;
            // 
            // lblPosti
            // 
            this.lblPosti.AutoSize = true;
            this.lblPosti.Location = new System.Drawing.Point(12, 63);
            this.lblPosti.Name = "lblPosti";
            this.lblPosti.Size = new System.Drawing.Size(56, 13);
            this.lblPosti.TabIndex = 29;
            this.lblPosti.Text = "Max Posti:";
            // 
            // numTavolo
            // 
            this.numTavolo.Location = new System.Drawing.Point(71, 30);
            this.numTavolo.Name = "numTavolo";
            this.numTavolo.Size = new System.Drawing.Size(201, 20);
            this.numTavolo.TabIndex = 28;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 37);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "Numero:";
            // 
            // TavoliMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.update);
            this.Controls.Add(this.maxPosti);
            this.Controls.Add(this.lblPosti);
            this.Controls.Add(this.numTavolo);
            this.Controls.Add(this.lblNumero);
            this.Name = "TavoliMod";
            this.Text = "TavoliMod";
            ((System.ComponentModel.ISupportInitialize)(this.bindingTavoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox maxPosti;
        private System.Windows.Forms.Label lblPosti;
        private System.Windows.Forms.TextBox numTavolo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.BindingSource bindingTavoli;
    }
}
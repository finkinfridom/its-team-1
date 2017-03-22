namespace ristorante
{
    partial class CategorieMod
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
            this.lblAttiva = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.attiva = new System.Windows.Forms.CheckBox();
            this.bindingCategorie = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(81, 82);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 23);
            this.update.TabIndex = 58;
            this.update.Text = "Salva Modifiche";
            this.update.UseVisualStyleBackColor = true;
            // 
            // lblAttiva
            // 
            this.lblAttiva.AutoSize = true;
            this.lblAttiva.Location = new System.Drawing.Point(1, 63);
            this.lblAttiva.Name = "lblAttiva";
            this.lblAttiva.Size = new System.Drawing.Size(37, 13);
            this.lblAttiva.TabIndex = 51;
            this.lblAttiva.Text = "Attiva:";
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(81, 30);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(201, 20);
            this.categoria.TabIndex = 50;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(1, 37);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 49;
            this.lblCategoria.Text = "Categoria:";
            // 
            // attiva
            // 
            this.attiva.AutoSize = true;
            this.attiva.Location = new System.Drawing.Point(81, 59);
            this.attiva.Name = "attiva";
            this.attiva.Size = new System.Drawing.Size(15, 14);
            this.attiva.TabIndex = 59;
            this.attiva.UseVisualStyleBackColor = true;
            // 
            // CategorieMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 128);
            this.Controls.Add(this.attiva);
            this.Controls.Add(this.update);
            this.Controls.Add(this.lblAttiva);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "CategorieMod";
            this.Text = "CategorieMod";
            ((System.ComponentModel.ISupportInitialize)(this.bindingCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label lblAttiva;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox attiva;
        private System.Windows.Forms.BindingSource bindingCategorie;
    }
}
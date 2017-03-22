namespace ristorante
{
    partial class ClientiMod
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
            this.lblProvider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.provider = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.cognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.indirizzo = new System.Windows.Forms.TextBox();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.punti = new System.Windows.Forms.TextBox();
            this.lblPunti = new System.Windows.Forms.Label();
            this.lblSesso = new System.Windows.Forms.Label();
            this.sesso = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.bindingClienti = new System.Windows.Forms.BindingSource(this.components);
            this.codice = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(12, 51);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(49, 13);
            this.lblProvider.TabIndex = 1;
            this.lblProvider.Text = "Provider:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UID:";
            // 
            // provider
            // 
            this.provider.AutoSize = true;
            this.provider.Location = new System.Drawing.Point(67, 51);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(35, 13);
            this.provider.TabIndex = 4;
            this.provider.Text = "label2";
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.Location = new System.Drawing.Point(67, 71);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(35, 13);
            this.uid.TabIndex = 5;
            this.uid.Text = "label2";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(70, 87);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(201, 20);
            this.nome.TabIndex = 7;
            // 
            // cognome
            // 
            this.cognome.Location = new System.Drawing.Point(70, 113);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(201, 20);
            this.cognome.TabIndex = 9;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(11, 120);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(55, 13);
            this.lblCognome.TabIndex = 8;
            this.lblCognome.Text = "Cognome:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(70, 139);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(201, 20);
            this.mail.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(11, 146);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail:";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(70, 165);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(201, 20);
            this.telefono.TabIndex = 13;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(11, 172);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono:";
            // 
            // indirizzo
            // 
            this.indirizzo.Location = new System.Drawing.Point(70, 191);
            this.indirizzo.Name = "indirizzo";
            this.indirizzo.Size = new System.Drawing.Size(201, 20);
            this.indirizzo.TabIndex = 15;
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Location = new System.Drawing.Point(11, 198);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(48, 13);
            this.lblIndirizzo.TabIndex = 14;
            this.lblIndirizzo.Text = "Indirizzo:";
            // 
            // punti
            // 
            this.punti.Location = new System.Drawing.Point(70, 217);
            this.punti.Name = "punti";
            this.punti.Size = new System.Drawing.Size(201, 20);
            this.punti.TabIndex = 17;
            // 
            // lblPunti
            // 
            this.lblPunti.AutoSize = true;
            this.lblPunti.Location = new System.Drawing.Point(11, 224);
            this.lblPunti.Name = "lblPunti";
            this.lblPunti.Size = new System.Drawing.Size(34, 13);
            this.lblPunti.TabIndex = 16;
            this.lblPunti.Text = "Punti:";
            // 
            // lblSesso
            // 
            this.lblSesso.AutoSize = true;
            this.lblSesso.Location = new System.Drawing.Point(11, 250);
            this.lblSesso.Name = "lblSesso";
            this.lblSesso.Size = new System.Drawing.Size(39, 13);
            this.lblSesso.TabIndex = 18;
            this.lblSesso.Text = "Sesso:";
            // 
            // sesso
            // 
            this.sesso.FormattingEnabled = true;
            this.sesso.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sesso.Location = new System.Drawing.Point(70, 241);
            this.sesso.Name = "sesso";
            this.sesso.Size = new System.Drawing.Size(201, 21);
            this.sesso.TabIndex = 19;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(82, 268);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 23);
            this.update.TabIndex = 20;
            this.update.Text = "Salva Modifiche";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button1_Click);
            // 
            // codice
            // 
            this.codice.AutoSize = true;
            this.codice.Location = new System.Drawing.Point(67, 29);
            this.codice.Name = "codice";
            this.codice.Size = new System.Drawing.Size(35, 13);
            this.codice.TabIndex = 22;
            this.codice.Text = "label2";
            this.codice.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(12, 29);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(43, 13);
            this.lblCodice.TabIndex = 21;
            this.lblCodice.Text = "Codice:";
            this.lblCodice.Click += new System.EventHandler(this.label4_Click);
            // 
            // ClientiMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.codice);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.update);
            this.Controls.Add(this.sesso);
            this.Controls.Add(this.lblSesso);
            this.Controls.Add(this.punti);
            this.Controls.Add(this.lblPunti);
            this.Controls.Add(this.indirizzo);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.cognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProvider);
            this.Name = "ClientiMod";
            this.Text = "ProdottiMod";
            ((System.ComponentModel.ISupportInitialize)(this.bindingClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label provider;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox cognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox indirizzo;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.TextBox punti;
        private System.Windows.Forms.Label lblPunti;
        private System.Windows.Forms.Label lblSesso;
        private System.Windows.Forms.ComboBox sesso;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.BindingSource bindingClienti;
        private System.Windows.Forms.Label codice;
        private System.Windows.Forms.Label lblCodice;
    }
}
namespace CreaPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbIndirizzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatrice = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btCrea = new System.Windows.Forms.Button();
            this.btEsci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUtente = new System.Windows.Forms.TextBox();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFinale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pbLunghezza = new System.Windows.Forms.ProgressBar();
            this.lbLunghezza = new System.Windows.Forms.Label();
            this.chbRegistra = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMinuscole = new System.Windows.Forms.PictureBox();
            this.pbSpeciali = new System.Windows.Forms.PictureBox();
            this.pbNumeri = new System.Windows.Forms.PictureBox();
            this.pbMaiuscole = new System.Windows.Forms.PictureBox();
            this.pbConsonanti = new System.Windows.Forms.PictureBox();
            this.pbVocali = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinuscole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeciali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaiuscole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsonanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVocali)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIndirizzo
            // 
            this.tbIndirizzo.Location = new System.Drawing.Point(38, 119);
            this.tbIndirizzo.Name = "tbIndirizzo";
            this.tbIndirizzo.Size = new System.Drawing.Size(312, 20);
            this.tbIndirizzo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indirizzo sito web (anche senza www. e .it/.com ecc.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "CREA PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metodo automatico per la creazione di una password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "La tua matrice comune a tutte le tue password";
            // 
            // tbMatrice
            // 
            this.tbMatrice.Location = new System.Drawing.Point(38, 213);
            this.tbMatrice.Name = "tbMatrice";
            this.tbMatrice.Size = new System.Drawing.Size(312, 20);
            this.tbMatrice.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(357, 166);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(19, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Visible = false;
            // 
            // btCrea
            // 
            this.btCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrea.Location = new System.Drawing.Point(39, 387);
            this.btCrea.Name = "btCrea";
            this.btCrea.Size = new System.Drawing.Size(213, 40);
            this.btCrea.TabIndex = 6;
            this.btCrea.Text = "Calcola e copia";
            this.btCrea.UseVisualStyleBackColor = true;
            this.btCrea.Click += new System.EventHandler(this.btCrea_Click);
            // 
            // btEsci
            // 
            this.btEsci.Location = new System.Drawing.Point(263, 387);
            this.btEsci.Name = "btEsci";
            this.btEsci.Size = new System.Drawing.Size(88, 40);
            this.btEsci.TabIndex = 7;
            this.btEsci.Text = "Esci";
            this.btEsci.UseVisualStyleBackColor = true;
            this.btEsci.Click += new System.EventHandler(this.btEsci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Il nome Utente (ad esempio quello che usate nel sito)";
            // 
            // tbUtente
            // 
            this.tbUtente.Location = new System.Drawing.Point(38, 166);
            this.tbUtente.Name = "tbUtente";
            this.tbUtente.Size = new System.Drawing.Size(312, 20);
            this.tbUtente.TabIndex = 1;
            // 
            // tbMD5
            // 
            this.tbMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMD5.Location = new System.Drawing.Point(356, 213);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.Size = new System.Drawing.Size(19, 20);
            this.tbMD5.TabIndex = 4;
            this.tbMD5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password (è già copiata negli appunti, basta fare CTRL+V nel sito)";
            // 
            // tbFinale
            // 
            this.tbFinale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFinale.Location = new System.Drawing.Point(39, 263);
            this.tbFinale.Name = "tbFinale";
            this.tbFinale.Size = new System.Drawing.Size(312, 20);
            this.tbFinale.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Vocali";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Consonanti";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(139, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Maiuscole";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(197, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Minuscole";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Numeri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(309, 349);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Speciali";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(245, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "univoca che usa sito, nome utente, MD5 e matrice";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(60, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(273, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Emilie Rollandin - Studio Archistico - www.archistico.com";
            // 
            // pbLunghezza
            // 
            this.pbLunghezza.Location = new System.Drawing.Point(39, 294);
            this.pbLunghezza.Maximum = 16;
            this.pbLunghezza.Name = "pbLunghezza";
            this.pbLunghezza.Size = new System.Drawing.Size(222, 13);
            this.pbLunghezza.Step = 1;
            this.pbLunghezza.TabIndex = 30;
            // 
            // lbLunghezza
            // 
            this.lbLunghezza.AutoSize = true;
            this.lbLunghezza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLunghezza.Location = new System.Drawing.Point(265, 294);
            this.lbLunghezza.Name = "lbLunghezza";
            this.lbLunghezza.Size = new System.Drawing.Size(65, 13);
            this.lbLunghezza.TabIndex = 31;
            this.lbLunghezza.Text = "Lunghezza: ";
            // 
            // chbRegistra
            // 
            this.chbRegistra.AutoSize = true;
            this.chbRegistra.Location = new System.Drawing.Point(75, 443);
            this.chbRegistra.Name = "chbRegistra";
            this.chbRegistra.Size = new System.Drawing.Size(250, 17);
            this.chbRegistra.TabIndex = 8;
            this.chbRegistra.Text = "Mantieni valori sito web, nome utente e matrice ";
            this.chbRegistra.UseVisualStyleBackColor = true;
            this.chbRegistra.CheckedChanged += new System.EventHandler(this.chbRegistra_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreaPW.Properties.Resources.icona;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pbMinuscole
            // 
            this.pbMinuscole.Image = global::CreaPW.Properties.Resources.uncheck;
            this.pbMinuscole.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMinuscole.InitialImage")));
            this.pbMinuscole.Location = new System.Drawing.Point(207, 316);
            this.pbMinuscole.Name = "pbMinuscole";
            this.pbMinuscole.Size = new System.Drawing.Size(30, 30);
            this.pbMinuscole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMinuscole.TabIndex = 24;
            this.pbMinuscole.TabStop = false;
            // 
            // pbSpeciali
            // 
            this.pbSpeciali.Image = global::CreaPW.Properties.Resources.uncheck;
            this.pbSpeciali.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSpeciali.InitialImage")));
            this.pbSpeciali.Location = new System.Drawing.Point(319, 316);
            this.pbSpeciali.Name = "pbSpeciali";
            this.pbSpeciali.Size = new System.Drawing.Size(30, 30);
            this.pbSpeciali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSpeciali.TabIndex = 22;
            this.pbSpeciali.TabStop = false;
            // 
            // pbNumeri
            // 
            this.pbNumeri.Image = global::CreaPW.Properties.Resources.uncheck;
            this.pbNumeri.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbNumeri.InitialImage")));
            this.pbNumeri.Location = new System.Drawing.Point(263, 316);
            this.pbNumeri.Name = "pbNumeri";
            this.pbNumeri.Size = new System.Drawing.Size(30, 30);
            this.pbNumeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNumeri.TabIndex = 20;
            this.pbNumeri.TabStop = false;
            // 
            // pbMaiuscole
            // 
            this.pbMaiuscole.Image = global::CreaPW.Properties.Resources.uncheck;
            this.pbMaiuscole.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMaiuscole.InitialImage")));
            this.pbMaiuscole.Location = new System.Drawing.Point(151, 316);
            this.pbMaiuscole.Name = "pbMaiuscole";
            this.pbMaiuscole.Size = new System.Drawing.Size(30, 30);
            this.pbMaiuscole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMaiuscole.TabIndex = 18;
            this.pbMaiuscole.TabStop = false;
            // 
            // pbConsonanti
            // 
            this.pbConsonanti.Image = global::CreaPW.Properties.Resources.uncheck;
            this.pbConsonanti.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbConsonanti.InitialImage")));
            this.pbConsonanti.Location = new System.Drawing.Point(95, 316);
            this.pbConsonanti.Name = "pbConsonanti";
            this.pbConsonanti.Size = new System.Drawing.Size(30, 30);
            this.pbConsonanti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConsonanti.TabIndex = 16;
            this.pbConsonanti.TabStop = false;
            // 
            // pbVocali
            // 
            this.pbVocali.Image = global::CreaPW.Properties.Resources.uncheck;
            this.pbVocali.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbVocali.InitialImage")));
            this.pbVocali.Location = new System.Drawing.Point(39, 316);
            this.pbVocali.Name = "pbVocali";
            this.pbVocali.Size = new System.Drawing.Size(30, 30);
            this.pbVocali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbVocali.TabIndex = 14;
            this.pbVocali.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 509);
            this.Controls.Add(this.chbRegistra);
            this.Controls.Add(this.lbLunghezza);
            this.Controls.Add(this.pbLunghezza);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pbMinuscole);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pbSpeciali);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbNumeri);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbMaiuscole);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbConsonanti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbVocali);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFinale);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUtente);
            this.Controls.Add(this.btEsci);
            this.Controls.Add(this.btCrea);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMatrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIndirizzo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreaPW - Archistico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinuscole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeciali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaiuscole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsonanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVocali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIndirizzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatrice;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btCrea;
        private System.Windows.Forms.Button btEsci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUtente;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFinale;
        private System.Windows.Forms.PictureBox pbVocali;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbConsonanti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbMaiuscole;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbNumeri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbSpeciali;
        private System.Windows.Forms.PictureBox pbMinuscole;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ProgressBar pbLunghezza;
        private System.Windows.Forms.Label lbLunghezza;
        private System.Windows.Forms.CheckBox chbRegistra;
    }
}


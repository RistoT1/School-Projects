namespace Palkanlasku
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
            this.Tuntipalkka = new System.Windows.Forms.Label();
            this.Laske = new System.Windows.Forms.Button();
            this.txtTunti = new System.Windows.Forms.TextBox();
            this.txtnorm = new System.Windows.Forms.TextBox();
            this.txtpuol = new System.Windows.Forms.TextBox();
            this.txtsata = new System.Windows.Forms.TextBox();
            this.Normaali = new System.Windows.Forms.Label();
            this.ylipuol = new System.Windows.Forms.Label();
            this.ylisata = new System.Windows.Forms.Label();
            this.euromerkki = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TunnitL = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PalkkaL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tuntipalkka
            // 
            this.Tuntipalkka.AutoSize = true;
            this.Tuntipalkka.Location = new System.Drawing.Point(26, 24);
            this.Tuntipalkka.Name = "Tuntipalkka";
            this.Tuntipalkka.Size = new System.Drawing.Size(90, 20);
            this.Tuntipalkka.TabIndex = 0;
            this.Tuntipalkka.Text = "Tuntipalkka";
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(34, 337);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(85, 31);
            this.Laske.TabIndex = 1;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // txtTunti
            // 
            this.txtTunti.Location = new System.Drawing.Point(30, 63);
            this.txtTunti.Name = "txtTunti";
            this.txtTunti.Size = new System.Drawing.Size(100, 26);
            this.txtTunti.TabIndex = 2;
            // 
            // txtnorm
            // 
            this.txtnorm.Location = new System.Drawing.Point(30, 137);
            this.txtnorm.Name = "txtnorm";
            this.txtnorm.Size = new System.Drawing.Size(100, 26);
            this.txtnorm.TabIndex = 3;
            // 
            // txtpuol
            // 
            this.txtpuol.Location = new System.Drawing.Point(30, 209);
            this.txtpuol.Name = "txtpuol";
            this.txtpuol.Size = new System.Drawing.Size(100, 26);
            this.txtpuol.TabIndex = 4;
            // 
            // txtsata
            // 
            this.txtsata.Location = new System.Drawing.Point(30, 293);
            this.txtsata.Name = "txtsata";
            this.txtsata.Size = new System.Drawing.Size(100, 26);
            this.txtsata.TabIndex = 5;
            // 
            // Normaali
            // 
            this.Normaali.AutoSize = true;
            this.Normaali.Location = new System.Drawing.Point(30, 111);
            this.Normaali.Name = "Normaali";
            this.Normaali.Size = new System.Drawing.Size(143, 20);
            this.Normaali.TabIndex = 6;
            this.Normaali.Text = "Normaali palkkaset";
            // 
            // ylipuol
            // 
            this.ylipuol.AutoSize = true;
            this.ylipuol.Location = new System.Drawing.Point(30, 183);
            this.ylipuol.Name = "ylipuol";
            this.ylipuol.Size = new System.Drawing.Size(144, 20);
            this.ylipuol.TabIndex = 7;
            this.ylipuol.Text = "50% korotettu tunti";
            // 
            // ylisata
            // 
            this.ylisata.AutoSize = true;
            this.ylisata.Location = new System.Drawing.Point(30, 258);
            this.ylisata.Name = "ylisata";
            this.ylisata.Size = new System.Drawing.Size(153, 20);
            this.ylisata.TabIndex = 8;
            this.ylisata.Text = "100% korotettu tunti";
            // 
            // euromerkki
            // 
            this.euromerkki.AutoSize = true;
            this.euromerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.euromerkki.Location = new System.Drawing.Point(123, 67);
            this.euromerkki.Name = "euromerkki";
            this.euromerkki.Size = new System.Drawing.Size(20, 22);
            this.euromerkki.TabIndex = 9;
            this.euromerkki.Text = "€";
            this.euromerkki.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tunnit yhteensä";
            // 
            // TunnitL
            // 
            this.TunnitL.AutoSize = true;
            this.TunnitL.Location = new System.Drawing.Point(401, 101);
            this.TunnitL.Name = "TunnitL";
            this.TunnitL.Size = new System.Drawing.Size(24, 20);
            this.TunnitL.TabIndex = 11;
            this.TunnitL.Text = "---";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(401, 143);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(125, 20);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Palkka yhteensä";
            this.Label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PalkkaL
            // 
            this.PalkkaL.AutoSize = true;
            this.PalkkaL.Location = new System.Drawing.Point(401, 183);
            this.PalkkaL.Name = "PalkkaL";
            this.PalkkaL.Size = new System.Drawing.Size(24, 20);
            this.PalkkaL.TabIndex = 13;
            this.PalkkaL.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PalkkaL);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TunnitL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.euromerkki);
            this.Controls.Add(this.ylisata);
            this.Controls.Add(this.ylipuol);
            this.Controls.Add(this.Normaali);
            this.Controls.Add(this.txtsata);
            this.Controls.Add(this.txtpuol);
            this.Controls.Add(this.txtnorm);
            this.Controls.Add(this.txtTunti);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.Tuntipalkka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tuntipalkka;
        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.TextBox txtTunti;
        private System.Windows.Forms.TextBox txtnorm;
        private System.Windows.Forms.TextBox txtpuol;
        private System.Windows.Forms.TextBox txtsata;
        private System.Windows.Forms.Label Normaali;
        private System.Windows.Forms.Label ylipuol;
        private System.Windows.Forms.Label ylisata;
        private System.Windows.Forms.Label euromerkki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TunnitL;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label PalkkaL;
    }
}


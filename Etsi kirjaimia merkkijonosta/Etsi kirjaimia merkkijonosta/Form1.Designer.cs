namespace Etsi_kirjaimia_merkkijonosta
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
            this.txtSana1 = new System.Windows.Forms.TextBox();
            this.txtSana2 = new System.Windows.Forms.TextBox();
            this.Sana1L = new System.Windows.Forms.Label();
            this.Sana2L = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.TxtVastausK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSana1
            // 
            this.txtSana1.Location = new System.Drawing.Point(46, 44);
            this.txtSana1.Name = "txtSana1";
            this.txtSana1.Size = new System.Drawing.Size(100, 26);
            this.txtSana1.TabIndex = 0;
            // 
            // txtSana2
            // 
            this.txtSana2.Location = new System.Drawing.Point(46, 108);
            this.txtSana2.Name = "txtSana2";
            this.txtSana2.Size = new System.Drawing.Size(100, 26);
            this.txtSana2.TabIndex = 1;
            // 
            // Sana1L
            // 
            this.Sana1L.AutoSize = true;
            this.Sana1L.Location = new System.Drawing.Point(46, 13);
            this.Sana1L.Name = "Sana1L";
            this.Sana1L.Size = new System.Drawing.Size(56, 20);
            this.Sana1L.TabIndex = 2;
            this.Sana1L.Text = "Sana1";
            // 
            // Sana2L
            // 
            this.Sana2L.AutoSize = true;
            this.Sana2L.Location = new System.Drawing.Point(46, 85);
            this.Sana2L.Name = "Sana2L";
            this.Sana2L.Size = new System.Drawing.Size(56, 20);
            this.Sana2L.TabIndex = 3;
            this.Sana2L.Text = "Sana2";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(187, 37);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(90, 40);
            this.btnJatka.TabIndex = 4;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVastaus.Location = new System.Drawing.Point(46, 186);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(213, 275);
            this.txtVastaus.TabIndex = 5;
            // 
            // TxtVastausK
            // 
            this.TxtVastausK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVastausK.Location = new System.Drawing.Point(383, 186);
            this.TxtVastausK.Multiline = true;
            this.TxtVastausK.Name = "TxtVastausK";
            this.TxtVastausK.ReadOnly = true;
            this.TxtVastausK.Size = new System.Drawing.Size(213, 275);
            this.TxtVastausK.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(387, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Löydetyt kirjaimet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(46, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ei löydetyt kirjaimet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtVastausK);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.Sana2L);
            this.Controls.Add(this.Sana1L);
            this.Controls.Add(this.txtSana2);
            this.Controls.Add(this.txtSana1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSana1;
        private System.Windows.Forms.TextBox txtSana2;
        private System.Windows.Forms.Label Sana1L;
        private System.Windows.Forms.Label Sana2L;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.TextBox TxtVastausK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


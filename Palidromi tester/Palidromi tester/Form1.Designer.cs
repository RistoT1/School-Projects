namespace Palidromi_tester
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
            this.sanaL = new System.Windows.Forms.Label();
            this.txtSana = new System.Windows.Forms.TextBox();
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.btnNollaa = new System.Windows.Forms.Button();
            this.txtVastauseiole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sanaL
            // 
            this.sanaL.AutoSize = true;
            this.sanaL.Location = new System.Drawing.Point(50, 49);
            this.sanaL.Name = "sanaL";
            this.sanaL.Size = new System.Drawing.Size(95, 20);
            this.sanaL.TabIndex = 0;
            this.sanaL.Text = "Kirjoita sana";
            // 
            // txtSana
            // 
            this.txtSana.Location = new System.Drawing.Point(54, 84);
            this.txtSana.Name = "txtSana";
            this.txtSana.Size = new System.Drawing.Size(100, 26);
            this.txtSana.TabIndex = 1;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(192, 70);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(85, 40);
            this.btnJatka.TabIndex = 2;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(54, 171);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(223, 213);
            this.txtVastaus.TabIndex = 3;
            // 
            // btnNollaa
            // 
            this.btnNollaa.Location = new System.Drawing.Point(319, 70);
            this.btnNollaa.Name = "btnNollaa";
            this.btnNollaa.Size = new System.Drawing.Size(86, 40);
            this.btnNollaa.TabIndex = 4;
            this.btnNollaa.Text = "Nollaa";
            this.btnNollaa.UseVisualStyleBackColor = true;
            this.btnNollaa.Click += new System.EventHandler(this.btnNollaa_Click);
            // 
            // txtVastauseiole
            // 
            this.txtVastauseiole.Location = new System.Drawing.Point(54, 121);
            this.txtVastauseiole.Multiline = true;
            this.txtVastauseiole.Name = "txtVastauseiole";
            this.txtVastauseiole.ReadOnly = true;
            this.txtVastauseiole.Size = new System.Drawing.Size(223, 44);
            this.txtVastauseiole.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastauseiole);
            this.Controls.Add(this.btnNollaa);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.txtSana);
            this.Controls.Add(this.sanaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sanaL;
        private System.Windows.Forms.TextBox txtSana;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.Button btnNollaa;
        private System.Windows.Forms.TextBox txtVastauseiole;
    }
}


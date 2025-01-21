namespace lukujen_summa_ja_keskiarvo__Random_
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
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.LukuL = new System.Windows.Forms.Label();
            this.SummaL = new System.Windows.Forms.Label();
            this.txtKeskiarvo = new System.Windows.Forms.TextBox();
            this.KeskiarvoL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(158, 31);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(91, 40);
            this.btnJatka.TabIndex = 0;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(40, 38);
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(100, 26);
            this.txtLuku.TabIndex = 1;
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(40, 77);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(331, 198);
            this.txtVastaus.TabIndex = 2;
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(271, 38);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.ReadOnly = true;
            this.txtSumma.Size = new System.Drawing.Size(100, 26);
            this.txtSumma.TabIndex = 3;
            // 
            // LukuL
            // 
            this.LukuL.AutoSize = true;
            this.LukuL.Location = new System.Drawing.Point(36, 9);
            this.LukuL.Name = "LukuL";
            this.LukuL.Size = new System.Drawing.Size(89, 20);
            this.LukuL.TabIndex = 4;
            this.LukuL.Text = "Syötä Luku";
            // 
            // SummaL
            // 
            this.SummaL.AutoSize = true;
            this.SummaL.Location = new System.Drawing.Point(270, 13);
            this.SummaL.Name = "SummaL";
            this.SummaL.Size = new System.Drawing.Size(64, 20);
            this.SummaL.TabIndex = 5;
            this.SummaL.Text = "Summa";
            // 
            // txtKeskiarvo
            // 
            this.txtKeskiarvo.Location = new System.Drawing.Point(392, 38);
            this.txtKeskiarvo.Name = "txtKeskiarvo";
            this.txtKeskiarvo.ReadOnly = true;
            this.txtKeskiarvo.Size = new System.Drawing.Size(100, 26);
            this.txtKeskiarvo.TabIndex = 6;
            // 
            // KeskiarvoL
            // 
            this.KeskiarvoL.AutoSize = true;
            this.KeskiarvoL.Location = new System.Drawing.Point(388, 13);
            this.KeskiarvoL.Name = "KeskiarvoL";
            this.KeskiarvoL.Size = new System.Drawing.Size(77, 20);
            this.KeskiarvoL.TabIndex = 7;
            this.KeskiarvoL.Text = "Keskiarvo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeskiarvoL);
            this.Controls.Add(this.txtKeskiarvo);
            this.Controls.Add(this.SummaL);
            this.Controls.Add(this.LukuL);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.txtLuku);
            this.Controls.Add(this.btnJatka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtLuku;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.Label LukuL;
        private System.Windows.Forms.Label SummaL;
        private System.Windows.Forms.TextBox txtKeskiarvo;
        private System.Windows.Forms.Label KeskiarvoL;
    }
}


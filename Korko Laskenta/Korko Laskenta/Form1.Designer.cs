namespace Korko_Laskenta
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
            this.PaaomaL = new System.Windows.Forms.Label();
            this.txtpaaoma = new System.Windows.Forms.TextBox();
            this.txtKorko = new System.Windows.Forms.TextBox();
            this.txtAika = new System.Windows.Forms.TextBox();
            this.KorkoL = new System.Windows.Forms.Label();
            this.aikaL = new System.Windows.Forms.Label();
            this.BtnLaske = new System.Windows.Forms.Button();
            this.Vastaus1L = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KorkovastausL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vastaus2L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaaomaL
            // 
            this.PaaomaL.AutoSize = true;
            this.PaaomaL.Location = new System.Drawing.Point(34, 25);
            this.PaaomaL.Name = "PaaomaL";
            this.PaaomaL.Size = new System.Drawing.Size(68, 20);
            this.PaaomaL.TabIndex = 0;
            this.PaaomaL.Text = "Pääoma";
            // 
            // txtpaaoma
            // 
            this.txtpaaoma.Location = new System.Drawing.Point(28, 72);
            this.txtpaaoma.Name = "txtpaaoma";
            this.txtpaaoma.Size = new System.Drawing.Size(81, 26);
            this.txtpaaoma.TabIndex = 1;
            // 
            // txtKorko
            // 
            this.txtKorko.Location = new System.Drawing.Point(131, 72);
            this.txtKorko.Name = "txtKorko";
            this.txtKorko.Size = new System.Drawing.Size(54, 26);
            this.txtKorko.TabIndex = 2;
            // 
            // txtAika
            // 
            this.txtAika.Location = new System.Drawing.Point(225, 72);
            this.txtAika.Name = "txtAika";
            this.txtAika.Size = new System.Drawing.Size(61, 26);
            this.txtAika.TabIndex = 3;
            // 
            // KorkoL
            // 
            this.KorkoL.AutoSize = true;
            this.KorkoL.Location = new System.Drawing.Point(131, 25);
            this.KorkoL.Name = "KorkoL";
            this.KorkoL.Size = new System.Drawing.Size(50, 20);
            this.KorkoL.TabIndex = 4;
            this.KorkoL.Text = "Korko";
            // 
            // aikaL
            // 
            this.aikaL.AutoSize = true;
            this.aikaL.Location = new System.Drawing.Point(213, 25);
            this.aikaL.Name = "aikaL";
            this.aikaL.Size = new System.Drawing.Size(91, 20);
            this.aikaL.TabIndex = 5;
            this.aikaL.Text = "aika päivinä";
            // 
            // BtnLaske
            // 
            this.BtnLaske.Location = new System.Drawing.Point(45, 132);
            this.BtnLaske.Name = "BtnLaske";
            this.BtnLaske.Size = new System.Drawing.Size(99, 37);
            this.BtnLaske.TabIndex = 6;
            this.BtnLaske.Text = "Laske";
            this.BtnLaske.UseVisualStyleBackColor = true;
            this.BtnLaske.Click += new System.EventHandler(this.BtnLaske_Click);
            // 
            // Vastaus1L
            // 
            this.Vastaus1L.AutoSize = true;
            this.Vastaus1L.Location = new System.Drawing.Point(324, 78);
            this.Vastaus1L.Name = "Vastaus1L";
            this.Vastaus1L.Size = new System.Drawing.Size(24, 20);
            this.Vastaus1L.TabIndex = 7;
            this.Vastaus1L.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(187, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // KorkovastausL
            // 
            this.KorkovastausL.AutoSize = true;
            this.KorkovastausL.Location = new System.Drawing.Point(324, 47);
            this.KorkovastausL.Name = "KorkovastausL";
            this.KorkovastausL.Size = new System.Drawing.Size(100, 20);
            this.KorkovastausL.TabIndex = 9;
            this.KorkovastausL.Text = "Korko Tuotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kokonais Tuotto";
            // 
            // Vastaus2L
            // 
            this.Vastaus2L.AutoSize = true;
            this.Vastaus2L.Location = new System.Drawing.Point(324, 140);
            this.Vastaus2L.Name = "Vastaus2L";
            this.Vastaus2L.Size = new System.Drawing.Size(24, 20);
            this.Vastaus2L.TabIndex = 11;
            this.Vastaus2L.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vastaus2L);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KorkovastausL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vastaus1L);
            this.Controls.Add(this.BtnLaske);
            this.Controls.Add(this.aikaL);
            this.Controls.Add(this.KorkoL);
            this.Controls.Add(this.txtAika);
            this.Controls.Add(this.txtKorko);
            this.Controls.Add(this.txtpaaoma);
            this.Controls.Add(this.PaaomaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaaomaL;
        private System.Windows.Forms.TextBox txtpaaoma;
        private System.Windows.Forms.TextBox txtKorko;
        private System.Windows.Forms.TextBox txtAika;
        private System.Windows.Forms.Label KorkoL;
        private System.Windows.Forms.Label aikaL;
        private System.Windows.Forms.Button BtnLaske;
        private System.Windows.Forms.Label Vastaus1L;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KorkovastausL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Vastaus2L;
    }
}


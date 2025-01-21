namespace listaa_ja_laske_summa
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
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.SummaL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(52, 62);
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(100, 26);
            this.txtLuku.TabIndex = 0;
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(193, 51);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(86, 37);
            this.btnTulosta.TabIndex = 1;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.btnTulosta_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 104);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(367, 210);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Syötä luku";
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(445, 104);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.ReadOnly = true;
            this.txtSumma.Size = new System.Drawing.Size(100, 26);
            this.txtSumma.TabIndex = 4;
            // 
            // SummaL
            // 
            this.SummaL.AutoSize = true;
            this.SummaL.Location = new System.Drawing.Point(441, 68);
            this.SummaL.Name = "SummaL";
            this.SummaL.Size = new System.Drawing.Size(64, 20);
            this.SummaL.TabIndex = 5;
            this.SummaL.Text = "Summa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SummaL);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.txtLuku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLuku;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.Label SummaL;
    }
}


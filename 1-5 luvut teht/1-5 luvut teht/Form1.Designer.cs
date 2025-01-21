namespace _1_5_luvut_teht
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
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.Luku1l = new System.Windows.Forms.Label();
            this.Luku2L = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(71, 95);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 26);
            this.txtMin.TabIndex = 0;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(272, 95);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 1;
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(418, 95);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(86, 35);
            this.btnTulosta.TabIndex = 2;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.btnTulosta_Click);
            // 
            // Luku1l
            // 
            this.Luku1l.AutoSize = true;
            this.Luku1l.Location = new System.Drawing.Point(67, 66);
            this.Luku1l.Name = "Luku1l";
            this.Luku1l.Size = new System.Drawing.Size(92, 20);
            this.Luku1l.TabIndex = 3;
            this.Luku1l.Text = "Luku1 (Min)";
            // 
            // Luku2L
            // 
            this.Luku2L.AutoSize = true;
            this.Luku2L.Location = new System.Drawing.Point(268, 66);
            this.Luku2L.Name = "Luku2L";
            this.Luku2L.Size = new System.Drawing.Size(96, 20);
            this.Luku2L.TabIndex = 4;
            this.Luku2L.Text = "Luku2 (Max)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(166, 226);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 136);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(166, 226);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Luku2L);
            this.Controls.Add(this.Luku1l);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.Label Luku1l;
        private System.Windows.Forms.Label Luku2L;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


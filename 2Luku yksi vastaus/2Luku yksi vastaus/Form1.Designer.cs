namespace _2Luku_yksi_vastaus
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Luku1L = new System.Windows.Forms.Label();
            this.Luku2L = new System.Windows.Forms.Label();
            this.btnPienempi = new System.Windows.Forms.Button();
            this.btnSuurempi = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            // 
            // Luku1L
            // 
            this.Luku1L.AutoSize = true;
            this.Luku1L.Location = new System.Drawing.Point(49, 28);
            this.Luku1L.Name = "Luku1L";
            this.Luku1L.Size = new System.Drawing.Size(53, 20);
            this.Luku1L.TabIndex = 2;
            this.Luku1L.Text = "Luku1";
            // 
            // Luku2L
            // 
            this.Luku2L.AutoSize = true;
            this.Luku2L.Location = new System.Drawing.Point(194, 27);
            this.Luku2L.Name = "Luku2L";
            this.Luku2L.Size = new System.Drawing.Size(53, 20);
            this.Luku2L.TabIndex = 3;
            this.Luku2L.Text = "Luku2";
            // 
            // btnPienempi
            // 
            this.btnPienempi.Location = new System.Drawing.Point(34, 96);
            this.btnPienempi.Name = "btnPienempi";
            this.btnPienempi.Size = new System.Drawing.Size(121, 64);
            this.btnPienempi.TabIndex = 4;
            this.btnPienempi.Text = "Tulosta pienempi";
            this.btnPienempi.UseVisualStyleBackColor = true;
            this.btnPienempi.Click += new System.EventHandler(this.btnPienempi_Click);
            // 
            // btnSuurempi
            // 
            this.btnSuurempi.Location = new System.Drawing.Point(187, 100);
            this.btnSuurempi.Name = "btnSuurempi";
            this.btnSuurempi.Size = new System.Drawing.Size(130, 60);
            this.btnSuurempi.TabIndex = 5;
            this.btnSuurempi.Text = "Tulosta suurempi";
            this.btnSuurempi.UseVisualStyleBackColor = true;
            this.btnSuurempi.Click += new System.EventHandler(this.btnSuurempi_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.VastausL.Location = new System.Drawing.Point(331, 59);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(28, 22);
            this.VastausL.TabIndex = 6;
            this.VastausL.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.btnSuurempi);
            this.Controls.Add(this.btnPienempi);
            this.Controls.Add(this.Luku2L);
            this.Controls.Add(this.Luku1L);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Luku1L;
        private System.Windows.Forms.Label Luku2L;
        private System.Windows.Forms.Button btnPienempi;
        private System.Windows.Forms.Button btnSuurempi;
        private System.Windows.Forms.Label VastausL;
    }
}


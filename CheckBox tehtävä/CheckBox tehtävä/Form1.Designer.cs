namespace CheckBox_tehtävä
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
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(50, 82);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(69, 24);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "Kalle";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(50, 123);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(64, 24);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "Ville";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(50, 173);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(70, 24);
            this.CheckBox3.TabIndex = 2;
            this.CheckBox3.Text = "Matti";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Location = new System.Drawing.Point(50, 223);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(78, 24);
            this.CheckBox4.TabIndex = 3;
            this.CheckBox4.Text = "Minna";
            this.CheckBox4.UseVisualStyleBackColor = true;
            // 
            // CheckBox5
            // 
            this.CheckBox5.AutoSize = true;
            this.CheckBox5.Location = new System.Drawing.Point(50, 273);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(80, 24);
            this.CheckBox5.TabIndex = 4;
            this.CheckBox5.Text = "Leena";
            this.CheckBox5.UseVisualStyleBackColor = true;
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(50, 326);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(104, 24);
            this.CheckBox6.TabIndex = 5;
            this.CheckBox6.Text = "Pirkkoliisa";
            this.CheckBox6.UseVisualStyleBackColor = true;
            // 
            // CheckBox7
            // 
            this.CheckBox7.AutoSize = true;
            this.CheckBox7.Location = new System.Drawing.Point(50, 380);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(67, 24);
            this.CheckBox7.TabIndex = 6;
            this.CheckBox7.Text = "Liisa";
            this.CheckBox7.UseVisualStyleBackColor = true;
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(50, 430);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(92, 32);
            this.btnTulosta.TabIndex = 7;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.btnTulosta_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic);
            this.txtVastaus.Location = new System.Drawing.Point(274, 82);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVastaus.Size = new System.Drawing.Size(297, 380);
            this.txtVastaus.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 571);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.CheckBox7);
            this.Controls.Add(this.CheckBox6);
            this.Controls.Add(this.CheckBox5);
            this.Controls.Add(this.CheckBox4);
            this.Controls.Add(this.CheckBox3);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.CheckBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox4;
        private System.Windows.Forms.CheckBox CheckBox5;
        private System.Windows.Forms.CheckBox CheckBox6;
        private System.Windows.Forms.CheckBox CheckBox7;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


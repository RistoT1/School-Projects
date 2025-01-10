namespace Ikä_ja_nimi
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
            this.txt1 = new System.Windows.Forms.Label();
            this.Btnok = new System.Windows.Forms.Button();
            this.txtIka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(60, 26);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(74, 20);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Syötä ikä";
            // 
            // Btnok
            // 
            this.Btnok.Location = new System.Drawing.Point(64, 123);
            this.Btnok.Name = "Btnok";
            this.Btnok.Size = new System.Drawing.Size(87, 33);
            this.Btnok.TabIndex = 1;
            this.Btnok.Text = "OK";
            this.Btnok.UseVisualStyleBackColor = true;
            this.Btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // txtIka
            // 
            this.txtIka.Location = new System.Drawing.Point(64, 81);
            this.txtIka.Name = "txtIka";
            this.txtIka.Size = new System.Drawing.Size(100, 26);
            this.txtIka.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIka);
            this.Controls.Add(this.Btnok);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Button Btnok;
        private System.Windows.Forms.TextBox txtIka;
    }
}


namespace kertotaulu
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
            this.LukuL = new System.Windows.Forms.Label();
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.BtnJatka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuL
            // 
            this.LukuL.AutoSize = true;
            this.LukuL.Location = new System.Drawing.Point(37, 27);
            this.LukuL.Name = "LukuL";
            this.LukuL.Size = new System.Drawing.Size(83, 20);
            this.LukuL.TabIndex = 0;
            this.LukuL.Text = "Syötä luku";
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(41, 62);
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(100, 26);
            this.txtLuku.TabIndex = 1;
            // 
            // BtnJatka
            // 
            this.BtnJatka.Location = new System.Drawing.Point(170, 55);
            this.BtnJatka.Name = "BtnJatka";
            this.BtnJatka.Size = new System.Drawing.Size(88, 41);
            this.BtnJatka.TabIndex = 2;
            this.BtnJatka.Text = "Jatka";
            this.BtnJatka.UseVisualStyleBackColor = true;
            this.BtnJatka.Click += new System.EventHandler(this.BtnJatka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnJatka);
            this.Controls.Add(this.txtLuku);
            this.Controls.Add(this.LukuL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LukuL;
        private System.Windows.Forms.TextBox txtLuku;
        private System.Windows.Forms.Button BtnJatka;
    }
}


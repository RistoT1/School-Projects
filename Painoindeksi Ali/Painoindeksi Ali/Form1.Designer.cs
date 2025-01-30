namespace Painoindeksi_Ali
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
            this.PainoL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtPaino = new System.Windows.Forms.TextBox();
            this.Pi = new System.Windows.Forms.Label();
            this.txtPituus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PainoL
            // 
            this.PainoL.AutoSize = true;
            this.PainoL.Location = new System.Drawing.Point(46, 32);
            this.PainoL.Name = "PainoL";
            this.PainoL.Size = new System.Drawing.Size(49, 20);
            this.PainoL.TabIndex = 0;
            this.PainoL.Text = "Paino";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(50, 123);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(95, 40);
            this.btnJatka.TabIndex = 1;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtPaino
            // 
            this.txtPaino.Location = new System.Drawing.Point(50, 72);
            this.txtPaino.Name = "txtPaino";
            this.txtPaino.Size = new System.Drawing.Size(127, 26);
            this.txtPaino.TabIndex = 2;
            // 
            // Pi
            // 
            this.Pi.AutoSize = true;
            this.Pi.Location = new System.Drawing.Point(231, 32);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(53, 20);
            this.Pi.TabIndex = 3;
            this.Pi.Text = "Pituus";
            // 
            // txtPituus
            // 
            this.txtPituus.Location = new System.Drawing.Point(235, 72);
            this.txtPituus.Name = "txtPituus";
            this.txtPituus.Size = new System.Drawing.Size(127, 26);
            this.txtPituus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPituus);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.txtPaino);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.PainoL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PainoL;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtPaino;
        private System.Windows.Forms.Label Pi;
        private System.Windows.Forms.TextBox txtPituus;
    }
}


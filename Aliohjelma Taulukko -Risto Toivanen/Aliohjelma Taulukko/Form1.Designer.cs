namespace Aliohjelma_Taulukko
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
            this.txtTaulukko = new System.Windows.Forms.TextBox();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaulukko
            // 
            this.txtTaulukko.Location = new System.Drawing.Point(37, 31);
            this.txtTaulukko.Multiline = true;
            this.txtTaulukko.Name = "txtTaulukko";
            this.txtTaulukko.ReadOnly = true;
            this.txtTaulukko.Size = new System.Drawing.Size(241, 175);
            this.txtTaulukko.TabIndex = 0;
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(47, 261);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(231, 65);
            this.btnTulosta.TabIndex = 1;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.txtTaulukko);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaulukko;
        private System.Windows.Forms.Button btnTulosta;
    }
}


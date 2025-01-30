namespace Bmi_Olio_ohjelmalla
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
            this.txtPituus = new System.Windows.Forms.TextBox();
            this.txtPaino = new System.Windows.Forms.TextBox();
            this.PituusL = new System.Windows.Forms.Label();
            this.PainoL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPituus
            // 
            this.txtPituus.Location = new System.Drawing.Point(34, 79);
            this.txtPituus.Name = "txtPituus";
            this.txtPituus.Size = new System.Drawing.Size(100, 26);
            this.txtPituus.TabIndex = 0;
            // 
            // txtPaino
            // 
            this.txtPaino.Location = new System.Drawing.Point(178, 79);
            this.txtPaino.Name = "txtPaino";
            this.txtPaino.Size = new System.Drawing.Size(100, 26);
            this.txtPaino.TabIndex = 1;
            // 
            // PituusL
            // 
            this.PituusL.AutoSize = true;
            this.PituusL.Location = new System.Drawing.Point(34, 39);
            this.PituusL.Name = "PituusL";
            this.PituusL.Size = new System.Drawing.Size(53, 20);
            this.PituusL.TabIndex = 2;
            this.PituusL.Text = "Pituus";
            // 
            // PainoL
            // 
            this.PainoL.AutoSize = true;
            this.PainoL.Location = new System.Drawing.Point(174, 39);
            this.PainoL.Name = "PainoL";
            this.PainoL.Size = new System.Drawing.Size(49, 20);
            this.PainoL.TabIndex = 3;
            this.PainoL.Text = "Paino";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(38, 130);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(96, 37);
            this.btnJatka.TabIndex = 4;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(178, 130);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(157, 54);
            this.txtVastaus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.PainoL);
            this.Controls.Add(this.PituusL);
            this.Controls.Add(this.txtPaino);
            this.Controls.Add(this.txtPituus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPituus;
        private System.Windows.Forms.TextBox txtPaino;
        private System.Windows.Forms.Label PituusL;
        private System.Windows.Forms.Label PainoL;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


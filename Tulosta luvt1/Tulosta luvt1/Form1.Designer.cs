namespace Tulosta_luvt1
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
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.lukuL = new System.Windows.Forms.Label();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(318, 49);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(102, 37);
            this.btnJatka.TabIndex = 0;
            this.btnJatka.Text = "Muuta";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(203, 49);
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(100, 26);
            this.txtLuku.TabIndex = 1;
            // 
            // lukuL
            // 
            this.lukuL.AutoSize = true;
            this.lukuL.Location = new System.Drawing.Point(93, 49);
            this.lukuL.Name = "lukuL";
            this.lukuL.Size = new System.Drawing.Size(89, 20);
            this.lukuL.TabIndex = 2;
            this.lukuL.Text = "Syötä Luku";
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(97, 92);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVastaus.Size = new System.Drawing.Size(348, 352);
            this.txtVastaus.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.lukuL);
            this.Controls.Add(this.txtLuku);
            this.Controls.Add(this.btnJatka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtLuku;
        private System.Windows.Forms.Label lukuL;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


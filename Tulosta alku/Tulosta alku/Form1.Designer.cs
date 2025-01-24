namespace Tulosta_alku
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
            this.SanaL = new System.Windows.Forms.Label();
            this.txtSyote = new System.Windows.Forms.TextBox();
            this.btnJatka = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SanaL
            // 
            this.SanaL.AutoSize = true;
            this.SanaL.Location = new System.Drawing.Point(43, 24);
            this.SanaL.Name = "SanaL";
            this.SanaL.Size = new System.Drawing.Size(89, 20);
            this.SanaL.TabIndex = 0;
            this.SanaL.Text = "Syötä sana";
            // 
            // txtSyote
            // 
            this.txtSyote.Location = new System.Drawing.Point(47, 63);
            this.txtSyote.Name = "txtSyote";
            this.txtSyote.Size = new System.Drawing.Size(100, 26);
            this.txtSyote.TabIndex = 1;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(48, 108);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(99, 40);
            this.btnJatka.TabIndex = 2;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(177, 64);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(177, 108);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(135, 101);
            this.txtVastaus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.txtSyote);
            this.Controls.Add(this.SanaL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SanaL;
        private System.Windows.Forms.TextBox txtSyote;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


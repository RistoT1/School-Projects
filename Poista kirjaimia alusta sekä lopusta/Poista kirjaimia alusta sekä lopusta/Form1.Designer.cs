namespace Poista_kirjaimia_alusta_sekä_lopusta
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
            this.sanaL = new System.Windows.Forms.Label();
            this.txtSana = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sanaL
            // 
            this.sanaL.AutoSize = true;
            this.sanaL.Location = new System.Drawing.Point(39, 24);
            this.sanaL.Name = "sanaL";
            this.sanaL.Size = new System.Drawing.Size(44, 20);
            this.sanaL.TabIndex = 0;
            this.sanaL.Text = "sana";
            // 
            // txtSana
            // 
            this.txtSana.Location = new System.Drawing.Point(43, 58);
            this.txtSana.Name = "txtSana";
            this.txtSana.Size = new System.Drawing.Size(100, 26);
            this.txtSana.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jatka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(160, 57);
            this.txtLuku.MaxLength = 100;
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(38, 26);
            this.txtLuku.TabIndex = 3;
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(43, 103);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(281, 181);
            this.txtVastaus.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.txtLuku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSana);
            this.Controls.Add(this.sanaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sanaL;
        private System.Windows.Forms.TextBox txtSana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLuku;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


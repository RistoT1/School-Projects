namespace Kartoin
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
            this.sadeL = new System.Windows.Forms.Label();
            this.KorkeusL = new System.Windows.Forms.Label();
            this.txtSade = new System.Windows.Forms.TextBox();
            this.txtKorkeus = new System.Windows.Forms.TextBox();
            this.VastausL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sadeL
            // 
            this.sadeL.AutoSize = true;
            this.sadeL.Location = new System.Drawing.Point(33, 35);
            this.sadeL.Name = "sadeL";
            this.sadeL.Size = new System.Drawing.Size(97, 20);
            this.sadeL.TabIndex = 0;
            this.sadeL.Text = "Pohjan säde";
            // 
            // KorkeusL
            // 
            this.KorkeusL.AutoSize = true;
            this.KorkeusL.Location = new System.Drawing.Point(254, 35);
            this.KorkeusL.Name = "KorkeusL";
            this.KorkeusL.Size = new System.Drawing.Size(67, 20);
            this.KorkeusL.TabIndex = 1;
            this.KorkeusL.Text = "Korkeus";
            this.KorkeusL.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSade
            // 
            this.txtSade.Location = new System.Drawing.Point(37, 74);
            this.txtSade.Name = "txtSade";
            this.txtSade.Size = new System.Drawing.Size(100, 26);
            this.txtSade.TabIndex = 2;
            // 
            // txtKorkeus
            // 
            this.txtKorkeus.Location = new System.Drawing.Point(258, 74);
            this.txtKorkeus.Name = "txtKorkeus";
            this.txtKorkeus.Size = new System.Drawing.Size(100, 26);
            this.txtKorkeus.TabIndex = 3;
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.VastausL.Location = new System.Drawing.Point(402, 76);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(28, 22);
            this.VastausL.TabIndex = 4;
            this.VastausL.Text = "---";
            this.VastausL.Click += new System.EventHandler(this.Vastaus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.txtKorkeus);
            this.Controls.Add(this.txtSade);
            this.Controls.Add(this.KorkeusL);
            this.Controls.Add(this.sadeL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sadeL;
        private System.Windows.Forms.Label KorkeusL;
        private System.Windows.Forms.TextBox txtSade;
        private System.Windows.Forms.TextBox txtKorkeus;
        private System.Windows.Forms.Label VastausL;
    }
}


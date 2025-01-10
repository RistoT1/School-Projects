namespace hello_nimi
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
            this.Syotanimi = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.Jatka = new System.Windows.Forms.Button();
            this.txtVaara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Syotanimi
            // 
            this.Syotanimi.AutoSize = true;
            this.Syotanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Syotanimi.Location = new System.Drawing.Point(61, 27);
            this.Syotanimi.Name = "Syotanimi";
            this.Syotanimi.Size = new System.Drawing.Size(177, 32);
            this.Syotanimi.TabIndex = 0;
            this.Syotanimi.Text = "Syötä nimesi";
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(67, 87);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(108, 26);
            this.txtNimi.TabIndex = 1;
            // 
            // Jatka
            // 
            this.Jatka.Location = new System.Drawing.Point(67, 150);
            this.Jatka.Name = "Jatka";
            this.Jatka.Size = new System.Drawing.Size(91, 35);
            this.Jatka.TabIndex = 2;
            this.Jatka.Text = "Jatka";
            this.Jatka.UseVisualStyleBackColor = true;
            this.Jatka.Click += new System.EventHandler(this.Jatka_Click);
            // 
            // txtVaara
            // 
            this.txtVaara.AutoSize = true;
            this.txtVaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtVaara.Location = new System.Drawing.Point(67, 116);
            this.txtVaara.Name = "txtVaara";
            this.txtVaara.Size = new System.Drawing.Size(155, 17);
            this.txtVaara.TabIndex = 3;
            this.txtVaara.Text = "Syötä yli kolme merkkiä";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVaara);
            this.Controls.Add(this.Jatka);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.Syotanimi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Syotanimi;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Button Jatka;
        private System.Windows.Forms.Label txtVaara;
    }
}


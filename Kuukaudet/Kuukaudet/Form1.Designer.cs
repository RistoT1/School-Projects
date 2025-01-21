namespace Kuukaudet
{
    partial class Kuukaudet
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
            this.numeroL = new System.Windows.Forms.Label();
            this.txtKuukausi = new System.Windows.Forms.TextBox();
            this.Jatka = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeroL
            // 
            this.numeroL.AutoSize = true;
            this.numeroL.Location = new System.Drawing.Point(36, 36);
            this.numeroL.Name = "numeroL";
            this.numeroL.Size = new System.Drawing.Size(149, 20);
            this.numeroL.TabIndex = 0;
            this.numeroL.Text = "Kuudauden numero";
            // 
            // txtKuukausi
            // 
            this.txtKuukausi.Location = new System.Drawing.Point(40, 75);
            this.txtKuukausi.Name = "txtKuukausi";
            this.txtKuukausi.Size = new System.Drawing.Size(100, 26);
            this.txtKuukausi.TabIndex = 1;
            // 
            // Jatka
            // 
            this.Jatka.Location = new System.Drawing.Point(40, 125);
            this.Jatka.Name = "Jatka";
            this.Jatka.Size = new System.Drawing.Size(85, 29);
            this.Jatka.TabIndex = 2;
            this.Jatka.Text = "Jatka";
            this.Jatka.UseVisualStyleBackColor = true;
            this.Jatka.Click += new System.EventHandler(this.Jatka_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(180, 75);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 3;
            this.VastausL.Text = "---";
            // 
            // Kuukaudet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.Jatka);
            this.Controls.Add(this.txtKuukausi);
            this.Controls.Add(this.numeroL);
            this.Name = "Kuukaudet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroL;
        private System.Windows.Forms.TextBox txtKuukausi;
        private System.Windows.Forms.Button Jatka;
        private System.Windows.Forms.Label VastausL;
    }
}


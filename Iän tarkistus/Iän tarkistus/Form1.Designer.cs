namespace Iän_tarkistus
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
            this.ikaL = new System.Windows.Forms.Label();
            this.Jatka = new System.Windows.Forms.Button();
            this.txtika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ikaL
            // 
            this.ikaL.AutoSize = true;
            this.ikaL.Location = new System.Drawing.Point(37, 42);
            this.ikaL.Name = "ikaL";
            this.ikaL.Size = new System.Drawing.Size(69, 20);
            this.ikaL.TabIndex = 0;
            this.ikaL.Text = "anna ikä";
            // 
            // Jatka
            // 
            this.Jatka.Location = new System.Drawing.Point(41, 121);
            this.Jatka.Name = "Jatka";
            this.Jatka.Size = new System.Drawing.Size(82, 29);
            this.Jatka.TabIndex = 1;
            this.Jatka.Text = "Jatka";
            this.Jatka.UseVisualStyleBackColor = true;
            this.Jatka.Click += new System.EventHandler(this.Jatka_Click);
            // 
            // txtika
            // 
            this.txtika.Location = new System.Drawing.Point(41, 82);
            this.txtika.Name = "txtika";
            this.txtika.Size = new System.Drawing.Size(100, 26);
            this.txtika.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtika);
            this.Controls.Add(this.Jatka);
            this.Controls.Add(this.ikaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ikaL;
        private System.Windows.Forms.Button Jatka;
        private System.Windows.Forms.TextBox txtika;
    }
}


namespace ohjelmointi_testi
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
            this.rahatL = new System.Windows.Forms.Label();
            this.txtRahamaara = new System.Windows.Forms.TextBox();
            this.btnJatka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rahatL
            // 
            this.rahatL.AutoSize = true;
            this.rahatL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rahatL.Location = new System.Drawing.Point(36, 31);
            this.rahatL.Name = "rahatL";
            this.rahatL.Size = new System.Drawing.Size(153, 22);
            this.rahatL.TabIndex = 0;
            this.rahatL.Text = "Anna raha määrä!";
            // 
            // txtRahamaara
            // 
            this.txtRahamaara.Location = new System.Drawing.Point(40, 72);
            this.txtRahamaara.Name = "txtRahamaara";
            this.txtRahamaara.Size = new System.Drawing.Size(149, 26);
            this.txtRahamaara.TabIndex = 1;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(197, 66);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(85, 39);
            this.btnJatka.TabIndex = 2;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.txtRahamaara);
            this.Controls.Add(this.rahatL);
            this.Name = "Form1";
            this.Text = "Pitsalle!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rahatL;
        private System.Windows.Forms.TextBox txtRahamaara;
        private System.Windows.Forms.Button btnJatka;
    }
}


namespace kertymä
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
            this.txtLukumaara = new System.Windows.Forms.TextBox();
            this.kierrosL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLukumaara
            // 
            this.txtLukumaara.Location = new System.Drawing.Point(43, 59);
            this.txtLukumaara.Name = "txtLukumaara";
            this.txtLukumaara.Size = new System.Drawing.Size(205, 26);
            this.txtLukumaara.TabIndex = 0;
            // 
            // kierrosL
            // 
            this.kierrosL.AutoSize = true;
            this.kierrosL.Location = new System.Drawing.Point(39, 24);
            this.kierrosL.Name = "kierrosL";
            this.kierrosL.Size = new System.Drawing.Size(208, 20);
            this.kierrosL.TabIndex = 1;
            this.kierrosL.Text = "Syötä kierroksien lukumäärä";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(287, 49);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(95, 44);
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
            this.Controls.Add(this.kierrosL);
            this.Controls.Add(this.txtLukumaara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLukumaara;
        private System.Windows.Forms.Label kierrosL;
        private System.Windows.Forms.Button btnJatka;
    }
}


namespace Kirjaimen_esiintyminen
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
            this.txtSana = new System.Windows.Forms.TextBox();
            this.txtKirjain = new System.Windows.Forms.TextBox();
            this.btnJatka = new System.Windows.Forms.Button();
            this.KirjainL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SanaL
            // 
            this.SanaL.AutoSize = true;
            this.SanaL.Location = new System.Drawing.Point(30, 42);
            this.SanaL.Name = "SanaL";
            this.SanaL.Size = new System.Drawing.Size(89, 20);
            this.SanaL.TabIndex = 0;
            this.SanaL.Text = "Syötä sana";
            // 
            // txtSana
            // 
            this.txtSana.Location = new System.Drawing.Point(34, 79);
            this.txtSana.Name = "txtSana";
            this.txtSana.Size = new System.Drawing.Size(100, 26);
            this.txtSana.TabIndex = 1;
            // 
            // txtKirjain
            // 
            this.txtKirjain.Location = new System.Drawing.Point(158, 79);
            this.txtKirjain.MaxLength = 1;
            this.txtKirjain.Name = "txtKirjain";
            this.txtKirjain.Size = new System.Drawing.Size(39, 26);
            this.txtKirjain.TabIndex = 2;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(34, 123);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(100, 38);
            this.btnJatka.TabIndex = 3;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // KirjainL
            // 
            this.KirjainL.AutoSize = true;
            this.KirjainL.Location = new System.Drawing.Point(154, 42);
            this.KirjainL.Name = "KirjainL";
            this.KirjainL.Size = new System.Drawing.Size(49, 20);
            this.KirjainL.TabIndex = 4;
            this.KirjainL.Text = "kirjain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KirjainL);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.txtKirjain);
            this.Controls.Add(this.txtSana);
            this.Controls.Add(this.SanaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SanaL;
        private System.Windows.Forms.TextBox txtSana;
        private System.Windows.Forms.TextBox txtKirjain;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.Label KirjainL;
    }
}


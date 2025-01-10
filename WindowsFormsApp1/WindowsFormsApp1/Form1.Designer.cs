namespace WindowsFormsApp1
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
            this.Jatka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.txtVaara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jatka
            // 
            this.Jatka.Location = new System.Drawing.Point(44, 147);
            this.Jatka.Name = "Jatka";
            this.Jatka.Size = new System.Drawing.Size(98, 40);
            this.Jatka.TabIndex = 0;
            this.Jatka.Text = "Jatka";
            this.Jatka.UseVisualStyleBackColor = true;
            this.Jatka.Click += new System.EventHandler(this.Jatka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nimi";
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(44, 89);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(100, 26);
            this.txtNimi.TabIndex = 2;
            this.txtNimi.TextChanged += new System.EventHandler(this.txtNimi_TextChanged);
            // 
            // txtVaara
            // 
            this.txtVaara.AutoSize = true;
            this.txtVaara.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtVaara.Location = new System.Drawing.Point(40, 118);
            this.txtVaara.Name = "txtVaara";
            this.txtVaara.Size = new System.Drawing.Size(200, 20);
            this.txtVaara.TabIndex = 3;
            this.txtVaara.Text = "Kirjoita vähintään 3 kirjainta";
            this.txtVaara.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVaara);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jatka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Jatka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Label txtVaara;
    }
}


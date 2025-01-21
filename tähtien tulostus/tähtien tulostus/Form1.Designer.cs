namespace tähtien_tulostus
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
            this.LukuL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtluku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LukuL
            // 
            this.LukuL.AutoSize = true;
            this.LukuL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LukuL.Location = new System.Drawing.Point(40, 24);
            this.LukuL.Name = "LukuL";
            this.LukuL.Size = new System.Drawing.Size(130, 25);
            this.LukuL.TabIndex = 0;
            this.LukuL.Text = "tähtien määrä";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(171, 59);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(90, 34);
            this.btnJatka.TabIndex = 1;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtluku
            // 
            this.txtluku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtluku.Location = new System.Drawing.Point(35, 59);
            this.txtluku.Name = "txtluku";
            this.txtluku.Size = new System.Drawing.Size(100, 26);
            this.txtluku.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtluku);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.LukuL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LukuL;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtluku;
    }
}


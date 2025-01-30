namespace Merkkijono
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
            this.txtArvosana = new System.Windows.Forms.TextBox();
            this.ArvosanaL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArvosana
            // 
            this.txtArvosana.Location = new System.Drawing.Point(49, 45);
            this.txtArvosana.Name = "txtArvosana";
            this.txtArvosana.Size = new System.Drawing.Size(100, 26);
            this.txtArvosana.TabIndex = 0;
            // 
            // ArvosanaL
            // 
            this.ArvosanaL.AutoSize = true;
            this.ArvosanaL.Location = new System.Drawing.Point(49, 13);
            this.ArvosanaL.Name = "ArvosanaL";
            this.ArvosanaL.Size = new System.Drawing.Size(119, 20);
            this.ArvosanaL.TabIndex = 1;
            this.ArvosanaL.Text = "Syötä arvosana";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(49, 86);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(100, 51);
            this.btnJatka.TabIndex = 2;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(199, 45);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 3;
            this.VastausL.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.ArvosanaL);
            this.Controls.Add(this.txtArvosana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArvosana;
        private System.Windows.Forms.Label ArvosanaL;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.Label VastausL;
    }
}


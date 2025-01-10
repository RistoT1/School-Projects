namespace Celsius_muunnin
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
            this.FahreinheitL = new System.Windows.Forms.Label();
            this.CelsiusL = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.Laske = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FahreinheitL
            // 
            this.FahreinheitL.AutoSize = true;
            this.FahreinheitL.Location = new System.Drawing.Point(34, 30);
            this.FahreinheitL.Name = "FahreinheitL";
            this.FahreinheitL.Size = new System.Drawing.Size(89, 20);
            this.FahreinheitL.TabIndex = 0;
            this.FahreinheitL.Text = "Fahreinheit";
            // 
            // CelsiusL
            // 
            this.CelsiusL.AutoSize = true;
            this.CelsiusL.Location = new System.Drawing.Point(193, 30);
            this.CelsiusL.Name = "CelsiusL";
            this.CelsiusL.Size = new System.Drawing.Size(60, 20);
            this.CelsiusL.TabIndex = 1;
            this.CelsiusL.Text = "Celsius";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(38, 67);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 26);
            this.txtF.TabIndex = 2;
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(45, 118);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(93, 40);
            this.Laske.TabIndex = 4;
            this.Laske.Text = "Vaihda";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(210, 67);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 5;
            this.VastausL.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.CelsiusL);
            this.Controls.Add(this.FahreinheitL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FahreinheitL;
        private System.Windows.Forms.Label CelsiusL;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.Label VastausL;
    }
}


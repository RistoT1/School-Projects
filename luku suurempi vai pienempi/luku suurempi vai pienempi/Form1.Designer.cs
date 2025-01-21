namespace luku_suurempi_vai_pienempi
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
            this.Laske = new System.Windows.Forms.Button();
            this.LukuL = new System.Windows.Forms.Label();
            this.VastausL = new System.Windows.Forms.Label();
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(37, 139);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(100, 37);
            this.Laske.TabIndex = 0;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // LukuL
            // 
            this.LukuL.AutoSize = true;
            this.LukuL.Location = new System.Drawing.Point(33, 45);
            this.LukuL.Name = "LukuL";
            this.LukuL.Size = new System.Drawing.Size(80, 20);
            this.LukuL.TabIndex = 1;
            this.LukuL.Text = "Anna luku";
            this.LukuL.Click += new System.EventHandler(this.label1_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(188, 90);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 2;
            this.VastausL.Text = "---";
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(37, 90);
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(100, 26);
            this.txtLuku.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLuku);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.LukuL);
            this.Controls.Add(this.Laske);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.Label LukuL;
        private System.Windows.Forms.Label VastausL;
        private System.Windows.Forms.TextBox txtLuku;
    }
}


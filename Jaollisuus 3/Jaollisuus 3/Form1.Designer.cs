namespace Jaollisuus_3
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
            this.txtLuku = new System.Windows.Forms.TextBox();
            this.LukuL = new System.Windows.Forms.Label();
            this.btnLaske = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLuku
            // 
            this.txtLuku.Location = new System.Drawing.Point(74, 73);
            this.txtLuku.Name = "txtLuku";
            this.txtLuku.Size = new System.Drawing.Size(100, 26);
            this.txtLuku.TabIndex = 0;
            // 
            // LukuL
            // 
            this.LukuL.AutoSize = true;
            this.LukuL.Location = new System.Drawing.Point(74, 27);
            this.LukuL.Name = "LukuL";
            this.LukuL.Size = new System.Drawing.Size(80, 20);
            this.LukuL.TabIndex = 1;
            this.LukuL.Text = "syötä luku";
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(216, 73);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(88, 35);
            this.btnLaske.TabIndex = 2;
            this.btnLaske.Text = "Laske";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btnLaske_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaske);
            this.Controls.Add(this.LukuL);
            this.Controls.Add(this.txtLuku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLuku;
        private System.Windows.Forms.Label LukuL;
        private System.Windows.Forms.Button btnLaske;
    }
}


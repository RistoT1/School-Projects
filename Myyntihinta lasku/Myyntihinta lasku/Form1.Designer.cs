namespace Myyntihinta_lasku
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
            this.HintaL = new System.Windows.Forms.Label();
            this.txthinta = new System.Windows.Forms.TextBox();
            this.Laske = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.hintaarvL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HintaL
            // 
            this.HintaL.AutoSize = true;
            this.HintaL.Location = new System.Drawing.Point(44, 33);
            this.HintaL.Name = "HintaL";
            this.HintaL.Size = new System.Drawing.Size(112, 20);
            this.HintaL.TabIndex = 0;
            this.HintaL.Text = "Tuotteen hinta";
            // 
            // txthinta
            // 
            this.txthinta.Location = new System.Drawing.Point(48, 76);
            this.txthinta.Name = "txthinta";
            this.txthinta.Size = new System.Drawing.Size(100, 26);
            this.txthinta.TabIndex = 1;
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(48, 133);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(100, 37);
            this.Laske.TabIndex = 2;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(208, 81);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 3;
            this.VastausL.Text = "---";
            // 
            // hintaarvL
            // 
            this.hintaarvL.AutoSize = true;
            this.hintaarvL.Location = new System.Drawing.Point(212, 117);
            this.hintaarvL.Name = "hintaarvL";
            this.hintaarvL.Size = new System.Drawing.Size(24, 20);
            this.hintaarvL.TabIndex = 4;
            this.hintaarvL.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hintaarvL);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.txthinta);
            this.Controls.Add(this.HintaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HintaL;
        private System.Windows.Forms.TextBox txthinta;
        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.Label VastausL;
        private System.Windows.Forms.Label hintaarvL;
    }
}


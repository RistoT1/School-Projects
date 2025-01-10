namespace Keskiarvo
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
            this.luku1 = new System.Windows.Forms.Label();
            this.Luku3 = new System.Windows.Forms.Label();
            this.Luku2 = new System.Windows.Forms.Label();
            this.txtLuku1 = new System.Windows.Forms.TextBox();
            this.txtLuku3 = new System.Windows.Forms.TextBox();
            this.txtLuku2 = new System.Windows.Forms.TextBox();
            this.Laske = new System.Windows.Forms.Button();
            this.Vastaus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luku1
            // 
            this.luku1.AutoSize = true;
            this.luku1.Location = new System.Drawing.Point(36, 30);
            this.luku1.Name = "luku1";
            this.luku1.Size = new System.Drawing.Size(47, 20);
            this.luku1.TabIndex = 0;
            this.luku1.Text = "luku1";
            // 
            // Luku3
            // 
            this.Luku3.AutoSize = true;
            this.Luku3.Location = new System.Drawing.Point(233, 30);
            this.Luku3.Name = "Luku3";
            this.Luku3.Size = new System.Drawing.Size(53, 20);
            this.Luku3.TabIndex = 1;
            this.Luku3.Text = "Luku3";
            // 
            // Luku2
            // 
            this.Luku2.AutoSize = true;
            this.Luku2.Location = new System.Drawing.Point(127, 30);
            this.Luku2.Name = "Luku2";
            this.Luku2.Size = new System.Drawing.Size(53, 20);
            this.Luku2.TabIndex = 2;
            this.Luku2.Text = "Luku2";
            // 
            // txtLuku1
            // 
            this.txtLuku1.Location = new System.Drawing.Point(40, 74);
            this.txtLuku1.Name = "txtLuku1";
            this.txtLuku1.Size = new System.Drawing.Size(43, 26);
            this.txtLuku1.TabIndex = 3;
            // 
            // txtLuku3
            // 
            this.txtLuku3.Location = new System.Drawing.Point(237, 74);
            this.txtLuku3.Name = "txtLuku3";
            this.txtLuku3.Size = new System.Drawing.Size(43, 26);
            this.txtLuku3.TabIndex = 4;
            // 
            // txtLuku2
            // 
            this.txtLuku2.Location = new System.Drawing.Point(131, 74);
            this.txtLuku2.Name = "txtLuku2";
            this.txtLuku2.Size = new System.Drawing.Size(43, 26);
            this.txtLuku2.TabIndex = 5;
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(91, 125);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(140, 35);
            this.Laske.TabIndex = 6;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // Vastaus
            // 
            this.Vastaus.AutoSize = true;
            this.Vastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Vastaus.Location = new System.Drawing.Point(332, 74);
            this.Vastaus.Name = "Vastaus";
            this.Vastaus.Size = new System.Drawing.Size(28, 22);
            this.Vastaus.TabIndex = 7;
            this.Vastaus.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vastaus);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.txtLuku2);
            this.Controls.Add(this.txtLuku3);
            this.Controls.Add(this.txtLuku1);
            this.Controls.Add(this.Luku2);
            this.Controls.Add(this.Luku3);
            this.Controls.Add(this.luku1);
            this.Name = "Form1";
            this.Text = "Keskiarvo laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luku1;
        private System.Windows.Forms.Label Luku3;
        private System.Windows.Forms.Label Luku2;
        private System.Windows.Forms.TextBox txtLuku1;
        private System.Windows.Forms.TextBox txtLuku3;
        private System.Windows.Forms.TextBox txtLuku2;
        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.Label Vastaus;
    }
}


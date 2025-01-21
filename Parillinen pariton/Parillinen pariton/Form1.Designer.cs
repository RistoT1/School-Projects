namespace Parillinen_pariton
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
            this.Luku1L = new System.Windows.Forms.Label();
            this.Luku2L = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnLaske = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.txtvastauspariton = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Luku1L
            // 
            this.Luku1L.AutoSize = true;
            this.Luku1L.Location = new System.Drawing.Point(32, 28);
            this.Luku1L.Name = "Luku1L";
            this.Luku1L.Size = new System.Drawing.Size(51, 20);
            this.Luku1L.TabIndex = 0;
            this.Luku1L.Text = "pienin";
            // 
            // Luku2L
            // 
            this.Luku2L.AutoSize = true;
            this.Luku2L.Location = new System.Drawing.Point(146, 28);
            this.Luku2L.Name = "Luku2L";
            this.Luku2L.Size = new System.Drawing.Size(52, 20);
            this.Luku2L.TabIndex = 1;
            this.Luku2L.Text = "suurin";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 68);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(150, 67);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 26);
            this.numericUpDown2.TabIndex = 3;
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(242, 61);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(83, 36);
            this.btnLaske.TabIndex = 4;
            this.btnLaske.Text = "Laske";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btnLaske_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(36, 120);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVastaus.Size = new System.Drawing.Size(289, 222);
            this.txtVastaus.TabIndex = 5;
            // 
            // txtvastauspariton
            // 
            this.txtvastauspariton.Location = new System.Drawing.Point(376, 120);
            this.txtvastauspariton.Multiline = true;
            this.txtvastauspariton.Name = "txtvastauspariton";
            this.txtvastauspariton.ReadOnly = true;
            this.txtvastauspariton.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtvastauspariton.Size = new System.Drawing.Size(289, 222);
            this.txtvastauspariton.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvastauspariton);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnLaske);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Luku2L);
            this.Controls.Add(this.Luku1L);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Luku1L;
        private System.Windows.Forms.Label Luku2L;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnLaske;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.TextBox txtvastauspariton;
    }
}


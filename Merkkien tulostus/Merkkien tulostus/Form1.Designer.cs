namespace Merkkien_tulostus
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
            this.btnEtuperin = new System.Windows.Forms.Button();
            this.btnTakaperin = new System.Windows.Forms.Button();
            this.txtSana = new System.Windows.Forms.TextBox();
            this.SanaL = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maaraL = new System.Windows.Forms.Label();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEtuperin
            // 
            this.btnEtuperin.Location = new System.Drawing.Point(38, 133);
            this.btnEtuperin.Name = "btnEtuperin";
            this.btnEtuperin.Size = new System.Drawing.Size(232, 35);
            this.btnEtuperin.TabIndex = 0;
            this.btnEtuperin.Text = "Tulosta etuperin";
            this.btnEtuperin.UseVisualStyleBackColor = true;
            this.btnEtuperin.Click += new System.EventHandler(this.btnEtuperin_Click);
            // 
            // btnTakaperin
            // 
            this.btnTakaperin.Location = new System.Drawing.Point(38, 184);
            this.btnTakaperin.Name = "btnTakaperin";
            this.btnTakaperin.Size = new System.Drawing.Size(232, 39);
            this.btnTakaperin.TabIndex = 1;
            this.btnTakaperin.Text = "Tulosta takaperin";
            this.btnTakaperin.UseVisualStyleBackColor = true;
            this.btnTakaperin.Click += new System.EventHandler(this.btnTakaperin_Click);
            // 
            // txtSana
            // 
            this.txtSana.Location = new System.Drawing.Point(38, 77);
            this.txtSana.Name = "txtSana";
            this.txtSana.Size = new System.Drawing.Size(232, 26);
            this.txtSana.TabIndex = 2;
            // 
            // SanaL
            // 
            this.SanaL.AutoSize = true;
            this.SanaL.Location = new System.Drawing.Point(38, 32);
            this.SanaL.Name = "SanaL";
            this.SanaL.Size = new System.Drawing.Size(100, 20);
            this.SanaL.TabIndex = 3;
            this.SanaL.Text = "Syötä sanasi";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 76);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maaraL
            // 
            this.maaraL.AutoSize = true;
            this.maaraL.Location = new System.Drawing.Point(294, 32);
            this.maaraL.Name = "maaraL";
            this.maaraL.Size = new System.Drawing.Size(125, 20);
            this.maaraL.TabIndex = 5;
            this.maaraL.Text = "Kirjaimien määrä";
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(298, 133);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(192, 125);
            this.txtVastaus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.maaraL);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SanaL);
            this.Controls.Add(this.txtSana);
            this.Controls.Add(this.btnTakaperin);
            this.Controls.Add(this.btnEtuperin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEtuperin;
        private System.Windows.Forms.Button btnTakaperin;
        private System.Windows.Forms.TextBox txtSana;
        private System.Windows.Forms.Label SanaL;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label maaraL;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


namespace Luku_arvaus
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
            this.ArvaaL = new System.Windows.Forms.Label();
            this.txtArvaa = new System.Windows.Forms.TextBox();
            this.Arvaa = new System.Windows.Forms.Button();
            this.vaarin = new System.Windows.Forms.Label();
            this.lukuLV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArvaaL
            // 
            this.ArvaaL.AutoSize = true;
            this.ArvaaL.Location = new System.Drawing.Point(37, 31);
            this.ArvaaL.Name = "ArvaaL";
            this.ArvaaL.Size = new System.Drawing.Size(83, 20);
            this.ArvaaL.TabIndex = 0;
            this.ArvaaL.Text = "Arvaa luku";
            // 
            // txtArvaa
            // 
            this.txtArvaa.Location = new System.Drawing.Point(41, 71);
            this.txtArvaa.Name = "txtArvaa";
            this.txtArvaa.Size = new System.Drawing.Size(100, 26);
            this.txtArvaa.TabIndex = 1;
            // 
            // Arvaa
            // 
            this.Arvaa.Location = new System.Drawing.Point(41, 126);
            this.Arvaa.Name = "Arvaa";
            this.Arvaa.Size = new System.Drawing.Size(100, 43);
            this.Arvaa.TabIndex = 2;
            this.Arvaa.Text = "Arvaa";
            this.Arvaa.UseVisualStyleBackColor = true;
            this.Arvaa.Click += new System.EventHandler(this.Arvaa_Click);
            // 
            // vaarin
            // 
            this.vaarin.AutoSize = true;
            this.vaarin.Location = new System.Drawing.Point(161, 71);
            this.vaarin.Name = "vaarin";
            this.vaarin.Size = new System.Drawing.Size(24, 20);
            this.vaarin.TabIndex = 3;
            this.vaarin.Text = "---";
            // 
            // lukuLV
            // 
            this.lukuLV.AutoSize = true;
            this.lukuLV.Location = new System.Drawing.Point(705, 421);
            this.lukuLV.Name = "lukuLV";
            this.lukuLV.Size = new System.Drawing.Size(83, 20);
            this.lukuLV.TabIndex = 4;
            this.lukuLV.Text = "Arvaa luku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lukuLV);
            this.Controls.Add(this.vaarin);
            this.Controls.Add(this.Arvaa);
            this.Controls.Add(this.txtArvaa);
            this.Controls.Add(this.ArvaaL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArvaaL;
        private System.Windows.Forms.TextBox txtArvaa;
        private System.Windows.Forms.Button Arvaa;
        private System.Windows.Forms.Label vaarin;
        private System.Windows.Forms.Label lukuLV;
    }
}


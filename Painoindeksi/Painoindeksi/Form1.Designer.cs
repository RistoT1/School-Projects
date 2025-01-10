namespace Painoindeksi
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
            this.painoL = new System.Windows.Forms.Label();
            this.pituusL = new System.Windows.Forms.Label();
            this.txtPaino = new System.Windows.Forms.TextBox();
            this.txtPituus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.indeksiL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VastausLU = new System.Windows.Forms.Label();
            this.indeksiLU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painoL
            // 
            this.painoL.AutoSize = true;
            this.painoL.Location = new System.Drawing.Point(236, 31);
            this.painoL.Name = "painoL";
            this.painoL.Size = new System.Drawing.Size(49, 20);
            this.painoL.TabIndex = 0;
            this.painoL.Text = "Paino";
            // 
            // pituusL
            // 
            this.pituusL.AutoSize = true;
            this.pituusL.Location = new System.Drawing.Point(92, 31);
            this.pituusL.Name = "pituusL";
            this.pituusL.Size = new System.Drawing.Size(53, 20);
            this.pituusL.TabIndex = 1;
            this.pituusL.Text = "Pituus";
            // 
            // txtPaino
            // 
            this.txtPaino.Location = new System.Drawing.Point(212, 85);
            this.txtPaino.Name = "txtPaino";
            this.txtPaino.Size = new System.Drawing.Size(100, 26);
            this.txtPaino.TabIndex = 2;
            // 
            // txtPituus
            // 
            this.txtPituus.Location = new System.Drawing.Point(69, 85);
            this.txtPituus.Name = "txtPituus";
            this.txtPituus.Size = new System.Drawing.Size(100, 26);
            this.txtPituus.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(354, 85);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 5;
            this.VastausL.Text = "---";
            // 
            // indeksiL
            // 
            this.indeksiL.AutoSize = true;
            this.indeksiL.Location = new System.Drawing.Point(354, 134);
            this.indeksiL.Name = "indeksiL";
            this.indeksiL.Size = new System.Drawing.Size(24, 20);
            this.indeksiL.TabIndex = 6;
            this.indeksiL.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "VanhaKaava";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "UusiKaava";
            // 
            // VastausLU
            // 
            this.VastausLU.AutoSize = true;
            this.VastausLU.Location = new System.Drawing.Point(354, 253);
            this.VastausLU.Name = "VastausLU";
            this.VastausLU.Size = new System.Drawing.Size(24, 20);
            this.VastausLU.TabIndex = 11;
            this.VastausLU.Text = "---";
            // 
            // indeksiLU
            // 
            this.indeksiLU.AutoSize = true;
            this.indeksiLU.Location = new System.Drawing.Point(354, 294);
            this.indeksiLU.Name = "indeksiLU";
            this.indeksiLU.Size = new System.Drawing.Size(24, 20);
            this.indeksiLU.TabIndex = 12;
            this.indeksiLU.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indeksiLU);
            this.Controls.Add(this.VastausLU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indeksiL);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPituus);
            this.Controls.Add(this.txtPaino);
            this.Controls.Add(this.pituusL);
            this.Controls.Add(this.painoL);
            this.Name = "Form1";
            this.Text = "PainoIndeksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label painoL;
        private System.Windows.Forms.Label pituusL;
        private System.Windows.Forms.TextBox txtPaino;
        private System.Windows.Forms.TextBox txtPituus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VastausL;
        private System.Windows.Forms.Label indeksiL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VastausLU;
        private System.Windows.Forms.Label indeksiLU;
    }
}


namespace Irtokarkit
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
            this.Kilo = new System.Windows.Forms.Label();
            this.Raha = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtRaha = new System.Windows.Forms.TextBox();
            this.Laske = new System.Windows.Forms.Button();
            this.karkkimääräL = new System.Windows.Forms.Label();
            this.karkkimääräkL = new System.Windows.Forms.Label();
            this.maara = new System.Windows.Forms.Label();
            this.euro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kilo
            // 
            this.Kilo.AutoSize = true;
            this.Kilo.Location = new System.Drawing.Point(20, 43);
            this.Kilo.Name = "Kilo";
            this.Kilo.Size = new System.Drawing.Size(69, 20);
            this.Kilo.TabIndex = 0;
            this.Kilo.Text = "Kilohinta";
            // 
            // Raha
            // 
            this.Raha.AutoSize = true;
            this.Raha.Location = new System.Drawing.Point(155, 43);
            this.Raha.Name = "Raha";
            this.Raha.Size = new System.Drawing.Size(93, 20);
            this.Raha.TabIndex = 1;
            this.Raha.Text = "Rahamäärä";
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(12, 86);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(84, 26);
            this.txtKilo.TabIndex = 2;
            // 
            // txtRaha
            // 
            this.txtRaha.Location = new System.Drawing.Point(159, 83);
            this.txtRaha.Name = "txtRaha";
            this.txtRaha.Size = new System.Drawing.Size(89, 26);
            this.txtRaha.TabIndex = 3;
            // 
            // Laske
            // 
            this.Laske.Location = new System.Drawing.Point(80, 131);
            this.Laske.Name = "Laske";
            this.Laske.Size = new System.Drawing.Size(99, 33);
            this.Laske.TabIndex = 4;
            this.Laske.Text = "Laske";
            this.Laske.UseVisualStyleBackColor = true;
            this.Laske.Click += new System.EventHandler(this.Laske_Click);
            // 
            // karkkimääräL
            // 
            this.karkkimääräL.AutoSize = true;
            this.karkkimääräL.Location = new System.Drawing.Point(294, 89);
            this.karkkimääräL.Name = "karkkimääräL";
            this.karkkimääräL.Size = new System.Drawing.Size(24, 20);
            this.karkkimääräL.TabIndex = 5;
            this.karkkimääräL.Text = "---";
            // 
            // karkkimääräkL
            // 
            this.karkkimääräkL.AutoSize = true;
            this.karkkimääräkL.Location = new System.Drawing.Point(294, 131);
            this.karkkimääräkL.Name = "karkkimääräkL";
            this.karkkimääräkL.Size = new System.Drawing.Size(24, 20);
            this.karkkimääräkL.TabIndex = 6;
            this.karkkimääräkL.Text = "---";
            // 
            // maara
            // 
            this.maara.AutoSize = true;
            this.maara.Location = new System.Drawing.Point(294, 43);
            this.maara.Name = "maara";
            this.maara.Size = new System.Drawing.Size(97, 20);
            this.maara.TabIndex = 7;
            this.maara.Text = "Karkkimäärä";
            // 
            // euro
            // 
            this.euro.AutoSize = true;
            this.euro.Location = new System.Drawing.Point(245, 86);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(18, 20);
            this.euro.TabIndex = 8;
            this.euro.Text = "€";
            this.euro.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "kg/€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.euro);
            this.Controls.Add(this.maara);
            this.Controls.Add(this.karkkimääräkL);
            this.Controls.Add(this.karkkimääräL);
            this.Controls.Add(this.Laske);
            this.Controls.Add(this.txtRaha);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.Raha);
            this.Controls.Add(this.Kilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kilo;
        private System.Windows.Forms.Label Raha;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtRaha;
        private System.Windows.Forms.Button Laske;
        private System.Windows.Forms.Label karkkimääräL;
        private System.Windows.Forms.Label karkkimääräkL;
        private System.Windows.Forms.Label maara;
        private System.Windows.Forms.Label euro;
        private System.Windows.Forms.Label label1;
    }
}


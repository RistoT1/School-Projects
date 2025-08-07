namespace Matti_ja_Arto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.Jatka = new System.Windows.Forms.Button();
            this.Vastaus = new System.Windows.Forms.Label();
            this.NollaB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "nimi1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "nimi2";
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(31, 60);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 26);
            this.txtInput1.TabIndex = 2;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(176, 59);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 26);
            this.txtInput2.TabIndex = 3;
            // 
            // Jatka
            // 
            this.Jatka.Location = new System.Drawing.Point(107, 108);
            this.Jatka.Name = "Jatka";
            this.Jatka.Size = new System.Drawing.Size(78, 30);
            this.Jatka.TabIndex = 4;
            this.Jatka.Text = "Jatka";
            this.Jatka.UseVisualStyleBackColor = true;
            this.Jatka.Click += new System.EventHandler(this.Jatka_Click);
            // 
            // Vastaus
            // 
            this.Vastaus.AutoSize = true;
            this.Vastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Vastaus.Location = new System.Drawing.Point(317, 60);
            this.Vastaus.Name = "Vastaus";
            this.Vastaus.Size = new System.Drawing.Size(28, 22);
            this.Vastaus.TabIndex = 5;
            this.Vastaus.Text = "---";
            this.Vastaus.Click += new System.EventHandler(this.label3_Click);
            // 
            // NollaB
            // 
            this.NollaB.Location = new System.Drawing.Point(107, 159);
            this.NollaB.Name = "NollaB";
            this.NollaB.Size = new System.Drawing.Size(78, 30);
            this.NollaB.TabIndex = 6;
            this.NollaB.Text = "Nollaa";
            this.NollaB.UseVisualStyleBackColor = true;
            this.NollaB.Click += new System.EventHandler(this.NollaB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NollaB);
            this.Controls.Add(this.Vastaus);
            this.Controls.Add(this.Jatka);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button Jatka;
        private System.Windows.Forms.Label Vastaus;
        private System.Windows.Forms.Button NollaB;
    }
}


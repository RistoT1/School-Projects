namespace Nopan_heitto
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
            this.btnLaske = new System.Windows.Forms.Button();
            this.txtVastaus1 = new System.Windows.Forms.TextBox();
            this.txtVastaus2 = new System.Windows.Forms.TextBox();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(135, 41);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(161, 81);
            this.btnLaske.TabIndex = 1;
            this.btnLaske.Text = "Tulosta";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVastaus1
            // 
            this.txtVastaus1.Location = new System.Drawing.Point(55, 128);
            this.txtVastaus1.Multiline = true;
            this.txtVastaus1.Name = "txtVastaus1";
            this.txtVastaus1.ReadOnly = true;
            this.txtVastaus1.Size = new System.Drawing.Size(161, 152);
            this.txtVastaus1.TabIndex = 2;
            // 
            // txtVastaus2
            // 
            this.txtVastaus2.Location = new System.Drawing.Point(222, 128);
            this.txtVastaus2.Multiline = true;
            this.txtVastaus2.Name = "txtVastaus2";
            this.txtVastaus2.ReadOnly = true;
            this.txtVastaus2.Size = new System.Drawing.Size(161, 152);
            this.txtVastaus2.TabIndex = 3;
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(135, 286);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.ReadOnly = true;
            this.txtSumma.Size = new System.Drawing.Size(161, 26);
            this.txtSumma.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.txtVastaus2);
            this.Controls.Add(this.txtVastaus1);
            this.Controls.Add(this.btnLaske);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaske;
        private System.Windows.Forms.TextBox txtVastaus1;
        private System.Windows.Forms.TextBox txtVastaus2;
        private System.Windows.Forms.TextBox txtSumma;
    }
}


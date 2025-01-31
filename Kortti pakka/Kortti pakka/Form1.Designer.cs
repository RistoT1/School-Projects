namespace Kortti_pakka
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
            this.bntButton = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.btnSekoita = new System.Windows.Forms.Button();
            this.btnJarjesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntButton
            // 
            this.bntButton.Location = new System.Drawing.Point(242, 23);
            this.bntButton.Name = "bntButton";
            this.bntButton.Size = new System.Drawing.Size(120, 76);
            this.bntButton.TabIndex = 0;
            this.bntButton.Text = "Aloita";
            this.bntButton.UseVisualStyleBackColor = true;
            this.bntButton.Click += new System.EventHandler(this.bntButton_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(116, 105);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(367, 136);
            this.txtVastaus.TabIndex = 1;
            // 
            // btnSekoita
            // 
            this.btnSekoita.Location = new System.Drawing.Point(116, 260);
            this.btnSekoita.Name = "btnSekoita";
            this.btnSekoita.Size = new System.Drawing.Size(130, 76);
            this.btnSekoita.TabIndex = 2;
            this.btnSekoita.Text = "Sekoita";
            this.btnSekoita.UseVisualStyleBackColor = true;
            this.btnSekoita.Visible = false;
            this.btnSekoita.Click += new System.EventHandler(this.btnSekoita_Click);
            // 
            // btnJarjesta
            // 
            this.btnJarjesta.Location = new System.Drawing.Point(356, 260);
            this.btnJarjesta.Name = "btnJarjesta";
            this.btnJarjesta.Size = new System.Drawing.Size(127, 76);
            this.btnJarjesta.TabIndex = 3;
            this.btnJarjesta.Text = "Järjestä";
            this.btnJarjesta.UseVisualStyleBackColor = true;
            this.btnJarjesta.Visible = false;
            this.btnJarjesta.Click += new System.EventHandler(this.btnJarjesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJarjesta);
            this.Controls.Add(this.btnSekoita);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.bntButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntButton;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.Button btnSekoita;
        private System.Windows.Forms.Button btnJarjesta;
    }
}


namespace Kaksi_lomaketta_harjoituis
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
            this.tunnusL = new System.Windows.Forms.Label();
            this.SalasanaL = new System.Windows.Forms.Label();
            this.txtTunnus = new System.Windows.Forms.TextBox();
            this.txtSalasana = new System.Windows.Forms.TextBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.btnJatka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // tunnusL
            // 
            this.tunnusL.AutoSize = true;
            this.tunnusL.Location = new System.Drawing.Point(40, 45);
            this.tunnusL.Name = "tunnusL";
            this.tunnusL.Size = new System.Drawing.Size(115, 20);
            this.tunnusL.TabIndex = 0;
            this.tunnusL.Text = "Käyttäjätunnus";
            // 
            // SalasanaL
            // 
            this.SalasanaL.AutoSize = true;
            this.SalasanaL.Location = new System.Drawing.Point(40, 130);
            this.SalasanaL.Name = "SalasanaL";
            this.SalasanaL.Size = new System.Drawing.Size(76, 20);
            this.SalasanaL.TabIndex = 1;
            this.SalasanaL.Text = "Salasana";
            // 
            // txtTunnus
            // 
            this.txtTunnus.Location = new System.Drawing.Point(44, 81);
            this.txtTunnus.Name = "txtTunnus";
            this.txtTunnus.Size = new System.Drawing.Size(100, 26);
            this.txtTunnus.TabIndex = 2;
            // 
            // txtSalasana
            // 
            this.txtSalasana.Location = new System.Drawing.Point(44, 153);
            this.txtSalasana.Name = "txtSalasana";
            this.txtSalasana.Size = new System.Drawing.Size(100, 26);
            this.txtSalasana.TabIndex = 3;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(44, 201);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(100, 45);
            this.btnJatka.TabIndex = 4;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.txtSalasana);
            this.Controls.Add(this.txtTunnus);
            this.Controls.Add(this.SalasanaL);
            this.Controls.Add(this.tunnusL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tunnusL;
        private System.Windows.Forms.Label SalasanaL;
        private System.Windows.Forms.TextBox txtTunnus;
        private System.Windows.Forms.TextBox txtSalasana;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button btnJatka;
    }
}


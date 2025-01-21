namespace vakio_luvut
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
            this.txtRivit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnLue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRivit
            // 
            this.txtRivit.Location = new System.Drawing.Point(27, 49);
            this.txtRivit.Name = "txtRivit";
            this.txtRivit.Size = new System.Drawing.Size(195, 26);
            this.txtRivit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Syötä montako riviä haluat";
            // 
            // btnTulosta
            // 
            this.btnTulosta.Location = new System.Drawing.Point(231, 49);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(111, 43);
            this.btnTulosta.TabIndex = 2;
            this.btnTulosta.Text = "tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.btnTulosta_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVastaus.Location = new System.Drawing.Point(27, 82);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVastaus.Size = new System.Drawing.Size(195, 317);
            this.txtVastaus.TabIndex = 3;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(231, 99);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(111, 40);
            this.btnTallenna.TabIndex = 4;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // btnLue
            // 
            this.btnLue.Location = new System.Drawing.Point(231, 145);
            this.btnLue.Name = "btnLue";
            this.btnLue.Size = new System.Drawing.Size(111, 40);
            this.btnLue.TabIndex = 5;
            this.btnLue.Text = "Lue";
            this.btnLue.UseVisualStyleBackColor = true;
            this.btnLue.Click += new System.EventHandler(this.btnLue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLue);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRivit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRivit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnLue;
    }
}


namespace Etäisyydet_funktiot
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lukuL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cm (Senttimetri)",
            "dm (Desimetri)",
            "km (Kilometri)",
            "in (Tuuma)",
            "ft (Jalka)",
            "yd (Jaardi)"});
            this.comboBox1.Location = new System.Drawing.Point(217, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // lukuL
            // 
            this.lukuL.AutoSize = true;
            this.lukuL.Location = new System.Drawing.Point(79, 21);
            this.lukuL.Name = "lukuL";
            this.lukuL.Size = new System.Drawing.Size(84, 20);
            this.lukuL.TabIndex = 2;
            this.lukuL.Text = "Syötä arvo";
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(79, 80);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(100, 38);
            this.btnJatka.TabIndex = 3;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "m";
            // 
            // txtVastaus
            // 
            this.txtVastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtVastaus.Location = new System.Drawing.Point(217, 82);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(300, 83);
            this.txtVastaus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnJatka;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.lukuL);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lukuL;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


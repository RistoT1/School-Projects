namespace Etäisyydet_olio_ohjelmilla
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
            this.ArvoL = new System.Windows.Forms.Label();
            this.txtArvo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.btnJatka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArvoL
            // 
            this.ArvoL.AutoSize = true;
            this.ArvoL.Location = new System.Drawing.Point(40, 59);
            this.ArvoL.Name = "ArvoL";
            this.ArvoL.Size = new System.Drawing.Size(150, 20);
            this.ArvoL.TabIndex = 0;
            this.ArvoL.Text = "Syötä arvo metreinä";
            // 
            // txtArvo
            // 
            this.txtArvo.Location = new System.Drawing.Point(44, 83);
            this.txtArvo.Name = "txtArvo";
            this.txtArvo.Size = new System.Drawing.Size(100, 26);
            this.txtArvo.TabIndex = 1;
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
            this.comboBox1.Location = new System.Drawing.Point(204, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(44, 116);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(281, 261);
            this.txtVastaus.TabIndex = 3;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(357, 80);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(82, 34);
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
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtArvo);
            this.Controls.Add(this.ArvoL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArvoL;
        private System.Windows.Forms.TextBox txtArvo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtVastaus;
        private System.Windows.Forms.Button btnJatka;
    }
}


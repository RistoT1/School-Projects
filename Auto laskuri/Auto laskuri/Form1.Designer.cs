namespace Auto_laskuri
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
            this.HenkiloA = new System.Windows.Forms.Button();
            this.KuormaA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nollaus = new System.Windows.Forms.Button();
            this.txthauto = new System.Windows.Forms.TextBox();
            this.txtkauto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HenkiloA
            // 
            this.HenkiloA.Location = new System.Drawing.Point(113, 271);
            this.HenkiloA.Name = "HenkiloA";
            this.HenkiloA.Size = new System.Drawing.Size(119, 53);
            this.HenkiloA.TabIndex = 0;
            this.HenkiloA.Text = "Henkilö auto";
            this.HenkiloA.UseVisualStyleBackColor = true;
            this.HenkiloA.Click += new System.EventHandler(this.HenkiloA_Click);
            // 
            // KuormaA
            // 
            this.KuormaA.Location = new System.Drawing.Point(440, 271);
            this.KuormaA.Name = "KuormaA";
            this.KuormaA.Size = new System.Drawing.Size(131, 53);
            this.KuormaA.TabIndex = 1;
            this.KuormaA.Text = "Kuorma-autoja";
            this.KuormaA.UseVisualStyleBackColor = true;
            this.KuormaA.Click += new System.EventHandler(this.KuormaA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(132, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label2.Location = new System.Drawing.Point(463, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 73);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // Nollaus
            // 
            this.Nollaus.Location = new System.Drawing.Point(113, 346);
            this.Nollaus.Name = "Nollaus";
            this.Nollaus.Size = new System.Drawing.Size(458, 61);
            this.Nollaus.TabIndex = 4;
            this.Nollaus.Text = "Nollaa";
            this.Nollaus.UseVisualStyleBackColor = true;
            this.Nollaus.Click += new System.EventHandler(this.button3_Click);
            // 
            // txthauto
            // 
            this.txthauto.Location = new System.Drawing.Point(239, 284);
            this.txthauto.Name = "txthauto";
            this.txthauto.Size = new System.Drawing.Size(100, 26);
            this.txthauto.TabIndex = 5;
            this.txthauto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtkauto
            // 
            this.txtkauto.Location = new System.Drawing.Point(577, 284);
            this.txtkauto.Name = "txtkauto";
            this.txtkauto.Size = new System.Drawing.Size(100, 26);
            this.txtkauto.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkauto);
            this.Controls.Add(this.txthauto);
            this.Controls.Add(this.Nollaus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KuormaA);
            this.Controls.Add(this.HenkiloA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HenkiloA;
        private System.Windows.Forms.Button KuormaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Nollaus;
        private System.Windows.Forms.TextBox txthauto;
        private System.Windows.Forms.TextBox txtkauto;
        private System.Windows.Forms.Button button1;
    }
}


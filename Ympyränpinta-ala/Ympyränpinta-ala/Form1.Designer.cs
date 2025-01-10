namespace Ympyränpinta_ala
{
    partial class Ympyrälaskuri
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
            this.SadeL = new System.Windows.Forms.Label();
            this.txtSade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VastausL = new System.Windows.Forms.Label();
            this.cmL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.label1.Location = new System.Drawing.Point(349, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "○";
            // 
            // SadeL
            // 
            this.SadeL.AutoSize = true;
            this.SadeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SadeL.Location = new System.Drawing.Point(59, 35);
            this.SadeL.Name = "SadeL";
            this.SadeL.Size = new System.Drawing.Size(52, 22);
            this.SadeL.TabIndex = 1;
            this.SadeL.Text = "Säde";
            // 
            // txtSade
            // 
            this.txtSade.Location = new System.Drawing.Point(63, 74);
            this.txtSade.Name = "txtSade";
            this.txtSade.Size = new System.Drawing.Size(100, 26);
            this.txtSade.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Jatka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VastausL
            // 
            this.VastausL.AutoSize = true;
            this.VastausL.Location = new System.Drawing.Point(206, 79);
            this.VastausL.Name = "VastausL";
            this.VastausL.Size = new System.Drawing.Size(24, 20);
            this.VastausL.TabIndex = 4;
            this.VastausL.Text = "---";
            // 
            // cmL
            // 
            this.cmL.AutoSize = true;
            this.cmL.Location = new System.Drawing.Point(160, 79);
            this.cmL.Name = "cmL";
            this.cmL.Size = new System.Drawing.Size(30, 20);
            this.cmL.TabIndex = 5;
            this.cmL.Text = "cm";
            // 
            // Ympyrälaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmL);
            this.Controls.Add(this.VastausL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSade);
            this.Controls.Add(this.SadeL);
            this.Controls.Add(this.label1);
            this.Name = "Ympyrälaskuri";
            this.Text = "Ympyrälaskuroi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SadeL;
        private System.Windows.Forms.TextBox txtSade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VastausL;
        private System.Windows.Forms.Label cmL;
    }
}


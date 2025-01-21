namespace Checkbox_testi
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.Tulos1 = new System.Windows.Forms.TextBox();
            this.Tulos2 = new System.Windows.Forms.TextBox();
            this.MaaraL = new System.Windows.Forms.Label();
            this.YhteensaL = new System.Windows.Forms.Label();
            this.btnLaske = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "5";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(59, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "8";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(59, 149);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "9";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(59, 196);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(53, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "15";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Tulos1
            // 
            this.Tulos1.Location = new System.Drawing.Point(256, 102);
            this.Tulos1.Name = "Tulos1";
            this.Tulos1.Size = new System.Drawing.Size(100, 26);
            this.Tulos1.TabIndex = 4;
            // 
            // Tulos2
            // 
            this.Tulos2.Location = new System.Drawing.Point(256, 196);
            this.Tulos2.Name = "Tulos2";
            this.Tulos2.Size = new System.Drawing.Size(100, 26);
            this.Tulos2.TabIndex = 5;
            // 
            // MaaraL
            // 
            this.MaaraL.AutoSize = true;
            this.MaaraL.Location = new System.Drawing.Point(256, 62);
            this.MaaraL.Name = "MaaraL";
            this.MaaraL.Size = new System.Drawing.Size(54, 20);
            this.MaaraL.TabIndex = 6;
            this.MaaraL.Text = "Määrä";
            this.MaaraL.Click += new System.EventHandler(this.label1_Click);
            // 
            // YhteensaL
            // 
            this.YhteensaL.AutoSize = true;
            this.YhteensaL.Location = new System.Drawing.Point(252, 153);
            this.YhteensaL.Name = "YhteensaL";
            this.YhteensaL.Size = new System.Drawing.Size(78, 20);
            this.YhteensaL.TabIndex = 7;
            this.YhteensaL.Text = "Yhteensä";
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(59, 295);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(75, 37);
            this.btnLaske.TabIndex = 8;
            this.btnLaske.Text = "Laske";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btnLaske_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(59, 244);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(184, 24);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Testi laatikko tekstillä";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.btnLaske);
            this.Controls.Add(this.YhteensaL);
            this.Controls.Add(this.MaaraL);
            this.Controls.Add(this.Tulos2);
            this.Controls.Add(this.Tulos1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox Tulos1;
        private System.Windows.Forms.TextBox Tulos2;
        private System.Windows.Forms.Label MaaraL;
        private System.Windows.Forms.Label YhteensaL;
        private System.Windows.Forms.Button btnLaske;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}


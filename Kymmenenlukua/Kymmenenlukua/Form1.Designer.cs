namespace Kymmenenlukua
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.LuvutL = new System.Windows.Forms.Label();
            this.btnSuurin = new System.Windows.Forms.Button();
            this.btnNolla = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(28, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 26);
            this.textBox8.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(28, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(28, 326);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 26);
            this.textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(28, 294);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 14;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(28, 262);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 26);
            this.textBox11.TabIndex = 13;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(28, 230);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 26);
            this.textBox12.TabIndex = 12;
            // 
            // LuvutL
            // 
            this.LuvutL.AutoSize = true;
            this.LuvutL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LuvutL.Location = new System.Drawing.Point(28, 12);
            this.LuvutL.Name = "LuvutL";
            this.LuvutL.Size = new System.Drawing.Size(48, 22);
            this.LuvutL.TabIndex = 16;
            this.LuvutL.Text = "luvut";
            // 
            // btnSuurin
            // 
            this.btnSuurin.Location = new System.Drawing.Point(12, 358);
            this.btnSuurin.Name = "btnSuurin";
            this.btnSuurin.Size = new System.Drawing.Size(135, 40);
            this.btnSuurin.TabIndex = 17;
            this.btnSuurin.Text = "Näytä suurin";
            this.btnSuurin.UseVisualStyleBackColor = true;
            this.btnSuurin.Click += new System.EventHandler(this.btnSuurin_Click);
            // 
            // btnNolla
            // 
            this.btnNolla.BackColor = System.Drawing.Color.MistyRose;
            this.btnNolla.ForeColor = System.Drawing.Color.Firebrick;
            this.btnNolla.Location = new System.Drawing.Point(13, 405);
            this.btnNolla.Name = "btnNolla";
            this.btnNolla.Size = new System.Drawing.Size(134, 42);
            this.btnNolla.TabIndex = 18;
            this.btnNolla.Text = "Nollaa Kentät";
            this.btnNolla.UseVisualStyleBackColor = false;
            this.btnNolla.Visible = false;
            this.btnNolla.Click += new System.EventHandler(this.btnNolla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNolla);
            this.Controls.Add(this.btnSuurin);
            this.Controls.Add(this.LuvutL);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label LuvutL;
        private System.Windows.Forms.Button btnSuurin;
        private System.Windows.Forms.Button btnNolla;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


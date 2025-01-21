namespace txtTallenus_ja_luku
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
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.textBoxNimi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(271, 35);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(273, 341);
            this.textBoxData.TabIndex = 0;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(42, 329);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(108, 47);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(628, 334);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(108, 42);
            this.ButtonLoad.TabIndex = 2;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // textBoxNimi
            // 
            this.textBoxNimi.Location = new System.Drawing.Point(294, 382);
            this.textBoxNimi.Name = "textBoxNimi";
            this.textBoxNimi.Size = new System.Drawing.Size(213, 26);
            this.textBoxNimi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNimi);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.TextBox textBoxNimi;
    }
}


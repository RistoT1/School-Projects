namespace pinta_alat_ja_tilavuudet
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtsade = new System.Windows.Forms.TextBox();
            this.txtLeveys = new System.Windows.Forms.TextBox();
            this.txtKorkeus = new System.Windows.Forms.TextBox();
            this.LaskuL = new System.Windows.Forms.Label();
            this.sadeL = new System.Windows.Forms.Label();
            this.KorkeusL = new System.Windows.Forms.Label();
            this.LeveysL = new System.Windows.Forms.Label();
            this.btnJatka = new System.Windows.Forms.Button();
            this.txtVastaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Neliö (pinta-ala)",
            "Ympyrä (pinta-ala)",
            "Ympyrälieriö (pinta-ala)",
            "Pallo (pinta-ala)",
            "Pallo (tilavuus)",
            "Kuutio (tilavuus)",
            "Ympyrä kartio (tilavuus)",
            "Pyramidi (tilavuus)"});
            this.comboBox1.Location = new System.Drawing.Point(29, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtsade
            // 
            this.txtsade.Location = new System.Drawing.Point(374, 72);
            this.txtsade.Name = "txtsade";
            this.txtsade.Size = new System.Drawing.Size(100, 26);
            this.txtsade.TabIndex = 1;
            this.txtsade.Visible = false;
            // 
            // txtLeveys
            // 
            this.txtLeveys.Location = new System.Drawing.Point(495, 73);
            this.txtLeveys.Name = "txtLeveys";
            this.txtLeveys.Size = new System.Drawing.Size(100, 26);
            this.txtLeveys.TabIndex = 2;
            this.txtLeveys.Visible = false;
            // 
            // txtKorkeus
            // 
            this.txtKorkeus.Location = new System.Drawing.Point(248, 70);
            this.txtKorkeus.Name = "txtKorkeus";
            this.txtKorkeus.Size = new System.Drawing.Size(100, 26);
            this.txtKorkeus.TabIndex = 3;
            this.txtKorkeus.Visible = false;
            // 
            // LaskuL
            // 
            this.LaskuL.AutoSize = true;
            this.LaskuL.Location = new System.Drawing.Point(29, 39);
            this.LaskuL.Name = "LaskuL";
            this.LaskuL.Size = new System.Drawing.Size(104, 20);
            this.LaskuL.TabIndex = 4;
            this.LaskuL.Text = "Valitse Lasku";
            this.LaskuL.Click += new System.EventHandler(this.label1_Click);
            // 
            // sadeL
            // 
            this.sadeL.AutoSize = true;
            this.sadeL.Location = new System.Drawing.Point(370, 44);
            this.sadeL.Name = "sadeL";
            this.sadeL.Size = new System.Drawing.Size(47, 20);
            this.sadeL.TabIndex = 5;
            this.sadeL.Text = "Säde";
            this.sadeL.Visible = false;
            // 
            // KorkeusL
            // 
            this.KorkeusL.AutoSize = true;
            this.KorkeusL.Location = new System.Drawing.Point(244, 44);
            this.KorkeusL.Name = "KorkeusL";
            this.KorkeusL.Size = new System.Drawing.Size(67, 20);
            this.KorkeusL.TabIndex = 6;
            this.KorkeusL.Text = "Korkeus";
            this.KorkeusL.Visible = false;
            // 
            // LeveysL
            // 
            this.LeveysL.AutoSize = true;
            this.LeveysL.Location = new System.Drawing.Point(491, 47);
            this.LeveysL.Name = "LeveysL";
            this.LeveysL.Size = new System.Drawing.Size(110, 20);
            this.LeveysL.TabIndex = 7;
            this.LeveysL.Text = "pohjan Leveys";
            this.LeveysL.Visible = false;
            // 
            // btnJatka
            // 
            this.btnJatka.Location = new System.Drawing.Point(29, 115);
            this.btnJatka.Name = "btnJatka";
            this.btnJatka.Size = new System.Drawing.Size(181, 47);
            this.btnJatka.TabIndex = 8;
            this.btnJatka.Text = "Jatka";
            this.btnJatka.UseVisualStyleBackColor = true;
            this.btnJatka.Click += new System.EventHandler(this.btnJatka_Click);
            // 
            // txtVastaus
            // 
            this.txtVastaus.Location = new System.Drawing.Point(248, 115);
            this.txtVastaus.Multiline = true;
            this.txtVastaus.Name = "txtVastaus";
            this.txtVastaus.ReadOnly = true;
            this.txtVastaus.Size = new System.Drawing.Size(151, 47);
            this.txtVastaus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVastaus);
            this.Controls.Add(this.btnJatka);
            this.Controls.Add(this.LeveysL);
            this.Controls.Add(this.KorkeusL);
            this.Controls.Add(this.sadeL);
            this.Controls.Add(this.LaskuL);
            this.Controls.Add(this.txtKorkeus);
            this.Controls.Add(this.txtLeveys);
            this.Controls.Add(this.txtsade);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtsade;
        private System.Windows.Forms.TextBox txtLeveys;
        private System.Windows.Forms.TextBox txtKorkeus;
        private System.Windows.Forms.Label LaskuL;
        private System.Windows.Forms.Label sadeL;
        private System.Windows.Forms.Label KorkeusL;
        private System.Windows.Forms.Label LeveysL;
        private System.Windows.Forms.Button btnJatka;
        private System.Windows.Forms.TextBox txtVastaus;
    }
}


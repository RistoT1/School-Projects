namespace Mäkihyppy_teht
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Jatka = new System.Windows.Forms.Button();
            this.txtKpiste = new System.Windows.Forms.TextBox();
            this.KPisyteL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hyppääjä = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hypynPituus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuomari1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuomari2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuomari3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuomari4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuomari5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HypynPituusPisteet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tyylipisteet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KokonaisPisteet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hyppääjä,
            this.hypynPituus,
            this.Tuomari1,
            this.Tuomari2,
            this.Tuomari3,
            this.Tuomari4,
            this.Tuomari5,
            this.HypynPituusPisteet,
            this.Tyylipisteet,
            this.KokonaisPisteet});
            this.dataGridView1.Location = new System.Drawing.Point(30, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(2380, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Jatka
            // 
            this.Jatka.Location = new System.Drawing.Point(1883, 361);
            this.Jatka.Name = "Jatka";
            this.Jatka.Size = new System.Drawing.Size(102, 49);
            this.Jatka.TabIndex = 3;
            this.Jatka.Text = "Jatka";
            this.Jatka.UseVisualStyleBackColor = true;
            this.Jatka.Click += new System.EventHandler(this.Jatka_Click);
            // 
            // txtKpiste
            // 
            this.txtKpiste.Location = new System.Drawing.Point(1745, 382);
            this.txtKpiste.Name = "txtKpiste";
            this.txtKpiste.Size = new System.Drawing.Size(100, 26);
            this.txtKpiste.TabIndex = 4;
            // 
            // KPisyteL
            // 
            this.KPisyteL.AutoSize = true;
            this.KPisyteL.Location = new System.Drawing.Point(1745, 361);
            this.KPisyteL.Name = "KPisyteL";
            this.KPisyteL.Size = new System.Drawing.Size(59, 20);
            this.KPisyteL.TabIndex = 5;
            this.KPisyteL.Text = "K-Piste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1844, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "m";
            // 
            // Hyppääjä
            // 
            this.Hyppääjä.HeaderText = "hyppaaja";
            this.Hyppääjä.MinimumWidth = 8;
            this.Hyppääjä.Name = "Hyppääjä";
            // 
            // hypynPituus
            // 
            this.hypynPituus.HeaderText = "Hypyn Pituus";
            this.hypynPituus.MinimumWidth = 8;
            this.hypynPituus.Name = "hypynPituus";
            this.hypynPituus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Tuomari1
            // 
            this.Tuomari1.HeaderText = "Tuomari1";
            this.Tuomari1.MinimumWidth = 8;
            this.Tuomari1.Name = "Tuomari1";
            // 
            // Tuomari2
            // 
            this.Tuomari2.HeaderText = "Tuomari2";
            this.Tuomari2.MinimumWidth = 8;
            this.Tuomari2.Name = "Tuomari2";
            // 
            // Tuomari3
            // 
            this.Tuomari3.HeaderText = "Tuomari3";
            this.Tuomari3.MinimumWidth = 8;
            this.Tuomari3.Name = "Tuomari3";
            // 
            // Tuomari4
            // 
            this.Tuomari4.HeaderText = "Tuomari4";
            this.Tuomari4.MinimumWidth = 8;
            this.Tuomari4.Name = "Tuomari4";
            // 
            // Tuomari5
            // 
            this.Tuomari5.HeaderText = "Tuomari5";
            this.Tuomari5.MinimumWidth = 8;
            this.Tuomari5.Name = "Tuomari5";
            // 
            // HypynPituusPisteet
            // 
            this.HypynPituusPisteet.HeaderText = "Hypynpituus pisteet";
            this.HypynPituusPisteet.MinimumWidth = 8;
            this.HypynPituusPisteet.Name = "HypynPituusPisteet";
            // 
            // Tyylipisteet
            // 
            this.Tyylipisteet.HeaderText = "Tyylipisteet";
            this.Tyylipisteet.MinimumWidth = 8;
            this.Tyylipisteet.Name = "Tyylipisteet";
            this.Tyylipisteet.ReadOnly = true;
            // 
            // KokonaisPisteet
            // 
            this.KokonaisPisteet.HeaderText = "KokonaisPisteet";
            this.KokonaisPisteet.MinimumWidth = 8;
            this.KokonaisPisteet.Name = "KokonaisPisteet";
            this.KokonaisPisteet.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2654, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KPisyteL);
            this.Controls.Add(this.txtKpiste);
            this.Controls.Add(this.Jatka);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Jatka;
        private System.Windows.Forms.TextBox txtKpiste;
        private System.Windows.Forms.Label KPisyteL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hyppääjä;
        private System.Windows.Forms.DataGridViewTextBoxColumn hypynPituus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuomari1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuomari2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuomari3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuomari4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuomari5;
        private System.Windows.Forms.DataGridViewTextBoxColumn HypynPituusPisteet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tyylipisteet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KokonaisPisteet;
    }
}


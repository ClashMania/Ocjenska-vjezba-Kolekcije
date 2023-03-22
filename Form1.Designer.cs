namespace OcijenskaVijezbaKolekcije
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxRod = new System.Windows.Forms.ComboBox();
            this.BtnUnos = new System.Windows.Forms.Button();
            this.BtnObrada = new System.Windows.Forms.Button();
            this.BtnIspis = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxIme
            // 
            this.txtIme.Location = new System.Drawing.Point(571, 55);
            this.txtIme.Name = "TxtBoxIme";
            this.txtIme.Size = new System.Drawing.Size(120, 20);
            this.txtIme.TabIndex = 0;
            // 
            // TxtBoxPrz
            // 
            this.txtPrezime.Location = new System.Drawing.Point(570, 104);
            this.txtPrezime.Name = "TxtBoxPrz";
            this.txtPrezime.Size = new System.Drawing.Size(121, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // TxtBoxGodRod
            // 
            this.txtGod.Location = new System.Drawing.Point(570, 157);
            this.txtGod.Name = "TxtBoxGodRod";
            this.txtGod.Size = new System.Drawing.Size(121, 20);
            this.txtGod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rod";
            // 
            // CmbBoxRod
            // 
            this.cmbxRod.FormattingEnabled = true;
            this.cmbxRod.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cmbxRod.Location = new System.Drawing.Point(570, 207);
            this.cmbxRod.Name = "CmbBoxRod";
            this.cmbxRod.Size = new System.Drawing.Size(121, 21);
            this.cmbxRod.TabIndex = 8;
            // 
            // BtnUnos
            // 
            this.BtnUnos.Location = new System.Drawing.Point(503, 333);
            this.BtnUnos.Name = "BtnUnos";
            this.BtnUnos.Size = new System.Drawing.Size(124, 57);
            this.BtnUnos.TabIndex = 9;
            this.BtnUnos.Text = "Unesi";
            this.BtnUnos.UseVisualStyleBackColor = true;
            this.BtnUnos.Click += new System.EventHandler(this.BtnUnos_Click);
            // 
            // BtnObrada
            // 
            this.BtnObrada.Location = new System.Drawing.Point(633, 270);
            this.BtnObrada.Name = "BtnObrada";
            this.BtnObrada.Size = new System.Drawing.Size(124, 57);
            this.BtnObrada.TabIndex = 10;
            this.BtnObrada.Text = "Obradi";
            this.BtnObrada.UseVisualStyleBackColor = true;
            this.BtnObrada.Click += new System.EventHandler(this.BtnObrada_Click);
            // 
            // BtnIspis
            // 
            this.BtnIspis.Location = new System.Drawing.Point(503, 270);
            this.BtnIspis.Name = "BtnIspis";
            this.BtnIspis.Size = new System.Drawing.Size(124, 57);
            this.BtnIspis.TabIndex = 11;
            this.BtnIspis.Text = "Ispiši";
            this.BtnIspis.UseVisualStyleBackColor = true;
            this.BtnIspis.Click += new System.EventHandler(this.BtnIspis_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(12, 12);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.ReadOnly = true;
            this.TxtBox.Size = new System.Drawing.Size(460, 426);
            this.TxtBox.TabIndex = 12;
            this.TxtBox.TabStop = false;
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(633, 333);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(124, 57);
            this.BtnSpremi.TabIndex = 13;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.BtnIspis);
            this.Controls.Add(this.BtnObrada);
            this.Controls.Add(this.BtnUnos);
            this.Controls.Add(this.cmbxRod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxRod;
        private System.Windows.Forms.Button BtnUnos;
        private System.Windows.Forms.Button BtnObrada;
        private System.Windows.Forms.Button BtnIspis;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Button BtnSpremi;
    }
}


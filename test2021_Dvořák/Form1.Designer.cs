namespace test2021_Dvořák
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text_jmeno = new System.Windows.Forms.TextBox();
            this.text_cisloUctu = new System.Windows.Forms.TextBox();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelCisloUctu = new System.Windows.Forms.Label();
            this.lbl_aktualni = new System.Windows.Forms.Label();
            this.text_zustatek = new System.Windows.Forms.TextBox();
            this.č_vklad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_vklad = new System.Windows.Forms.Button();
            this.btn_výběr = new System.Windows.Forms.Button();
            this.btn_platba = new System.Windows.Forms.Button();
            this.č_vyber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.č_vklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.č_vyber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_jmeno
            // 
            this.text_jmeno.Location = new System.Drawing.Point(207, 7);
            this.text_jmeno.Name = "text_jmeno";
            this.text_jmeno.Size = new System.Drawing.Size(132, 21);
            this.text_jmeno.TabIndex = 0;
            // 
            // text_cisloUctu
            // 
            this.text_cisloUctu.Location = new System.Drawing.Point(207, 36);
            this.text_cisloUctu.Name = "text_cisloUctu";
            this.text_cisloUctu.Size = new System.Drawing.Size(132, 21);
            this.text_cisloUctu.TabIndex = 1;
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJmeno.Location = new System.Drawing.Point(112, 10);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(54, 15);
            this.labelJmeno.TabIndex = 2;
            this.labelJmeno.Text = "Jméno:";
            // 
            // labelCisloUctu
            // 
            this.labelCisloUctu.AutoSize = true;
            this.labelCisloUctu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCisloUctu.Location = new System.Drawing.Point(94, 39);
            this.labelCisloUctu.Name = "labelCisloUctu";
            this.labelCisloUctu.Size = new System.Drawing.Size(72, 15);
            this.labelCisloUctu.TabIndex = 3;
            this.labelCisloUctu.Text = "číslo účtu:";
            // 
            // lbl_aktualni
            // 
            this.lbl_aktualni.AutoSize = true;
            this.lbl_aktualni.Location = new System.Drawing.Point(45, 9);
            this.lbl_aktualni.Name = "lbl_aktualni";
            this.lbl_aktualni.Size = new System.Drawing.Size(122, 15);
            this.lbl_aktualni.TabIndex = 4;
            this.lbl_aktualni.Text = "aktuální stav účtu:";
            // 
            // text_zustatek
            // 
            this.text_zustatek.Location = new System.Drawing.Point(206, 6);
            this.text_zustatek.Name = "text_zustatek";
            this.text_zustatek.Size = new System.Drawing.Size(132, 21);
            this.text_zustatek.TabIndex = 5;
            // 
            // č_vklad
            // 
            this.č_vklad.Location = new System.Drawing.Point(23, 51);
            this.č_vklad.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.č_vklad.Name = "č_vklad";
            this.č_vklad.Size = new System.Drawing.Size(160, 21);
            this.č_vklad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "vklad";
            // 
            // btn_vklad
            // 
            this.btn_vklad.Location = new System.Drawing.Point(251, 47);
            this.btn_vklad.Name = "btn_vklad";
            this.btn_vklad.Size = new System.Drawing.Size(99, 27);
            this.btn_vklad.TabIndex = 8;
            this.btn_vklad.Text = "vložit";
            this.btn_vklad.UseVisualStyleBackColor = true;
            this.btn_vklad.Click += new System.EventHandler(this.btn_vklad_Click);
            // 
            // btn_výběr
            // 
            this.btn_výběr.Location = new System.Drawing.Point(251, 130);
            this.btn_výběr.Name = "btn_výběr";
            this.btn_výběr.Size = new System.Drawing.Size(99, 27);
            this.btn_výběr.TabIndex = 9;
            this.btn_výběr.Text = "vyber";
            this.btn_výběr.UseVisualStyleBackColor = true;
            this.btn_výběr.Click += new System.EventHandler(this.btn_výběr_Click);
            // 
            // btn_platba
            // 
            this.btn_platba.Location = new System.Drawing.Point(251, 223);
            this.btn_platba.Name = "btn_platba";
            this.btn_platba.Size = new System.Drawing.Size(99, 27);
            this.btn_platba.TabIndex = 10;
            this.btn_platba.Text = "plať";
            this.btn_platba.UseVisualStyleBackColor = true;
            this.btn_platba.Click += new System.EventHandler(this.btn_platba_Click);
            // 
            // č_vyber
            // 
            this.č_vyber.Location = new System.Drawing.Point(23, 134);
            this.č_vyber.Name = "č_vyber";
            this.č_vyber.Size = new System.Drawing.Size(160, 21);
            this.č_vyber.TabIndex = 11;
            this.č_vyber.ValueChanged += new System.EventHandler(this.č_vyber_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(23, 227);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 21);
            this.numericUpDown2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "výběr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Platba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dvořák Adam";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.č_vyber);
            this.panel1.Controls.Add(this.btn_platba);
            this.panel1.Controls.Add(this.btn_výběr);
            this.panel1.Controls.Add(this.btn_vklad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.č_vklad);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(58, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 321);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbl_aktualni);
            this.panel2.Controls.Add(this.text_zustatek);
            this.panel2.Location = new System.Drawing.Point(58, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 33);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.labelCisloUctu);
            this.panel3.Controls.Add(this.labelJmeno);
            this.panel3.Controls.Add(this.text_cisloUctu);
            this.panel3.Controls.Add(this.text_jmeno);
            this.panel3.Location = new System.Drawing.Point(58, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 63);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(197, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.č_vklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.č_vyber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_jmeno;
        private System.Windows.Forms.TextBox text_cisloUctu;
        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelCisloUctu;
        private System.Windows.Forms.Label lbl_aktualni;
        private System.Windows.Forms.TextBox text_zustatek;
        private System.Windows.Forms.NumericUpDown č_vklad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_vklad;
        private System.Windows.Forms.Button btn_výběr;
        private System.Windows.Forms.Button btn_platba;
        private System.Windows.Forms.NumericUpDown č_vyber;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


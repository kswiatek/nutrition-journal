namespace WindowsFormsApplication2
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWie = new System.Windows.Forms.TextBox();
            this.txtWzr = new System.Windows.Forms.TextBox();
            this.txtWag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxK = new System.Windows.Forms.CheckBox();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHas2 = new System.Windows.Forms.TextBox();
            this.txtHas = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWroc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAlergen = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtBoxSzukaj = new System.Windows.Forms.TextBox();
            this.btnWyszukaj = new System.Windows.Forms.Button();
            this.lblSzukaj = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wiek: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wzrost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Waga:";
            // 
            // txtWie
            // 
            this.txtWie.Location = new System.Drawing.Point(96, 118);
            this.txtWie.Name = "txtWie";
            this.txtWie.Size = new System.Drawing.Size(67, 20);
            this.txtWie.TabIndex = 5;
            // 
            // txtWzr
            // 
            this.txtWzr.Location = new System.Drawing.Point(96, 159);
            this.txtWzr.Name = "txtWzr";
            this.txtWzr.Size = new System.Drawing.Size(67, 20);
            this.txtWzr.TabIndex = 6;
            // 
            // txtWag
            // 
            this.txtWag.Location = new System.Drawing.Point(96, 208);
            this.txtWag.Name = "txtWag";
            this.txtWag.Size = new System.Drawing.Size(67, 20);
            this.txtWag.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "lat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "kg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 248);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Płeć:";
            // 
            // checkBoxK
            // 
            this.checkBoxK.AutoSize = true;
            this.checkBoxK.Location = new System.Drawing.Point(79, 247);
            this.checkBoxK.Name = "checkBoxK";
            this.checkBoxK.Size = new System.Drawing.Size(62, 17);
            this.checkBoxK.TabIndex = 16;
            this.checkBoxK.Text = "Kobieta";
            this.checkBoxK.UseVisualStyleBackColor = true;
            this.checkBoxK.CheckedChanged += new System.EventHandler(this.checkBoxK_CheckedChanged);
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(149, 248);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(79, 17);
            this.checkBoxM.TabIndex = 17;
            this.checkBoxM.Text = "Mężczyzna";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hasło:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Powtórz hasło:";
            // 
            // txtHas2
            // 
            this.txtHas2.Location = new System.Drawing.Point(128, 83);
            this.txtHas2.Name = "txtHas2";
            this.txtHas2.PasswordChar = '*';
            this.txtHas2.Size = new System.Drawing.Size(100, 20);
            this.txtHas2.TabIndex = 21;
            // 
            // txtHas
            // 
            this.txtHas.Location = new System.Drawing.Point(128, 50);
            this.txtHas.Name = "txtHas";
            this.txtHas.PasswordChar = '*';
            this.txtHas.Size = new System.Drawing.Size(100, 20);
            this.txtHas.TabIndex = 22;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(128, 16);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 20);
            this.txtLog.TabIndex = 23;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(35, 294);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 23);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj użytkownika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWroc
            // 
            this.btnWroc.Location = new System.Drawing.Point(162, 294);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(75, 23);
            this.btnWroc.TabIndex = 25;
            this.btnWroc.Text = "Wróć";
            this.btnWroc.UseVisualStyleBackColor = true;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.btnAlergen);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(261, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 369);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wybierz produkty alergenne";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(188, 121);
            this.listBox2.TabIndex = 1;
            // 
            // btnAlergen
            // 
            this.btnAlergen.Location = new System.Drawing.Point(63, 252);
            this.btnAlergen.Name = "btnAlergen";
            this.btnAlergen.Size = new System.Drawing.Size(75, 23);
            this.btnAlergen.TabIndex = 2;
            this.btnAlergen.Text = "dodaj";
            this.btnAlergen.UseVisualStyleBackColor = true;
            this.btnAlergen.Click += new System.EventHandler(this.btnAlergen_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 281);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(188, 82);
            this.listBox3.TabIndex = 3;
            // 
            // txtBoxSzukaj
            // 
            this.txtBoxSzukaj.Location = new System.Drawing.Point(128, 336);
            this.txtBoxSzukaj.Name = "txtBoxSzukaj";
            this.txtBoxSzukaj.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSzukaj.TabIndex = 27;
            // 
            // btnWyszukaj
            // 
            this.btnWyszukaj.Location = new System.Drawing.Point(43, 334);
            this.btnWyszukaj.Name = "btnWyszukaj";
            this.btnWyszukaj.Size = new System.Drawing.Size(75, 23);
            this.btnWyszukaj.TabIndex = 28;
            this.btnWyszukaj.Text = "szukaj";
            this.btnWyszukaj.UseVisualStyleBackColor = true;
            this.btnWyszukaj.Click += new System.EventHandler(this.btnWyszukaj_Click);
            // 
            // lblSzukaj
            // 
            this.lblSzukaj.AutoSize = true;
            this.lblSzukaj.Location = new System.Drawing.Point(67, 368);
            this.lblSzukaj.Name = "lblSzukaj";
            this.lblSzukaj.Size = new System.Drawing.Size(16, 13);
            this.lblSzukaj.TabIndex = 29;
            this.lblSzukaj.Text = "...";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 393);
            this.Controls.Add(this.lblSzukaj);
            this.Controls.Add(this.btnWyszukaj);
            this.Controls.Add(this.txtBoxSzukaj);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtHas);
            this.Controls.Add(this.txtHas2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.checkBoxK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWag);
            this.Controls.Add(this.txtWzr);
            this.Controls.Add(this.txtWie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Tworzenie użytkownika";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWie;
        private System.Windows.Forms.TextBox txtWzr;
        private System.Windows.Forms.TextBox txtWag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxK;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHas2;
        private System.Windows.Forms.TextBox txtHas;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnAlergen;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBoxSzukaj;
        private System.Windows.Forms.Button btnWyszukaj;
        private System.Windows.Forms.Label lblSzukaj;
    }
}
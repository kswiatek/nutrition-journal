namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.btnUsunKonto = new System.Windows.Forms.Button();
            this.btnZmien = new System.Windows.Forms.Button();
            this.btnOblZap = new System.Windows.Forms.Button();
            this.btnObliczBMI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.txtWiek = new System.Windows.Forms.TextBox();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelKalZap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBloZap = new System.Windows.Forms.Label();
            this.labelTluZap = new System.Windows.Forms.Label();
            this.labelWegZap = new System.Windows.Forms.Label();
            this.labelBiaZap = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxU = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnZapiszZmiany = new System.Windows.Forms.Button();
            this.btnWroc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnZapiszZapotrzebowanie = new System.Windows.Forms.Button();
            this.txtBlonnikObl = new System.Windows.Forms.TextBox();
            this.txtTluszczObl = new System.Windows.Forms.TextBox();
            this.txtWeglowObl = new System.Windows.Forms.TextBox();
            this.txtBialkoObl = new System.Windows.Forms.TextBox();
            this.txtKalorieObl = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxKobieta = new System.Windows.Forms.CheckBox();
            this.checkBoxMezczyzna = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsunKonto
            // 
            this.btnUsunKonto.Location = new System.Drawing.Point(101, 24);
            this.btnUsunKonto.Name = "btnUsunKonto";
            this.btnUsunKonto.Size = new System.Drawing.Size(101, 23);
            this.btnUsunKonto.TabIndex = 0;
            this.btnUsunKonto.Text = "Usuń swoje konto";
            this.btnUsunKonto.UseVisualStyleBackColor = true;
            this.btnUsunKonto.Click += new System.EventHandler(this.btnUsunKonto_Click);
            // 
            // btnZmien
            // 
            this.btnZmien.Location = new System.Drawing.Point(101, 53);
            this.btnZmien.Name = "btnZmien";
            this.btnZmien.Size = new System.Drawing.Size(101, 23);
            this.btnZmien.TabIndex = 1;
            this.btnZmien.Text = "Zmień swoje dane";
            this.btnZmien.UseVisualStyleBackColor = true;
            this.btnZmien.Click += new System.EventHandler(this.btnZmien_Click);
            // 
            // btnOblZap
            // 
            this.btnOblZap.Location = new System.Drawing.Point(52, 111);
            this.btnOblZap.Name = "btnOblZap";
            this.btnOblZap.Size = new System.Drawing.Size(189, 35);
            this.btnOblZap.TabIndex = 2;
            this.btnOblZap.Text = "Oblicz dzienne zapotrzebowanie";
            this.btnOblZap.UseVisualStyleBackColor = true;
            this.btnOblZap.Click += new System.EventHandler(this.btnOblZap_Click);
            // 
            // btnObliczBMI
            // 
            this.btnObliczBMI.Location = new System.Drawing.Point(113, 82);
            this.btnObliczBMI.Name = "btnObliczBMI";
            this.btnObliczBMI.Size = new System.Drawing.Size(75, 23);
            this.btnObliczBMI.TabIndex = 3;
            this.btnObliczBMI.Text = "Oblicz BMI";
            this.btnObliczBMI.UseVisualStyleBackColor = true;
            this.btnObliczBMI.Click += new System.EventHandler(this.btnObliczBMI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wzrost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Waga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wiek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Płeć:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Login:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hasło:";
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(401, 35);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 10;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Enabled = false;
            this.txtHaslo.Location = new System.Drawing.Point(401, 70);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(100, 20);
            this.txtHaslo.TabIndex = 11;
            // 
            // txtWiek
            // 
            this.txtWiek.Enabled = false;
            this.txtWiek.Location = new System.Drawing.Point(401, 149);
            this.txtWiek.Name = "txtWiek";
            this.txtWiek.Size = new System.Drawing.Size(100, 20);
            this.txtWiek.TabIndex = 12;
            // 
            // txtWzrost
            // 
            this.txtWzrost.Enabled = false;
            this.txtWzrost.Location = new System.Drawing.Point(401, 187);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(100, 20);
            this.txtWzrost.TabIndex = 13;
            // 
            // txtWaga
            // 
            this.txtWaga.Enabled = false;
            this.txtWaga.Location = new System.Drawing.Point(401, 222);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(100, 20);
            this.txtWaga.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dzienne zapotrzebowanie na kalorie:";
            // 
            // labelKalZap
            // 
            this.labelKalZap.AutoSize = true;
            this.labelKalZap.Location = new System.Drawing.Point(189, 73);
            this.labelKalZap.Name = "labelKalZap";
            this.labelKalZap.Size = new System.Drawing.Size(66, 13);
            this.labelKalZap.TabIndex = 17;
            this.labelKalZap.Text = "Nie ustalono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBloZap);
            this.groupBox1.Controls.Add(this.labelTluZap);
            this.groupBox1.Controls.Add(this.labelWegZap);
            this.groupBox1.Controls.Add(this.labelBiaZap);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.checkBoxM);
            this.groupBox1.Controls.Add(this.checkBoxD);
            this.groupBox1.Controls.Add(this.checkBoxU);
            this.groupBox1.Controls.Add(this.labelKalZap);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 144);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kliknij oblicz aby obliczyć i zapisać";
            // 
            // labelBloZap
            // 
            this.labelBloZap.AutoSize = true;
            this.labelBloZap.Location = new System.Drawing.Point(197, 118);
            this.labelBloZap.Name = "labelBloZap";
            this.labelBloZap.Size = new System.Drawing.Size(28, 13);
            this.labelBloZap.TabIndex = 34;
            this.labelBloZap.Text = "brak";
            // 
            // labelTluZap
            // 
            this.labelTluZap.AutoSize = true;
            this.labelTluZap.Location = new System.Drawing.Point(197, 97);
            this.labelTluZap.Name = "labelTluZap";
            this.labelTluZap.Size = new System.Drawing.Size(28, 13);
            this.labelTluZap.TabIndex = 33;
            this.labelTluZap.Text = "brak";
            // 
            // labelWegZap
            // 
            this.labelWegZap.AutoSize = true;
            this.labelWegZap.Location = new System.Drawing.Point(89, 118);
            this.labelWegZap.Name = "labelWegZap";
            this.labelWegZap.Size = new System.Drawing.Size(28, 13);
            this.labelWegZap.TabIndex = 32;
            this.labelWegZap.Text = "brak";
            // 
            // labelBiaZap
            // 
            this.labelBiaZap.AutoSize = true;
            this.labelBiaZap.Location = new System.Drawing.Point(56, 97);
            this.labelBiaZap.Name = "labelBiaZap";
            this.labelBiaZap.Size = new System.Drawing.Size(28, 13);
            this.labelBiaZap.TabIndex = 31;
            this.labelBiaZap.Text = "brak";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "tłuszcz:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "węglowodany:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "białko:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Zaznacz aktywność fizyczną aby obliczyć";
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(40, 44);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(50, 17);
            this.checkBoxM.TabIndex = 27;
            this.checkBoxM.Text = "mała";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(206, 44);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(49, 17);
            this.checkBoxD.TabIndex = 29;
            this.checkBoxD.Text = "duża";
            this.checkBoxD.UseVisualStyleBackColor = true;
            this.checkBoxD.CheckedChanged += new System.EventHandler(this.checkBoxD_CheckedChanged);
            // 
            // checkBoxU
            // 
            this.checkBoxU.AutoSize = true;
            this.checkBoxU.Location = new System.Drawing.Point(101, 44);
            this.checkBoxU.Name = "checkBoxU";
            this.checkBoxU.Size = new System.Drawing.Size(89, 17);
            this.checkBoxU.TabIndex = 28;
            this.checkBoxU.Text = "umiarkowana";
            this.checkBoxU.UseVisualStyleBackColor = true;
            this.checkBoxU.CheckedChanged += new System.EventHandler(this.checkBoxU_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxMezczyzna);
            this.groupBox2.Controls.Add(this.checkBoxKobieta);
            this.groupBox2.Location = new System.Drawing.Point(330, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 195);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dane fizyczne";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(330, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 116);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "dane konta";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "pokaż hasło";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnZapiszZmiany
            // 
            this.btnZapiszZmiany.Location = new System.Drawing.Point(359, 335);
            this.btnZapiszZmiany.Name = "btnZapiszZmiany";
            this.btnZapiszZmiany.Size = new System.Drawing.Size(142, 42);
            this.btnZapiszZmiany.TabIndex = 21;
            this.btnZapiszZmiany.Text = "Zapisz zmiany";
            this.btnZapiszZmiany.UseVisualStyleBackColor = true;
            this.btnZapiszZmiany.Click += new System.EventHandler(this.btnZapiszZmiany_Click);
            // 
            // btnWroc
            // 
            this.btnWroc.Location = new System.Drawing.Point(24, 428);
            this.btnWroc.Name = "btnWroc";
            this.btnWroc.Size = new System.Drawing.Size(243, 32);
            this.btnWroc.TabIndex = 22;
            this.btnWroc.Text = "Wróć do logowania";
            this.btnWroc.UseVisualStyleBackColor = true;
            this.btnWroc.Click += new System.EventHandler(this.btnWroc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Zalogowano jako: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "label11";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(156, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "błonnik:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnZapiszZapotrzebowanie);
            this.groupBox4.Controls.Add(this.txtBlonnikObl);
            this.groupBox4.Controls.Add(this.txtTluszczObl);
            this.groupBox4.Controls.Add(this.txtWeglowObl);
            this.groupBox4.Controls.Add(this.txtBialkoObl);
            this.groupBox4.Controls.Add(this.txtKalorieObl);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 109);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wpisz zapotrzebowanie wg. siebie:";
            // 
            // btnZapiszZapotrzebowanie
            // 
            this.btnZapiszZapotrzebowanie.Location = new System.Drawing.Point(159, 80);
            this.btnZapiszZapotrzebowanie.Name = "btnZapiszZapotrzebowanie";
            this.btnZapiszZapotrzebowanie.Size = new System.Drawing.Size(138, 23);
            this.btnZapiszZapotrzebowanie.TabIndex = 11;
            this.btnZapiszZapotrzebowanie.Text = "zapisz";
            this.btnZapiszZapotrzebowanie.UseVisualStyleBackColor = true;
            this.btnZapiszZapotrzebowanie.Click += new System.EventHandler(this.btnZapiszZapotrzebowanie_Click);
            // 
            // txtBlonnikObl
            // 
            this.txtBlonnikObl.Location = new System.Drawing.Point(226, 51);
            this.txtBlonnikObl.Name = "txtBlonnikObl";
            this.txtBlonnikObl.Size = new System.Drawing.Size(36, 20);
            this.txtBlonnikObl.TabIndex = 10;
            // 
            // txtTluszczObl
            // 
            this.txtTluszczObl.Location = new System.Drawing.Point(226, 25);
            this.txtTluszczObl.Name = "txtTluszczObl";
            this.txtTluszczObl.Size = new System.Drawing.Size(36, 20);
            this.txtTluszczObl.TabIndex = 9;
            // 
            // txtWeglowObl
            // 
            this.txtWeglowObl.Location = new System.Drawing.Point(101, 74);
            this.txtWeglowObl.Name = "txtWeglowObl";
            this.txtWeglowObl.Size = new System.Drawing.Size(34, 20);
            this.txtWeglowObl.TabIndex = 8;
            // 
            // txtBialkoObl
            // 
            this.txtBialkoObl.Location = new System.Drawing.Point(101, 48);
            this.txtBialkoObl.Name = "txtBialkoObl";
            this.txtBialkoObl.Size = new System.Drawing.Size(34, 20);
            this.txtBialkoObl.TabIndex = 7;
            // 
            // txtKalorieObl
            // 
            this.txtKalorieObl.Location = new System.Drawing.Point(83, 22);
            this.txtKalorieObl.Name = "txtKalorieObl";
            this.txtKalorieObl.Size = new System.Drawing.Size(52, 20);
            this.txtKalorieObl.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(168, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "błonnik:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(170, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "tłuszcz:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "węglowodany:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "białko:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "kalorie:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(226, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "użyj";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxKobieta
            // 
            this.checkBoxKobieta.AutoSize = true;
            this.checkBoxKobieta.Enabled = false;
            this.checkBoxKobieta.Location = new System.Drawing.Point(78, 130);
            this.checkBoxKobieta.Name = "checkBoxKobieta";
            this.checkBoxKobieta.Size = new System.Drawing.Size(61, 17);
            this.checkBoxKobieta.TabIndex = 32;
            this.checkBoxKobieta.Text = "kobieta";
            this.checkBoxKobieta.UseVisualStyleBackColor = true;
            this.checkBoxKobieta.CheckedChanged += new System.EventHandler(this.checkBoxKobieta_CheckedChanged);
            // 
            // checkBoxMezczyzna
            // 
            this.checkBoxMezczyzna.AutoSize = true;
            this.checkBoxMezczyzna.Enabled = false;
            this.checkBoxMezczyzna.Location = new System.Drawing.Point(78, 156);
            this.checkBoxMezczyzna.Name = "checkBoxMezczyzna";
            this.checkBoxMezczyzna.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMezczyzna.TabIndex = 33;
            this.checkBoxMezczyzna.Text = "mężczyzna";
            this.checkBoxMezczyzna.UseVisualStyleBackColor = true;
            this.checkBoxMezczyzna.CheckedChanged += new System.EventHandler(this.checkBoxMezczyzna_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 472);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnWroc);
            this.Controls.Add(this.btnZapiszZmiany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.txtWiek);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObliczBMI);
            this.Controls.Add(this.btnOblZap);
            this.Controls.Add(this.btnZmien);
            this.Controls.Add(this.btnUsunKonto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form4";
            this.Text = "Zarządzanie swoim kontem";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsunKonto;
        private System.Windows.Forms.Button btnZmien;
        private System.Windows.Forms.Button btnOblZap;
        private System.Windows.Forms.Button btnObliczBMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.TextBox txtWiek;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelKalZap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnZapiszZmiany;
        private System.Windows.Forms.Button btnWroc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxU;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelBloZap;
        private System.Windows.Forms.Label labelTluZap;
        private System.Windows.Forms.Label labelWegZap;
        private System.Windows.Forms.Label labelBiaZap;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBlonnikObl;
        private System.Windows.Forms.TextBox txtTluszczObl;
        private System.Windows.Forms.TextBox txtWeglowObl;
        private System.Windows.Forms.TextBox txtBialkoObl;
        private System.Windows.Forms.TextBox txtKalorieObl;
        private System.Windows.Forms.Button btnZapiszZapotrzebowanie;
        private System.Windows.Forms.CheckBox checkBoxKobieta;
        private System.Windows.Forms.CheckBox checkBoxMezczyzna;
    }
}
namespace WindowsFormsApplication2
{
    partial class Form5
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelKal = new System.Windows.Forms.Label();
            this.labelBia = new System.Windows.Forms.Label();
            this.labelWeg = new System.Windows.Forms.Label();
            this.labelTlu = new System.Windows.Forms.Label();
            this.labelBlo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelKalOgu = new System.Windows.Forms.Label();
            this.labelBiaOgu = new System.Windows.Forms.Label();
            this.labelWegOgu = new System.Windows.Forms.Label();
            this.labelTluOgu = new System.Windows.Forms.Label();
            this.labelBloOgu = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(605, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(70, 238);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(104, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(315, 238);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ten posiłek zaspokoił:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "kaloryczność:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "białko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "węglowodany:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "tłuszcz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kliknij na datę";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wybierz dzień:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Zawartość:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "błonnik:";
            // 
            // labelKal
            // 
            this.labelKal.AutoSize = true;
            this.labelKal.Location = new System.Drawing.Point(602, 129);
            this.labelKal.Name = "labelKal";
            this.labelKal.Size = new System.Drawing.Size(16, 13);
            this.labelKal.TabIndex = 16;
            this.labelKal.Text = "...";
            // 
            // labelBia
            // 
            this.labelBia.AutoSize = true;
            this.labelBia.Location = new System.Drawing.Point(602, 162);
            this.labelBia.Name = "labelBia";
            this.labelBia.Size = new System.Drawing.Size(16, 13);
            this.labelBia.TabIndex = 17;
            this.labelBia.Text = "...";
            // 
            // labelWeg
            // 
            this.labelWeg.AutoSize = true;
            this.labelWeg.Location = new System.Drawing.Point(602, 197);
            this.labelWeg.Name = "labelWeg";
            this.labelWeg.Size = new System.Drawing.Size(16, 13);
            this.labelWeg.TabIndex = 18;
            this.labelWeg.Text = "...";
            // 
            // labelTlu
            // 
            this.labelTlu.AutoSize = true;
            this.labelTlu.Location = new System.Drawing.Point(602, 228);
            this.labelTlu.Name = "labelTlu";
            this.labelTlu.Size = new System.Drawing.Size(16, 13);
            this.labelTlu.TabIndex = 19;
            this.labelTlu.Text = "...";
            // 
            // labelBlo
            // 
            this.labelBlo.AutoSize = true;
            this.labelBlo.Location = new System.Drawing.Point(602, 259);
            this.labelBlo.Name = "labelBlo";
            this.labelBlo.Size = new System.Drawing.Size(16, 13);
            this.labelBlo.TabIndex = 20;
            this.labelBlo.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ogólnie w tym dniu:";
            // 
            // labelKalOgu
            // 
            this.labelKalOgu.AutoSize = true;
            this.labelKalOgu.Location = new System.Drawing.Point(682, 129);
            this.labelKalOgu.Name = "labelKalOgu";
            this.labelKalOgu.Size = new System.Drawing.Size(16, 13);
            this.labelKalOgu.TabIndex = 22;
            this.labelKalOgu.Text = "...";
            // 
            // labelBiaOgu
            // 
            this.labelBiaOgu.AutoSize = true;
            this.labelBiaOgu.Location = new System.Drawing.Point(682, 162);
            this.labelBiaOgu.Name = "labelBiaOgu";
            this.labelBiaOgu.Size = new System.Drawing.Size(16, 13);
            this.labelBiaOgu.TabIndex = 23;
            this.labelBiaOgu.Text = "...";
            // 
            // labelWegOgu
            // 
            this.labelWegOgu.AutoSize = true;
            this.labelWegOgu.Location = new System.Drawing.Point(682, 197);
            this.labelWegOgu.Name = "labelWegOgu";
            this.labelWegOgu.Size = new System.Drawing.Size(16, 13);
            this.labelWegOgu.TabIndex = 24;
            this.labelWegOgu.Text = "...";
            // 
            // labelTluOgu
            // 
            this.labelTluOgu.AutoSize = true;
            this.labelTluOgu.Location = new System.Drawing.Point(682, 228);
            this.labelTluOgu.Name = "labelTluOgu";
            this.labelTluOgu.Size = new System.Drawing.Size(16, 13);
            this.labelTluOgu.TabIndex = 25;
            this.labelTluOgu.Text = "...";
            // 
            // labelBloOgu
            // 
            this.labelBloOgu.AutoSize = true;
            this.labelBloOgu.Location = new System.Drawing.Point(682, 259);
            this.labelBloOgu.Name = "labelBloOgu";
            this.labelBloOgu.Size = new System.Drawing.Size(16, 13);
            this.labelBloOgu.TabIndex = 26;
            this.labelBloOgu.Text = "...";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(436, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(47, 238);
            this.listBox3.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ilość:";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(522, 31);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(52, 41);
            this.btnUsun.TabIndex = 29;
            this.btnUsun.Text = "usuń wpis";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "wczytaj dzień";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.labelBloOgu);
            this.Controls.Add(this.labelTluOgu);
            this.Controls.Add(this.labelWegOgu);
            this.Controls.Add(this.labelBiaOgu);
            this.Controls.Add(this.labelKalOgu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelBlo);
            this.Controls.Add(this.labelTlu);
            this.Controls.Add(this.labelWeg);
            this.Controls.Add(this.labelBia);
            this.Controls.Add(this.labelKal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form5";
            this.Text = " Historia posiłków";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelKal;
        private System.Windows.Forms.Label labelBia;
        private System.Windows.Forms.Label labelWeg;
        private System.Windows.Forms.Label labelTlu;
        private System.Windows.Forms.Label labelBlo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelKalOgu;
        private System.Windows.Forms.Label labelBiaOgu;
        private System.Windows.Forms.Label labelWegOgu;
        private System.Windows.Forms.Label labelTluOgu;
        private System.Windows.Forms.Label labelBloOgu;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button button1;
    }
}
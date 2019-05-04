using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Form4(string UsrName)
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Loginy.accdb;Persist Security Info=False;";
            label9.Text = UsrName;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ///////////////////////////////Szukanie po loginie który to użytkownik, i wyciągnięcie z bazy jego danych
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "SELECT * FROM Loginy WHERE Login = '" + label9.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //dane konta
                    txtLogin.Text = reader["Login"].ToString();
                    txtHaslo.Text = reader["Haslo"].ToString();
                    plec = reader["Płeć"].ToString();
                    if (plec == "Kobieta")
                    {
                        checkBoxKobieta.Checked = true;
                        checkBoxMezczyzna.Checked = false;
                    }
                    if (plec == "Mężczyzna")
                    {
                        checkBoxMezczyzna.Checked = true;
                        checkBoxKobieta.Checked = false;
                    }
                    txtWaga.Text = reader["Waga"].ToString();
                    txtWiek.Text = reader["Wiek"].ToString();
                    txtWzrost.Text = reader["Wzrost"].ToString();
                    label11.Text = reader["Identyfikator"].ToString();
                    //dane zapotrzebowań
                    labelKalZap.Text = reader["Zapotrzebowanie_kalorie"].ToString();
                    labelBiaZap.Text = reader["Zapotrzebowanie_białko"].ToString();
                    labelBloZap.Text = reader["Zapotrzebowanie_błonnik"].ToString();
                    labelTluZap.Text = reader["Zapotrzebowanie_tłuszcz"].ToString();
                    labelWegZap.Text = reader["Zapotrzebowanie_węglowodany"].ToString();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
            if (labelKalZap.Text == "0")  ///Wpisywanie "nie ustalono" jak w bazie jest domyślne 0 zapotrzebowania
                labelKalZap.Text = "Nie ustalono";

            if (labelWegZap.Text == "0") labelWegZap.Text = "brak"; //to samo tylko wpisane "brak"
            if (labelBloZap.Text == "0") labelBloZap.Text = "brak";
            if (labelBiaZap.Text == "0") labelBiaZap.Text = "brak";
            if (labelTluZap.Text == "0") labelTluZap.Text = "brak";

            ////////domyślnie wyłączone korzystanie z wpisanych wartości zmiast obliczonych zapotrzebowań////
            txtKalorieObl.Enabled = false;
            txtBialkoObl.Enabled = false;
            txtBlonnikObl.Enabled = false;
            txtTluszczObl.Enabled = false;
            txtWeglowObl.Enabled = false;
            btnZapiszZapotrzebowanie.Visible = false;
        }

        public string plec; //zczytuje płeć użytkownika i ustawienia checkBoxów

        private void btnZmien_Click(object sender, EventArgs e)
        {
            //////////////////////////////odblokowywanie textBoxów do zmienienia danych///////////
            txtLogin.Enabled = true;
            txtHaslo.Enabled = true;
            checkBoxKobieta.Enabled = true;
            checkBoxMezczyzna.Enabled = true;
            txtWaga.Enabled = true;
            txtWiek.Enabled = true;
            txtWzrost.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //zakrywanie i odkrywanie hasła//////////
        {
            txtHaslo.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }


        private void btnZapiszZmiany_Click(object sender, EventArgs e)  ///////////zapisanie zmienionych danych//////
        {
            if (checkBoxKobieta.Checked == true)
                plec = "Kobieta";
            if (checkBoxMezczyzna.Checked == true)
                plec = "Mężczyzna";

            try    /////////////zrobić checkBox zamiast textBox do płci
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "UPDATE Loginy SET Waga = '" + txtWaga.Text + "' ,Wiek = '"+txtWiek.Text+"' ,Wzrost = '"+txtWzrost.Text+"' ,Płeć = '"+plec+"' ,Haslo = '"+txtHaslo.Text+"' ,Login = '"+txtLogin.Text+"' WHERE Identyfikator = " + label11.Text + " ";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Zmieniono dane.");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
        }

        private void btnWroc_Click(object sender, EventArgs e)  ////////////////powrót do logowania///////
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnUsunKonto_Click(object sender, EventArgs e) //////////////Usuwanie konta zalogowanego użytkownika////
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "DELETE FROM Loginy WHERE Identyfikator = " + label11.Text + " ";
                //MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Konto zostało usunięte.");
                connect.Close();
                //////////////wyjście po usunięciu konta do logowania z powrotem////////////
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
        }

        private void btnObliczBMI_Click(object sender, EventArgs e) 
        {
            /////obliczanie BMI i wyświetlenie w charakterze informacyjnym na messageboxie//////
            double waga = Convert.ToDouble(txtWaga.Text);
            double wzrost = Convert.ToDouble(txtWzrost.Text);
            double bmi = waga / ((wzrost/100) * (wzrost/100));
            string status = "";
            if (bmi <= 20) status = "niedowaga";
            if (bmi > 20 && bmi<=25) status = "prawidłowo";
            if (bmi > 25 && bmi<=30) status = "nadwaga";
            if (bmi > 30) status = "otyłość";

            MessageBox.Show("Twój współczynnik BMI wynosi: "+bmi+". Status: "+status);
        }
         /// żeby checkBoxy nie były na raz zaznaczone/////////

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxU.Checked = false;
            checkBoxD.Checked = false;
        }

        private void checkBoxU_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxM.Checked = false;
            checkBoxD.Checked = false;
        }

        private void checkBoxD_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxU.Checked = false;
            checkBoxM.Checked = false;
        }
                //checkBoxy płci
        private void checkBoxKobieta_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMezczyzna.Checked = false;
            plec = "Kobieta";
        }

        private void checkBoxMezczyzna_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKobieta.Checked = false;
            plec = "Mężczyzna";
        }

        /// ///////////////////////////////////////////////////////////////////////////


        private void btnOblZap_Click(object sender, EventArgs e)
        {   
            /////czy jeden z poziomów aktywności jest zaznaczony//////
            bool poprawnieZaznaczone = false;
            if (checkBoxU.Checked == true || checkBoxM.Checked == true || checkBoxD.Checked == true)
                poprawnieZaznaczone = true;

            if (poprawnieZaznaczone == false)
                MessageBox.Show("Zaznacz poziom aktywności fizycznej.");
            else
            {
                //obliczenia
                double zapotrzebowanie = 0;    //chodzi o kalorie
                double zapotrzebowanieBia = 0;
                double zapotrzebowanieBlo = 0;
                double zapotrzebowanieTlu = 0;
                double zapotrzebowanieWeg = 0;
                int waga = Convert.ToInt16(txtWaga.Text);
                int wzrost = Convert.ToInt16(txtWzrost.Text);
                int wiek = Convert.ToInt16(txtWiek.Text);
                double poziomAktywnosci = 0;

                if (checkBoxM.Checked == true)      //poziomy aktywność odzwierciedlają checkBoxy
                    poziomAktywnosci = 1.4;
                if (checkBoxU.Checked == true)
                    poziomAktywnosci = 1.7;
                if (checkBoxD.Checked == true)
                    poziomAktywnosci = 2;

                //kalorie - obliczenia
                if (plec == "Mężczyzna")    //wzory oddzielne dla każdej płci
                {
                    zapotrzebowanie = 66.5 + ((13.75 * waga) + (5.003 * wzrost)) + (6.775 * wiek);
                }
                if (plec == "Kobieta")
                {
                    zapotrzebowanie = 655.1+((9.563 * waga)+(1.85 * wzrost))-(4.676 * wiek);
                }
                zapotrzebowanie = zapotrzebowanie * poziomAktywnosci;
                zapotrzebowanie = Math.Round(zapotrzebowanie,0);
                labelKalZap.Text = zapotrzebowanie.ToString();

                //białko - obliczenia
                double srednia = 0;
                if (checkBoxM.Checked == true)
                    srednia = (0.65 + 0.83)/2;    //średnia z przedziału min i max
                if (checkBoxU.Checked == true)
                    srednia = (1.3 + 1.7)/2;
                if (checkBoxD.Checked == true)
                    srednia = (2 + 3)/2;
                zapotrzebowanieBia = srednia * waga;
                zapotrzebowanieBia = Math.Round(zapotrzebowanieBia, 2);
                labelBiaZap.Text = zapotrzebowanieBia.ToString();

                //węglowodany - obliczenia
                zapotrzebowanieWeg = ((zapotrzebowanie/100)*57.5)/4;
                zapotrzebowanieWeg = Math.Round(zapotrzebowanieWeg, 2);
                labelWegZap.Text = zapotrzebowanieWeg.ToString();

                //tłuszcze - obliczenia
                zapotrzebowanieTlu = (zapotrzebowanie * 0.3) / 9;
                zapotrzebowanieTlu = Math.Round(zapotrzebowanieTlu, 2);
                labelTluZap.Text = zapotrzebowanieTlu.ToString();

                //błonnik - obliczenia
                zapotrzebowanieBlo = (zapotrzebowanie / 1000) * 14;
                zapotrzebowanieBlo = Math.Round(zapotrzebowanieBlo, 2);
                labelBloZap.Text = zapotrzebowanieBlo.ToString();

                    ////////////po obliczeniu zapotrzebowania na kalorie do bazy zostaje zapisany wynik////////
                try
                {
                    connect.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connect;
                    string query = "UPDATE Loginy SET Zapotrzebowanie_kalorie = '" + labelKalZap.Text + "' ,Zapotrzebowanie_białko = '" + labelBiaZap.Text + "' ,Zapotrzebowanie_błonnik = '" + labelBloZap.Text + "' ,Zapotrzebowanie_tłuszcz = '" + labelTluZap.Text + "' ,Zapotrzebowanie_węglowodany = '" + labelWegZap.Text + "'  WHERE Identyfikator = " + label11.Text + " ";
                    command.CommandText = query;

                    command.ExecuteNonQuery();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad " + ex);
                }

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //używanie wpisanych wartości zamiast obliczeń
        {
            if (checkBox2.Checked == true)
            {
                txtKalorieObl.Enabled = true;
                txtBialkoObl.Enabled = true;
                txtBlonnikObl.Enabled = true;
                txtTluszczObl.Enabled = true;
                txtWeglowObl.Enabled = true;
                btnZapiszZapotrzebowanie.Visible = true;
            }
            else
            {
                txtKalorieObl.Enabled = false;
                txtBialkoObl.Enabled = false;
                txtBlonnikObl.Enabled = false;
                txtTluszczObl.Enabled = false;
                txtWeglowObl.Enabled = false;
                btnZapiszZapotrzebowanie.Visible = false;
            }
        }

        private void btnZapiszZapotrzebowanie_Click(object sender, EventArgs e) //zapisz zapotrzebowanie wpisane samemu
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "UPDATE Loginy SET Zapotrzebowanie_kalorie = '" + txtKalorieObl.Text + "' ,Zapotrzebowanie_białko = '" + txtBialkoObl.Text + "' ,Zapotrzebowanie_błonnik = '" + txtBlonnikObl.Text + "' ,Zapotrzebowanie_tłuszcz = '" + txtTluszczObl.Text + "' ,Zapotrzebowanie_węglowodany = '" + txtWeglowObl.Text + "'  WHERE Identyfikator = " + label11.Text + " ";
                command.CommandText = query;

                command.ExecuteNonQuery();
                connect.Close();
                labelKalZap.Text = txtKalorieObl.Text;
                labelTluZap.Text = txtTluszczObl.Text;
                labelBiaZap.Text = txtBialkoObl.Text;
                labelBloZap.Text = txtBlonnikObl.Text;
                labelWegZap.Text = txtWeglowObl.Text;
                MessageBox.Show("Zmodyfikowane dane zapotrzebowania wprowadzone.","Uwaga");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
        }



    }
}

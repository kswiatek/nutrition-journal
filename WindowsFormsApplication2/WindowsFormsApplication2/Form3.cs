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
    public partial class Form3 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        private OleDbConnection connect2 = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Loginy.accdb;Persist Security Info=False;";
            connect2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Produkty.accdb;Persist Security Info=False;";

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //////////////////wczytanie kategorii i produktów do listboxów po prawej///////
            //kategorie
            try
            {
                DataTable userTables = null;
                string[] restrictions = new string[4];
                restrictions[3] = "Table";
                connect2.Open();
                userTables = connect2.GetSchema("Tables", restrictions);

                for (int i = 0; i < userTables.Rows.Count; i++)
                    listBox1.Items.Add(userTables.Rows[i][2].ToString());
                connect2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
        }

        public string plec = "";
        public string alergeny = "";

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ///////////////////////////////zapisanie w linijce alergeny////////////oddzielając * ///////////////

            int ileProduktow = listBox3.Items.Count - 1;
            for (int i = ileProduktow; i >= 0; i--)
            {
                if (listBox3.Items[i].ToString() != "")
                {
                    alergeny += listBox3.Items[i].ToString() + "*";
                }
            }

            ///////////////////////////////////////////////////////////

            bool poprawnie = true;
            bool hasloTakieSame = true;
            bool loginNieIstnieje = true;
            ///////////////zabezpieczenia przed pustymi danymi/////////////////////////////////////////////
            if (checkBoxK.Checked == false && checkBoxM.Checked == false)
                poprawnie = false;
            if (txtLog.Text == null || txtHas.Text == null || txtWie.Text == null || txtWzr.Text == null || txtWag.Text == null)
                poprawnie = false;
            try //żeby nie było błędu, że się nie da na liczbę
            {
            if (Convert.ToInt16(txtWie.Text) > 200 || Convert.ToInt16(txtWie.Text) <= 0)
                poprawnie = false;
            if (Convert.ToInt16(txtWag.Text) > 500 || Convert.ToInt16(txtWag.Text) <= 0)
                poprawnie = false;
            if (Convert.ToInt16(txtWzr.Text) > 500 || Convert.ToInt16(txtWzr.Text) <= 0)
                poprawnie = false;
            }
                catch
            {
                poprawnie = false;
            }

                if (poprawnie == false)
                    MessageBox.Show("Wypełnij poprawnie wszystkie dane.");

                if (txtHas.Text != txtHas2.Text)
                    hasloTakieSame = false;
            if(hasloTakieSame == false)
                MessageBox.Show("Hasła się nie zgadzają.");
            ////////////////zabezpieczenie przed takim samym loginem już istniejącym w bazie/////////////////
            string loginwpisany = null;

            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "SELECT * FROM Loginy WHERE Login = '" + txtLog.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    loginwpisany = reader["Login"].ToString();
                }
                connect.Close();
            }
            catch
            {
                //jak nie znaleziono w bazie to dobrze
            }

            if (loginwpisany != null)
                loginNieIstnieje = false;

            //////////////////////////////////////////////////////////////////////////
            if (poprawnie && hasloTakieSame && loginNieIstnieje)
            {
                if (checkBoxK.Checked == true)  /////trzeba sprawdzić czy już taki jest w bazie,
                    //////to samo z produktami w form2
                    plec = "Kobieta";
                if (checkBoxM.Checked == true)
                    plec = "Mężczyzna";
                try
                {
                    connect.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connect;
                    command.CommandText = "INSERT INTO Loginy (Login, Haslo, Wiek, Wzrost, Waga, Płeć, Alergeny) VALUES('" + txtLog.Text + "','" + txtHas.Text + "','" + txtWie.Text + "','" + txtWzr.Text + "','" + txtWag.Text + "','" + plec + "','" + alergeny + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Dodano użytkownika poprawnie.");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad " + ex);
                }
            }
            else if (loginNieIstnieje == false)
                MessageBox.Show("Taki użytkownik już istnieje.","Nie można wykonać operacji.");
        }

        private void btnWroc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void checkBoxK_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxM.Checked = false;
        }

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxK.Checked = false;
        }


//////////// ///////////////////////////////////////////////////////////////////////////////////////////////
        public int nrTabeli = 0;    //którą tabelę wybraliśmy w listBoxie wyżej

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //kliknięcie na kategorię pokazuje niżej produkty
        {
            if (listBox1.Text == "Dania_fast_food_KFC")
                nrTabeli = 1;
            if (listBox1.Text == "Dania_fast_food_MC")
                nrTabeli = 2;
            if (listBox1.Text == "Drób")
                nrTabeli = 3;
            if (listBox1.Text == "Grzyby")
                nrTabeli = 4;
            if (listBox1.Text == "Jaja")
                nrTabeli = 5;
            if (listBox1.Text == "Mięso")
                nrTabeli = 6;
            if (listBox1.Text == "Mleko_i_przetwory_mleczne")
                nrTabeli = 7;
            if (listBox1.Text == "Napoje_alkoholowe")
                nrTabeli = 8;
            if (listBox1.Text == "Napoje_bezalkoholowe")
                nrTabeli = 9;
            if (listBox1.Text == "Orzechy")
                nrTabeli = 10;
            if (listBox1.Text == "Owoce")
                nrTabeli = 11;
            if (listBox1.Text == "Produkty_zbożowe")
                nrTabeli = 12;
            if (listBox1.Text == "Przyprawy")
                nrTabeli = 13;
            if (listBox1.Text == "Ryby")
                nrTabeli = 14;
            if (listBox1.Text == "Słodycze")
                nrTabeli = 15;
            if (listBox1.Text == "Tłuszcze")
                nrTabeli = 16;
            if (listBox1.Text == "Warzywa")
                nrTabeli = 17;
            if (listBox1.Text == "Wędliny")
                nrTabeli = 18;


            try        ////////z której kategorii mamy wyświetlać dostępne produkty
            {
                connect2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect2;
                string query = "SELECT * FROM Grzyby";
                if (nrTabeli == 1)
                { query = "SELECT * FROM Dania_fast_food_KFC"; }
                if (nrTabeli == 2)
                { query = "SELECT * FROM Dania_fast_food_MC"; }
                if (nrTabeli == 3)
                { query = "SELECT * FROM Drób"; }
                if (nrTabeli == 4)
                { query = "SELECT * FROM Grzyby"; }
                if (nrTabeli == 5)
                { query = "SELECT * FROM Jaja"; }
                if (nrTabeli == 6)
                { query = "SELECT * FROM Mięso"; }
                if (nrTabeli == 7)
                { query = "SELECT * FROM Mleko_i_przetwory_mleczne"; }
                if (nrTabeli == 8)
                { query = "SELECT * FROM Napoje_alkoholowe"; }
                if (nrTabeli == 9)
                { query = "SELECT * FROM Napoje_bezalkoholowe"; }
                if (nrTabeli == 10)
                { query = "SELECT * FROM Orzechy"; }
                if (nrTabeli == 11)
                { query = "SELECT * FROM Owoce"; }
                if (nrTabeli == 12)
                { query = "SELECT * FROM Produkty_zbożowe"; }
                if (nrTabeli == 13)
                { query = "SELECT * FROM Przyprawy"; }
                if (nrTabeli == 14)
                { query = "SELECT * FROM Ryby"; }
                if (nrTabeli == 15)
                { query = "SELECT * FROM Słodycze"; }
                if (nrTabeli == 16)
                { query = "SELECT * FROM Tłuszcze"; }
                if (nrTabeli == 17)
                { query = "SELECT * FROM Warzywa"; }
                if (nrTabeli == 18)
                { query = "SELECT * FROM Wędliny"; }
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                listBox2.Items.Clear();
                while (reader.Read())
                {
                    listBox2.Items.Add(reader["Produkt"].ToString());
                }
                connect2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
        }

        public string linijkaAlergenow = "";

        private void btnAlergen_Click(object sender, EventArgs e) //dodawanie do alergennych z wybranych produktów
        {            

            int ileProduktow = listBox2.Items.Count - 1;
            for (int i = ileProduktow; i >= 0; i--)
            {
                if (listBox2.GetSelected(i))
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void btnWyszukaj_Click(object sender, EventArgs e) //pomoc przy wyszukiwaniu prod. do dodania do alergennych
        {
            listBox2.SelectedItems.Clear();
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.Items[i].ToString().ToLower().Contains(txtBoxSzukaj.Text.ToLower()))
                    listBox2.SetSelected(i, true);
            }
            lblSzukaj.Text = "Znaleziono " + listBox2.SelectedItems.Count.ToString() + " produktów";
        }



    }
}

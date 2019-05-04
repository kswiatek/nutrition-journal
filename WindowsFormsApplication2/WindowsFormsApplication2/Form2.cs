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
    public partial class Form2 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        private OleDbConnection connect2 = new OleDbConnection();
        private OleDbConnection connect3 = new OleDbConnection();
        public Form2(string userName)
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Produkty.accdb;Persist Security Info=False;";
            connect2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Dni.accdb;Persist Security Info=False;";
            connect3.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Loginy.accdb;Persist Security Info=False;";


            label9.Text = "Witaj użytkowniku: ";
            label10.Text = userName;
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label6.Text = "Nie odnaleziono bazy danych.";
            txtID.Enabled = false;

            try
            {
                connect.Open();
                label6.Text = "Baza danych wczytana prawidlowo.";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }

            ////////////////////////////////////////////
            //////////////////wczytanie kategorii i produktów do listboxów po prawej///////
            //kategorie
           try
            {
                DataTable userTables = null;
                string[] restrictions = new string[4];
                restrictions[3] = "Table";
                connect.Open();
                userTables = connect.GetSchema("Tables", restrictions);

                for (int i = 0; i < userTables.Rows.Count; i++)
                    listBox2.Items.Add(userTables.Rows[i][2].ToString());
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
            ///////////////////
            ///////wczytywanie zapotrzebowania użytkownika
           try
            {
                connect3.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect3;
                string query = "SELECT * FROM Loginy WHERE Login = '" + label10.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    zapotrzebowanieKal = reader["Zapotrzebowanie_kalorie"].ToString();
                    zapotrzebowanieBia = reader["Zapotrzebowanie_białko"].ToString();
                    zapotrzebowanieBlo = reader["Zapotrzebowanie_błonnik"].ToString();
                    zapotrzebowanieWeg = reader["Zapotrzebowanie_węglowodany"].ToString();
                    zapotrzebowanieTlu = reader["Zapotrzebowanie_tłuszcz"].ToString();
                }
                connect3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex);
            }

        /////////////////////////
        ////Wczytanie i dodanie z bazy zaspokojonych wartości z wszystkich wpisów z dzisiejszego dnia
           DateTime dateTime = DateTime.Now;
           this.labelDate.Text = dateTime.ToString();

           wczytywanieOgolnychZas(); //ładuje z bazy zapotrzebowania z obecnego dnia

           ostrzeganieProcenty(true); //zlicza zaspokojone zap. i porównuje z dodanymi wartościami, czy nie przekraczają

           if (labelProcentKal.Text == "nie jest liczbą%") //gdy loguje się 1st raz
               MessageBox.Show("Udaj się do zarządzania swoim kontem aby ustalić swoje zapotrzebowannie na makroelementy.","Witaj po raz pierwszy w programie!");
        }


        public double oguZkal = 0;
        public double oguZbia = 0;
        public double oguZblo = 0;
        public double oguZtlu = 0;
        public double oguZweg = 0;

        public void wczytywanieOgolnychZas()
        {
            try
            {
                string[] podzial;
                podzial = new string[10];
                podzial = labelDate.Text.Split(' ');
                string uzytkownik;
                string dataZbazy;
                string[] podzial2;
                podzial2 = new string[10];

                connect2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect2;
                string query = "SELECT * FROM Dni ";
                //MessageBox.Show(query);
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    uzytkownik = reader["LoginKto"].ToString();
                    dataZbazy = reader["Data"].ToString();

                    podzial2 = dataZbazy.Split(' ');

                    if (uzytkownik == label10.Text && podzial2[0] == podzial[0])
                    {
                        oguZkal += Convert.ToDouble(reader["zasKaloryczność"]);
                        oguZbia += Convert.ToDouble(reader["zasBiałko"]);
                        oguZblo += Convert.ToDouble(reader["zasBłonnik"]);
                        oguZtlu += Convert.ToDouble(reader["zasTłuszcz"]);
                        oguZweg += Convert.ToDouble(reader["zasWęglowodany"]);

                    }
                }

                txtZkalOgu.Text = oguZkal.ToString();
                txtZbiaOgu.Text = oguZbia.ToString();
                txtZtluOgu.Text = oguZtlu.ToString();
                txtZwegOgu.Text = oguZweg.ToString();
                txtZbloOgu.Text = oguZblo.ToString();

                connect2.Close();
            }
            catch { }


        }

        private void btnSave_Click(object sender, EventArgs e)  ///dodanie do bazy nowego produktu na podst wprowadzonych
                                                                ///w textBoxach danych
        {               ////////////dodaje tylko do grzybów, a powinno do tego co wybrano w
            //////////////////////////listboxie 2 z kategoriami
            string zaznaczenieListBoxa2 = listBox2.Text;
            if (txtPro.Text != "" && txtWeg.Text != "" && txtKal.Text != "" && txtBia.Text != "" && txtBlo.Text != "" && txtTlu.Text != "" && zaznaczenieListBoxa2 != "")
            {
                try
                {
                    connect.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connect;
                    command.CommandText = "INSERT INTO " + zaznaczenieListBoxa2 + " (Produkt,Kaloryczność,Białko,Tłuszcz,Węglowodany,Błonnik) VALUES('" + txtPro.Text + "','" + txtKal.Text + "','" + txtBia.Text + "','" + txtTlu.Text + "','" + txtWeg.Text + "','" + txtBlo.Text + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Zapisano poprawnie.");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad " + ex);
                }
            }
            else MessageBox.Show("Jeśli chcesz dodać, wypełnij wszystkie pola i zaznacz kategorię.");
        }

        private void btnEdit_Click(object sender, EventArgs e)  //edycja danych produktu w bazie
        {
            string zaznaczenieListBoxa2 = listBox2.Text;
            if (txtPro.Text != "" && txtWeg.Text != "" && txtKal.Text != "" && txtBia.Text != "" && txtBlo.Text != "" && txtTlu.Text != "" && zaznaczenieListBoxa2 != "")
            {
                try
                {
                    connect.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connect;
                    string query = "UPDATE Grzyby SET " + zaznaczenieListBoxa2 + " = '" + txtPro.Text + "' ,Kaloryczność = '" + txtKal.Text + "' ,Białko = '" + txtBia.Text + "' ,Tłuszcz = '" + txtTlu.Text + "' ,Węglowodany = '" + txtWeg.Text + "' ,Błonnik = '" + txtBlo.Text + "' WHERE ID = " + txtID.Text + " ";
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
            else MessageBox.Show("Jeśli chcesz edytować, wypełnij wszystkie pola i zaznacz kategorię.");
        }

        private void btnDelete_Click(object sender, EventArgs e) ////usuwanie produktu z bazy
        {
            string zaznaczenieListBoxa3 = listBox3.Text;
            if (txtPro.Text != "" && txtWeg.Text != "" && txtKal.Text != "" && txtBia.Text != "" && txtBlo.Text != "" && txtTlu.Text != "" && zaznaczenieListBoxa3 != "")
            {
                try
                {
                    connect.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connect;
                    string query = "DELETE FROM " + listBox2.Text + " WHERE ID = " + txtID.Text + " ";
                    //MessageBox.Show(query);
                    command.CommandText = query;

                    command.ExecuteNonQuery();
                    MessageBox.Show("Podany produkt został usunięty.");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad " + ex);
                }
            }
            else MessageBox.Show("Zaznacz produkt z listy do usunięcia.");

        }

        public int nrTabeli = 0;    //którą tabelę wybraliśmy w listBoxie wyżej

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)///////produkty z wybranej kategorii trafiają
        {                                                                      /////do listBoxa niżej
            if (listBox2.Text == "Dania_fast_food_KFC")
                nrTabeli = 1;
            if (listBox2.Text == "Dania_fast_food_MC")
                nrTabeli = 2;
            if (listBox2.Text == "Drób")
                nrTabeli = 3;
            if (listBox2.Text == "Grzyby")
                nrTabeli = 4;
            if (listBox2.Text == "Jaja")
                nrTabeli = 5;
            if (listBox2.Text == "Mięso")
                nrTabeli = 6;
            if (listBox2.Text == "Mleko_i_przetwory_mleczne")
                nrTabeli = 7;
            if (listBox2.Text == "Napoje_alkoholowe")
                nrTabeli = 8;
            if (listBox2.Text == "Napoje_bezalkoholowe")
                nrTabeli = 9;
            if (listBox2.Text == "Orzechy")
                nrTabeli = 10;
            if (listBox2.Text == "Owoce")
                nrTabeli = 11;
            if (listBox2.Text == "Produkty_zbożowe")
                nrTabeli = 12;
            if (listBox2.Text == "Przyprawy")
                nrTabeli = 13;
            if (listBox2.Text == "Ryby")
                nrTabeli = 14;
            if (listBox2.Text == "Słodycze")
                nrTabeli = 15;
            if (listBox2.Text == "Tłuszcze")
                nrTabeli = 16;
            if (listBox2.Text == "Warzywa")
                nrTabeli = 17;
            if (listBox2.Text == "Wędliny")
                nrTabeli = 18;
                //przełączanie sztuki/gramy trackBara gdy wybierzemy fast food
            if (listBox2.Text == "Dania_fast_food_KFC" || listBox2.Text == "Dania_fast_food_MC")
            {
                trackBar1.Maximum = 5;                  //zmniejszenie z 1000 do 5 bo gramy a nie sztuki
                labelSztG.Text = "Wskaż ilość [szt]";
                trackBar1.Value = 0;                    //żeby nie było np 1000szt bo były gramy ustawione
                labelWskaznik.Text = trackBar1.Value.ToString();
            }
            else
            {
                trackBar1.Maximum = 1000;
                labelSztG.Text = "Wskaż ilość [g]";
                trackBar1.Value = 0;
                labelWskaznik.Text = trackBar1.Value.ToString();
            }

            try        ////////z której kategorii mamy wyświetlać dostępne produkty
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
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
                listBox3.Items.Clear();
                while (reader.Read())
                {
                    listBox3.Items.Add(reader["Produkt"].ToString());
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }


        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try  ///////produkty z wybranej kategorii, po kliknięciu info o jednym z nich trafia do textBoxów
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "SELECT * FROM "+listBox2.Text+" WHERE Produkt = '" + listBox3.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtID.Text = reader["ID"].ToString();
                    txtPro.Text = reader["Produkt"].ToString();
                    txtKal.Text = reader["Kaloryczność"].ToString();
                    txtBia.Text = reader["Białko"].ToString();
                    txtTlu.Text = reader["Tłuszcz"].ToString();
                    txtWeg.Text = reader["Węglowodany"].ToString();
                    txtBlo.Text = reader["Błonnik"].ToString();
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
            labelWskaznik.Text = trackBar1.Value.ToString();
        }

        private void btnZarzadzajSwoimKontem_Click(object sender, EventArgs e)  //przejście na okno zarządzania kontem
        {
            this.Hide();
            Form4 f4 = new Form4(label10.Text);
            f4.ShowDialog();
        }

        private void btnSearchProdukt_Click(object sender, EventArgs e) ////szukanie w dolnym listBoxie produktów po nazwie
        {                                                                   //wpisanej do textBoxa obok po prawej
            listBox3.SelectedItems.Clear();
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
            {
                if (listBox3.Items[i].ToString().ToLower().Contains(textBoxSzukaj.Text.ToLower()))
                    listBox3.SetSelected(i, true);
            }
            labelSzukaj.Text = "Znaleziono " + listBox3.SelectedItems.Count.ToString() + " produktów";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////druga prawa połowa okna//////////////////////////////////////////////////
        
        public string zaspokojoneKal;   //liczba zaspokojonego zapotrzebowania przez produkty w listBoxie1 - 
        public string zaspokojoneBia;   //- wczytana z bazy (string)
        public string zaspokojoneTlu;
        public string zaspokojoneWeg;
        public string zaspokojoneBlo;
        public double zaspokojoneKal2 = 0; //to samo w double, to tu są obliczone wartości po dodaniu wszystich z listBoxa1
        public double zaspokojoneBia2 = 0;
        public double zaspokojoneTlu2 = 0;
        public double zaspokojoneWeg2 = 0;
        public double zaspokojoneBlo2 = 0;
        public string zapotrzebowanieKal = ""; //wczytane przy Form_Load zapotrzebowania użytkownika
        public string zapotrzebowanieBia = "";
        public string zapotrzebowanieBlo = "";
        public string zapotrzebowanieWeg = "";
        public string zapotrzebowanieTlu = "";

        public double oguZkalpom = 0;
        public double oguZbiapom = 0;
        public double oguZblopom = 0;
        public double oguZtlupom = 0;
        public double oguZwegpom = 0;

        double procent;     //we dwie określają procent zapotrzebować każdego po koleii w btnPass poniżej
        double procent2;

        private void btnPass_Click(object sender, EventArgs e)
        {
            
            ////przerzucanie do prawego listBoxa tego co zjedliśmy//////////////////
            if (trackBar1.Value != 0)
            {
                //oguZkal - ogólne zaspokojone z bazy,,,, oguZkalpom - pomocnicze
                txtZkalOgu.Text = oguZkal.ToString();
                txtZbiaOgu.Text = oguZbia.ToString();
                txtZtluOgu.Text = oguZtlu.ToString();
                txtZwegOgu.Text = oguZweg.ToString();
                txtZbloOgu.Text = oguZblo.ToString();

                oguZkalpom = zaspokojoneKal2;
                oguZbiapom = zaspokojoneBia2;
                oguZblopom = zaspokojoneBlo2;
                oguZtlupom = zaspokojoneTlu2;
                oguZwegpom = zaspokojoneWeg2;


                string nazwaProduktu;
                int ileProduktow = listBox3.Items.Count - 1;
                for (int i = ileProduktow; i >= 0; i--)
                {
                    if (listBox3.GetSelected(i))
                    {
                        listBox1.Items.Add(listBox3.Items[i]);
                        ///////////////////////////podliczanie wartości po każdym dodaniu do zjedzonych///////////////////
                        nazwaProduktu = listBox3.Items[i].ToString();

                        try
                        {
                            connect.Open();
                            OleDbCommand command = new OleDbCommand();
                            command.Connection = connect;
                            string query = "SELECT * FROM " + listBox2.Text + " WHERE Produkt = '" + nazwaProduktu + "'";
                            command.CommandText = query;

                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                //wczytywanie z bazy do stringów a potem do double żeby dodać
                                if (listBox2.Text == "Dania_fast_food_KFC" || listBox2.Text == "Dania_fast_food_MC")
                                {
                                    //gdy mamy fast food (sztuki a nie gramy)
                                    zaspokojoneKal = reader["Kaloryczność"].ToString();
                                    zaspokojoneBia = reader["Białko"].ToString();
                                    zaspokojoneTlu = reader["Tłuszcz"].ToString();
                                    zaspokojoneWeg = reader["Węglowodany"].ToString();
                                    zaspokojoneBlo = reader["Błonnik"].ToString();
                                    /*suma dodawanych roduktów ->*/
                                    zaspokojoneKal2 = zaspokojoneKal2 + Convert.ToDouble(zaspokojoneKal) * trackBar1.Value;
                                    zaspokojoneBia2 = zaspokojoneBia2 + Convert.ToDouble(zaspokojoneBia) * trackBar1.Value;
                                    zaspokojoneTlu2 = zaspokojoneTlu2 + Convert.ToDouble(zaspokojoneTlu) * trackBar1.Value;
                                    zaspokojoneWeg2 = zaspokojoneWeg2 + Convert.ToDouble(zaspokojoneWeg) * trackBar1.Value;
                                    zaspokojoneBlo2 = zaspokojoneBlo2 + Convert.ToDouble(zaspokojoneBlo) * trackBar1.Value;
                                }
                                else
                                {
                                    //zazwyczaj
                                    zaspokojoneKal = reader["Kaloryczność"].ToString();
                                    zaspokojoneBia = reader["Białko"].ToString();
                                    zaspokojoneTlu = reader["Tłuszcz"].ToString();
                                    zaspokojoneWeg = reader["Węglowodany"].ToString();
                                    zaspokojoneBlo = reader["Błonnik"].ToString();
                                    zaspokojoneKal2 = zaspokojoneKal2 + (Convert.ToDouble(zaspokojoneKal) / 100) * trackBar1.Value;
                                    zaspokojoneBia2 = zaspokojoneBia2 + (Convert.ToDouble(zaspokojoneBia) / 100) * trackBar1.Value;
                                    zaspokojoneTlu2 = zaspokojoneTlu2 + (Convert.ToDouble(zaspokojoneTlu) / 100) * trackBar1.Value;
                                    zaspokojoneWeg2 = zaspokojoneWeg2 + (Convert.ToDouble(zaspokojoneWeg) / 100) * trackBar1.Value;
                                    zaspokojoneBlo2 = zaspokojoneBlo2 + (Convert.ToDouble(zaspokojoneBlo) / 100) * trackBar1.Value;
                                }
                            }
                            connect.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Blad " + ex);
                        }

                    }
                }
                ///przepisywanie już po wszystkim do texBoxów zsummowanych wartości
                txtZkal.Text = zaspokojoneKal2.ToString();
                txtZbia.Text = zaspokojoneBia2.ToString();
                txtZtlu.Text = zaspokojoneTlu2.ToString();
                txtZweg.Text = zaspokojoneWeg2.ToString();
                txtZblo.Text = zaspokojoneBlo2.ToString();

                //dodanie wartości dodawanych do ogólnych przy wciśnięciu btnPass

                oguZkal += zaspokojoneKal2;
                oguZbia += zaspokojoneBia2;
                oguZblo += zaspokojoneBlo2;
                oguZtlu += zaspokojoneTlu2;
                oguZweg += zaspokojoneWeg2;

                oguZkal -= oguZkalpom;
                oguZbia -= oguZbiapom;
                oguZblo -= oguZblopom;
                oguZtlu -= oguZtlupom;
                oguZweg -= oguZwegpom;

                txtZkalOgu.Text = oguZkal.ToString();
                txtZbiaOgu.Text = oguZbia.ToString();
                txtZtluOgu.Text = oguZtlu.ToString();
                txtZwegOgu.Text = oguZweg.ToString();
                txtZbloOgu.Text = oguZblo.ToString();

                ostrzeganieProcenty(true);

                /////////zapisywanie do zmiennej gramów i sztuk żeby potem w form5 odczytać

                string zmPomoc = "";
                if (labelSztG.Text == "Wskaż ilość [g]")
                    zmPomoc = "g";
                else
                    zmPomoc = "szt";

                if(listBox3.SelectedItems.Count > 1)
                    for (int u = 0; u < listBox3.SelectedItems.Count; u++)
                    {
                        iloscProduktu[k] = trackBar1.Value.ToString() + " " + zmPomoc;
                        k += 1;
                    }

                iloscProduktu[k] = trackBar1.Value.ToString() + " " + zmPomoc;
                k += 1;
            }
            else if(listBox3.Items.Count == 0)
                MessageBox.Show("Wybierz coś.");
            else
                MessageBox.Show("Zaznacz ilość inną niż zero.");

            labelWskaznik.Text = trackBar1.Value.ToString();

            czyAlergenne();
        }

        public void ostrzeganieProcenty(bool czyOstrzegac)
        {
            //ostrzeganie - kaloryczność

            //obliczanie ile procent zapotrzebowania zostanie zaspokojone jeśli dodamy to co jest w textBoxach dodawania posiłków
            procent = Convert.ToDouble(zapotrzebowanieKal) / 100;
            procent2 = Convert.ToDouble(txtZkalOgu.Text) / procent;
            labelProcentKal.Text = Math.Round(procent2, 1).ToString() + "%";
            //ostrzeżenia o przekroczeniu zapotrzebowania
            if (procent2 < 50) labelProcentKal.ForeColor = Color.YellowGreen;
            if (procent2 < 20) labelProcentKal.ForeColor = Color.DarkGray;
            if (procent2 > 70) labelProcentKal.ForeColor = Color.Green;
            if (procent2 > 110 && procent2 < 130)
            {
                labelProcentKal.ForeColor = Color.YellowGreen;
                MessageBox.Show("Zaczynasz przekraczać zapotrzebowanie na " + label12.Text, "Uwaga!");
            }
            if (procent2 > 130) labelProcentKal.ForeColor = Color.Orange;
            if (procent2 > 150)
            {
                labelProcentKal.ForeColor = Color.Red;
                MessageBox.Show("Poważne przekroczenie zapotrzebowania na " + label12.Text, "Uwaga!");
            }

            //ostrzeganie - białko
            procent = Convert.ToDouble(zapotrzebowanieBia) / 100;
            procent2 = Convert.ToDouble(txtZbiaOgu.Text) / procent;
            labelProcentBia.Text = Math.Round(procent2, 1).ToString() + "%";

            if (procent2 < 50) labelProcentBia.ForeColor = Color.YellowGreen;
            if (procent2 < 20) labelProcentBia.ForeColor = Color.DarkGray;
            if (procent2 > 70) labelProcentBia.ForeColor = Color.Green;
            if (procent2 > 110 && procent2 < 130)
            {
                labelProcentBia.ForeColor = Color.YellowGreen;
                MessageBox.Show("Zaczynasz przekraczać zapotrzebowanie na " + label13.Text, "Uwaga!");
            }
            if (procent2 > 130) labelProcentBia.ForeColor = Color.Orange;
            if (procent2 > 150)
            {
                labelProcentBia.ForeColor = Color.Red;
                MessageBox.Show("Poważne przekroczenie zapotrzebowania na " + label13.Text, "Uwaga!");
            }

            //ostrzeganie - błonnik
            procent = Convert.ToDouble(zapotrzebowanieBlo) / 100;
            procent2 = Convert.ToDouble(txtZbloOgu.Text) / procent;
            labelProcentBlo.Text = Math.Round(procent2, 1).ToString() + "%";

            if (procent2 < 50) labelProcentBlo.ForeColor = Color.YellowGreen;
            if (procent2 < 20) labelProcentBlo.ForeColor = Color.DarkGray;
            if (procent2 > 70) labelProcentBlo.ForeColor = Color.Green;
            if (procent2 > 110 && procent2 < 130)
            {
                labelProcentBlo.ForeColor = Color.YellowGreen;
                MessageBox.Show("Zaczynasz przekraczać zapotrzebowanie na " + label14.Text, "Uwaga!");
            }
            if (procent2 > 130) labelProcentBlo.ForeColor = Color.Orange;
            if (procent2 > 150)
            {
                labelProcentBlo.ForeColor = Color.Red;
                MessageBox.Show("Poważne przekroczenie zapotrzebowania na " + label14.Text, "Uwaga!");
            }

            //ostrzeganie - węglowodany
            procent = Convert.ToDouble(zapotrzebowanieWeg) / 100;
            procent2 = Convert.ToDouble(txtZwegOgu.Text) / procent;
            labelProcentWeg.Text = Math.Round(procent2, 1).ToString() + "%";

            if (procent2 < 50) labelProcentWeg.ForeColor = Color.YellowGreen;
            if (procent2 < 20) labelProcentWeg.ForeColor = Color.DarkGray;
            if (procent2 > 70) labelProcentWeg.ForeColor = Color.Green;
            if (procent2 > 110 && procent2 < 130)
            {
                labelProcentWeg.ForeColor = Color.YellowGreen;
                MessageBox.Show("Zaczynasz przekraczać zapotrzebowanie na " + label15.Text, "Uwaga!");
            }
            if (procent2 > 130) labelProcentWeg.ForeColor = Color.Orange;
            if (procent2 > 150)
            {
                labelProcentWeg.ForeColor = Color.Red;
                MessageBox.Show("Poważne przekroczenie zapotrzebowania na " + label15.Text, "Uwaga!");
            }

            //ostrzeganie - tłuszcz
            procent = Convert.ToDouble(zapotrzebowanieTlu) / 100;
            procent2 = Convert.ToDouble(txtZtluOgu.Text) / procent;
            labelProcentTlu.Text = Math.Round(procent2, 1).ToString() + "%";

            if (procent2 < 50) labelProcentTlu.ForeColor = Color.YellowGreen;
            if (procent2 < 20) labelProcentTlu.ForeColor = Color.DarkGray;
            if (procent2 > 70) labelProcentTlu.ForeColor = Color.Green;
            if (procent2 > 110 && procent2 < 130)
            {
                labelProcentTlu.ForeColor = Color.YellowGreen;
                MessageBox.Show("Zaczynasz przekraczać zapotrzebowanie na " + label16.Text, "Uwaga!");
            }
            if (procent2 > 130) labelProcentKal.ForeColor = Color.Orange;
            if (procent2 > 150)
            {
                labelProcentTlu.ForeColor = Color.Red;
                MessageBox.Show("Poważne przekroczenie zapotrzebowania na " + label16.Text, "Uwaga!");
            }

        }




        public int k = 0;
        public string[] iloscProduktu = new string[100];
        

        private void timer1_Tick(object sender, EventArgs e) ///aktualny czas
        {
            DateTime dateTime = DateTime.Now;
            this.labelDate.Text = dateTime.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //wyświetla wartość na labelu tego wskaźnika ilości
        {
            labelWskaznik.Text = trackBar1.Value.ToString();
        }


 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int i = 0;

        private void zapiszPosilek_Click(object sender, EventArgs e) //zapisywanie do bazy Dni.accdb tego co zjadł kto i kiedy
        {
            if (listBox1.Items.Count > 0)
            {
                string posilki = "";
                int p = 0;
                listBox1.SetSelected(p, true);
                for (; p < listBox1.Items.Count; p++)
                {
                    listBox1.SetSelected(p, true);
                    posilki += listBox1.SelectedItem.ToString() + "^" + iloscProduktu[i].ToString() + "*"; //zmienna "posilki" przechwuje wszystko z listboxa   
                    //MessageBox.Show(posilki);
                    i += 1;
                }     //co zjedliśmy rozdzielone "*" i wysyła się do bazy danych
                //dodano też ilość po "^"
                try
                {
                    connect2.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connect2;
                    command.CommandText = "INSERT INTO Dni (Data, Posiłki, LoginKto, zasKaloryczność, zasBiałko, zasTłuszcz, zasWęglowodany, zasBłonnik) VALUES('" + labelDate.Text + "', '" + posilki + "', '" + label10.Text + "', '" + txtZkal.Text + "', '" + txtZbia.Text + "', '" + txtZtlu.Text + "', '" + txtZweg.Text + "', '" + txtZblo.Text + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Zapisano poprawnie.");
                    connect2.Close();

                    //czyszczenie
                    txtZkal.Text = "";
                    txtZbia.Text = "";
                    txtZblo.Text = "";
                    txtZtlu.Text = "";
                    txtZweg.Text = "";
                    listBox1.Items.Clear();
                    listBox3.ClearSelected();

                    procent = 0;
                    procent2 = 0;
                    zaspokojoneKal2 = 0;
                    zaspokojoneBia2 = 0;
                    zaspokojoneTlu2 = 0;
                    zaspokojoneWeg2 = 0;
                    zaspokojoneBlo2 = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad " + ex);
                }
            }
            trackBar1.Value = 0;
            labelWskaznik.Text = trackBar1.Value.ToString();
        }

        private void btnHistoria_Click(object sender, EventArgs e) //pokazuje historię posiłków
        {
            Form5 f5 = new Form5(label10.Text);
            f5.Show();
        }

        private void btnOdswiez_Click(object sender, EventArgs e) //odświerza, konieczne jeśli usuneliśmy coś z historii w form5
        {
               oguZkal = 0;
               oguZbia = 0; 
               oguZblo = 0; 
               oguZtlu = 0;
               oguZweg = 0; 

               txtZkalOgu.Text = oguZkal.ToString();
               txtZbiaOgu.Text = oguZbia.ToString();
               txtZtluOgu.Text = oguZtlu.ToString();
               txtZwegOgu.Text = oguZweg.ToString();
               txtZbloOgu.Text = oguZblo.ToString();

               wczytywanieOgolnychZas();    //stare zaspokojone wart. czyści i wywołuje funkcję wczytania od nowa
               ostrzeganieProcenty(true);        //po wczytaniu nadajemy od nowa kolory i procenty 
        }

        /// ///////////////////////////////////////////////////////////////////////////////////


        private void btnAnuluj_Click(object sender, EventArgs e) //anulowanie dodawania
        {
            listBox1.Items.Clear();

            oguZkal = 0;
            oguZbia = 0;
            oguZblo = 0;
            oguZtlu = 0;
            oguZweg = 0; 

                    txtZkal.Text = "";
                    txtZbia.Text = "";
                    txtZblo.Text = "";
                    txtZtlu.Text = "";
                    txtZweg.Text = "";
                    listBox1.Items.Clear();
                    listBox3.ClearSelected();

                    procent = 0;
                    procent2 = 0;
                    zaspokojoneKal2 = 0;
                    zaspokojoneBia2 = 0;
                    zaspokojoneTlu2 = 0;
                    zaspokojoneWeg2 = 0;
                    zaspokojoneBlo2 = 0;

                    wczytywanieOgolnychZas();
                    ostrzeganieProcenty(false);
                    trackBar1.Value = 0;
                    labelWskaznik.Text = trackBar1.Value.ToString();
        }

        private void czyAlergenne() //spr i pokazywanie ostrzeżenia jeśli w listBoxie1 został dodany prod. alergenny
        {
            /////////////////////////////////wczytanie z bazy pola z prod. alergennymi
            string alergenyZbazy = "";
            try
            {
                connect3.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect3;
                string query = "SELECT * FROM Loginy WHERE Login = '" + label10.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    alergenyZbazy = reader["Alergeny"].ToString();
                }
                connect3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex);
            }
            //////////////////////////////////spr. czy w listboxie1 któryś jest na liście zczytanej z bazy//////////////
            string[] podzial;
            podzial = alergenyZbazy.Split('*');
            int j = 0;

            int ileProduktow = listBox1.Items.Count - 1;
            for (int i = ileProduktow; i >= 0; i--)
            {
                    try
                    {
                        while (podzial[j] != "")
                        {
                            if (podzial[j] == listBox1.Items[i].ToString())
                                MessageBox.Show("Dodano produkt znajdujący się na liście produktów alergennych!","Uwaga!");
                            j += 1;
                        }
                    }
                    catch { }
            }


        }

    }
}

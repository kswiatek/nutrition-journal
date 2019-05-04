using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form   
    {
        private OleDbConnection connect2 = new OleDbConnection();
        public Form5(string UsrName)
        {
            InitializeComponent();
            connect2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Dni.accdb;Persist Security Info=False;";
            UsrName2 = UsrName;
        }

        public string UsrName2;

        private void Form5_Load(object sender, EventArgs e)
        {
            wczytajWybranyDzien();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //tutaj wczytujemy tylko datę z dniem,                                                                              //bez godziny
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wczytajWybranyDzien();
        }

        public void wczytajWybranyDzien()
        {
            listBox1.Items.Clear();

            try
            {
                connect2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect2;
                string query = "SELECT * FROM Dni ";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                double liniaZasWartosciDniaKal = 0;
                double liniaZasWartosciDniaBia = 0;
                double liniaZasWartosciDniaBlo = 0;
                double liniaZasWartosciDniaTlu = 0;
                double liniaZasWartosciDniaWeg = 0;

                string linijkaDaty;
                string linijkaNazwyUzytkownika;
                string[] podzial;
                podzial = new string[10];
                while (reader.Read())
                {
                    linijkaDaty = reader["Data"].ToString();
                    podzial = linijkaDaty.Split(' ');
                    linijkaNazwyUzytkownika = reader["LoginKto"].ToString();
                    if (podzial[0] == dateTimePicker1.Text && linijkaNazwyUzytkownika == UsrName2) //if daty i login się zgadzają (chodzi o dzień) to:
                    {
                        listBox1.Items.Add(podzial[1]); //godziny zjedzenia posiłków
                        liniaZasWartosciDniaKal += Convert.ToDouble(reader["zasKaloryczność"]);
                        liniaZasWartosciDniaBia += Convert.ToDouble(reader["zasBiałko"]);
                        liniaZasWartosciDniaBlo += Convert.ToDouble(reader["zasBłonnik"]);
                        liniaZasWartosciDniaTlu += Convert.ToDouble(reader["zasTłuszcz"]);
                        liniaZasWartosciDniaWeg += Convert.ToDouble(reader["zasWęglowodany"]);
                    }

                }

                labelKalOgu.Text = liniaZasWartosciDniaKal.ToString();
                labelBiaOgu.Text = liniaZasWartosciDniaBia.ToString();
                labelBloOgu.Text = liniaZasWartosciDniaBlo.ToString();
                labelWegOgu.Text = liniaZasWartosciDniaWeg.ToString();
                labelTluOgu.Text = liniaZasWartosciDniaTlu.ToString();
                connect2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }

            try
            {
                listBox1.SetSelected(0, true);
            }
            catch { }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //wpisuje co zjedzono po wybraniu godziny
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            try
            {
                connect2.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect2;
                string query = "SELECT * FROM Dni ";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                string godzina = listBox1.SelectedItem.ToString();
                string linijkaDaty;
                string linijkaNazwyUzytkownika;
                string liniaHistorii;

                string[] podzial;
                podzial = new string[10];
                while (reader.Read())
                {
                    linijkaDaty = reader["Data"].ToString();
                    podzial = linijkaDaty.Split(' ');
                    linijkaNazwyUzytkownika = reader["LoginKto"].ToString();
                    if (podzial[0] == dateTimePicker1.Text && podzial[1] == godzina && linijkaNazwyUzytkownika == UsrName2) //if daty, godzina i login się zgadzają (chodzi o dzień) to:
                    {
                        //wczytanie lini z posiłkami (z podziałem z *)
                        liniaHistorii = reader["Posiłki"].ToString(); 
                        string[] podzial2;
                        podzial2 = new string[100];
                        podzial2 = liniaHistorii.Split('*'); //rozdzielanie po "*" produktów z kolumny Posiłki w bazie

                        string[] podzial3;
                        podzial3 = new string[100];
                        

                        int i = 0;
                        try
                        {
                            while (podzial2[i] != null)
                            {
                                podzial3 = podzial2[i].Split('^');
                                listBox2.Items.Add(podzial3[0]); //godziny zjedzenia posiłków
                                listBox3.Items.Add(podzial3[1]);
                                i += 1;
                            }
                        }
                        catch { }
                        //wczytanie zaspokojonych tym posiłkiem wartości
                        try
                        {
                            labelKal.Text = reader["zasKaloryczność"].ToString();
                            labelBia.Text = reader["zasBiałko"].ToString();
                            labelBlo.Text = reader["zasBłonnik"].ToString();
                            labelWeg.Text = reader["zasWęglowodany"].ToString();
                            labelTlu.Text = reader["zasTłuszcz"].ToString();

                        }
                        catch { }

                    }

                }
                connect2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e) //usuwanie wpisu z historii
        {
            try
            {
                if (listBox1.SelectedItem.ToString() != null)
                {
                    string dataZgodzina = dateTimePicker1.Text + " " + listBox1.SelectedItem.ToString();
                    try
                    {
                        connect2.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connect2;
                        string query = "DELETE FROM Dni WHERE Data = '" + dataZgodzina + "' ";
                        //MessageBox.Show(query);
                        command.CommandText = query;

                        command.ExecuteNonQuery();
                        MessageBox.Show("Zaznaczony wpis został usunięty. Jeżeli usuwałeś z dzisiaj kliknij odśwież","Operacja wykonana pomyślnie!");
                        connect2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Blad " + ex);
                    }
                }
            }
            catch { }
            wczytajWybranyDzien();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            try
            {

                listBox1.SetSelected(0, true);
            }
            catch { }
        }
    }
}

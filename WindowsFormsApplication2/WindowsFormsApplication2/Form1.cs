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
    public partial class Form1 : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Loginy.accdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Brak połączenia z bazą danych!.";

            try
            {
                connect.Open();
                label3.Text = "Baza danych wczytana prawidlowo.";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Blad " + ex);
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT * FROM Loginy WHERE Login='"+txtLogin.Text+"' AND Haslo='"+txtHaslo.Text+"' ";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                MessageBox.Show("Zalogowano poprawnie.","Przyznano dostęp!");
                connect.Close();
                connect.Dispose();
                this.Hide();
                Form2 f2 = new Form2(txtLogin.Text);
                f2.ShowDialog();
            }

            else
            {
                MessageBox.Show("Dane logowanie nie poprawne.");
            }

            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp9
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection connect4 = new SqlConnection("Data Source=DESKTOP-4SJIC8I\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            connect4.Open();
            SqlCommand giris1 = new SqlCommand("SELECT * FROM Kullanici where kulid=@i1 and sifre=@i2", connect4);
            giris1.Parameters.AddWithValue("@i1", lblkul.Text);
            giris1.Parameters.AddWithValue("@i2", lblsifre.Text);

            SqlDataReader oku = giris1.ExecuteReader();

            

           if(oku.Read())
            {
                Form1 fropen = new Form1();
                fropen.Show();
                this.Hide();
            }

           else
            {
                MessageBox.Show("Kullanici adi veya şifre yanlış", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect4.Close();
            

        }
    }
}

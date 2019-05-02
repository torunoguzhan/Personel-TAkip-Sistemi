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
    public partial class Forminfo : Form
    {
        public Forminfo()
        {
            InitializeComponent();
        }

        

        SqlConnection connect2 = new SqlConnection("Data Source=DESKTOP-4SJIC8I\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        
        private void Forminfo_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            connect2.Open();
            SqlCommand komut1 = new SqlCommand("Select Count (*) From Personel ", connect2);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {                
                lblpersonel.Text = dr1[0].ToString();                                       
            }
            connect2.Close();

            //Evli Personel Sayısı

            connect2.Open();
            SqlCommand komut2 = new SqlCommand("SELECT  count(*) FROM Personel where PerDurum=1", connect2);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();
            }
            connect2.Close();

            //Bekar Personel Sayısı

            connect2.Open();
            SqlCommand komut3 = new SqlCommand("SELECT  count(*) FROM Personel where PerDurum=0",connect2);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                lblbekar.Text = dr3[0].ToString();

            }
            connect2.Close();

            //Şehir Sayısı

            connect2.Open();
            SqlCommand komut4 = new SqlCommand("SELECT  count (distinct PerSehir) FROM Personel", connect2);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                lblsehir.Text = dr4[0].ToString();
            }
            connect2.Close();

            //Toplam Maaş

            connect2.Open();
            SqlCommand komut5 = new SqlCommand("SELECT  sum ( PerMaas) FROM Personel", connect2);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while(dr5.Read())
            {
                lbltopmaas.Text = dr5[0].ToString();
            }
            connect2.Close();

            // Ortalama Maaş

            connect2.Open();
            SqlCommand komut6 = new SqlCommand("SELECT  avg ( PerMaas) FROM Personel", connect2);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                lblortmaas.Text = dr6[0].ToString();
            }
            connect2.Close();




            }

        private void lblsehir_Click(object sender, EventArgs e)
        {

        }
    }
    }


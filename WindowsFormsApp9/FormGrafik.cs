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
    public partial class FormGrafik : Form
    {
        public FormGrafik()
        {
            InitializeComponent();
        }

        SqlConnection connect3 = new SqlConnection("Data Source=DESKTOP-4SJIC8I\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FormGrafik_Load(object sender, EventArgs e)
        {
            connect3.Open();
            SqlCommand komut7 = new SqlCommand("SELECT Persehir ,count (*) FROM Personel group by PerSehir", connect3);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr7[0], dr7[1]);
            }
            connect3.Close();

            connect3.Open();
            SqlCommand komut8 = new SqlCommand("SELECT Permeslek , avg(permaas) FROM Personel group by Permeslek", connect3);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr8[0].ToString(), dr8[1].ToString());
            }
            connect3.Close();

        }
    }
}

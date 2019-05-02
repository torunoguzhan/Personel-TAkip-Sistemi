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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-4SJIC8I\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
                      
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void clean()
        {
            perid.Text = "";
            perad.Text = "";
            persoyad.Text = "";
            persehir.Text = "";
            permaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            permeslek.Text = "";
            perad.Focus();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter3.Fill(this.personelVeriTabaniDataSet3.Personel);
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand command = new SqlCommand("insert into Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek ) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect);
            command.Parameters.AddWithValue("@p1", perad.Text);
            command.Parameters.AddWithValue("@p2", persoyad.Text);
            command.Parameters.AddWithValue("@p3", persehir.Text);
            command.Parameters.AddWithValue("@p4", permaas.Text);
            command.Parameters.AddWithValue("@p5", label8.Text);
            command.Parameters.AddWithValue("@p6", permeslek.Text);
            command.ExecuteNonQuery();
            connect.Close();

        }
  
        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            perid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            perad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            persoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            persehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            permaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            permeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            
        }

        private void label8_TextChanged(object sender, EventArgs e) // if text changed and run 
        {
            if(label8.Text=="True")
            {
                radioButton2.Checked = false; //important
                radioButton1.Checked =true;
                
            }
            if(label8.Text=="False")
            {
                radioButton1.Checked = false; //important
                radioButton2.Checked=true;
                
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            
            connect.Open();
            SqlCommand komutsil = new SqlCommand("DELETE FROM Personel where perid=@a1", connect);
            komutsil.Parameters.AddWithValue("@a1", perid.Text);
            komutsil.ExecuteNonQuery();
            connect.Close();
            clean();
            MessageBox.Show("Kayıt Silindi","İnformation",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            

            connect.Open();
            SqlCommand komutguncelle = new SqlCommand("UPDATE Personel SET perAd=@g11 , perSoyad=@g2 , perSehir=@g3 , perMaas=@g4 , perDurum=@g5 , perMeslek=@g6 where perid=@g1",connect);
            komutguncelle.Parameters.AddWithValue("@g1", perid.Text);
            komutguncelle.Parameters.AddWithValue("@g11", perad.Text);
            komutguncelle.Parameters.AddWithValue("@g2", persoyad.Text);
            komutguncelle.Parameters.AddWithValue("@g3", persehir.Text);
            komutguncelle.Parameters.AddWithValue("@g4", permaas.Text);
            komutguncelle.Parameters.AddWithValue("@g5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@g6", permeslek.Text);
            komutguncelle.ExecuteNonQuery();
            connect.Close();
            

        }

        private void istatistik_Click(object sender, EventArgs e)
        {
            Forminfo forminfo = new Forminfo();
            forminfo.Show();
            
        }

        private void grafik_Click(object sender, EventArgs e)
        {
            FormGrafik fg = new FormGrafik();
            fg.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            DisplayEvents();
        }
        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ipek_\OneDrive\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEvents()
        {
            con.Open();
            string query = "select * from EventsTbl";
            SqlDataAdapter sda = new(query, con);
            SqlCommandBuilder builder = new(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            ds.Tables[0].Columns[0].ColumnName = "Etkinlik No";
            ds.Tables[0].Columns[1].ColumnName = "Açıklama";
            ds.Tables[0].Columns[2].ColumnName = "Tarih";
            ds.Tables[0].Columns[3].ColumnName = "Süre (Saat)";

            EventsDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            key = 0;
            EDurationTb.Text = string.Empty;
            EDescTb.Text = string.Empty;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Insert into EventsTbl(EDesc,EDate,EDuration) values (@EvDesc,@EvDate,@EvDur)", con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDur", EDurationTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik eklendi.");
                    con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int key = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Etkinlik seçiniz.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Delete from EventsTbl Where EId= @EKey", con);
                    cmd.Parameters.AddWithValue("@EKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik silindi.");
                    con.Close();
                    DisplayEvents();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void EventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır seçili mi kontrol et
            {
                EDescTb.Text = EventsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                EDate.Text = EventsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                EDurationTb.Text = EventsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (string.IsNullOrEmpty(EDescTb.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(EventsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Update EventsTbl Set EDesc=@EvDesc,EDate=@EvDate,EDuration=@EvDuration where EId=@EvId", con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDuration", EDurationTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik güncellendi.");
                    con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }

    }
}

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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }

        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ipek_\OneDrive\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayStudent()
        {
            con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter sda = new(query, con);
            SqlCommandBuilder builder = new(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            ds.Tables[0].Columns[0].ColumnName = "Öğrenci No";
            ds.Tables[0].Columns[1].ColumnName = "Adı";
            ds.Tables[0].Columns[2].ColumnName = "Cinsiyeti";
            ds.Tables[0].Columns[3].ColumnName = "Doğum Tarihi";
            ds.Tables[0].Columns[4].ColumnName = "Sınıfı";
            ds.Tables[0].Columns[5].ColumnName = "Harç Ödemesi";
            ds.Tables[0].Columns[6].ColumnName = "Adres";

            StudentsDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Insert into StudentTbl(StName,StGen,StDOB,StClass,StFees,StAdd) values (@SName,@SGen,@SDob,@SClass,@SFees,@SAdd)", con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci eklendi.");
                    con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void Reset()
        {
            key = 0;
            StNameTb.Text = string.Empty;
            FeesTb.Text = string.Empty;
            AddressTb.Text = string.Empty;
            StGenCb.Text = string.Empty;
            ClassCb.Text = string.Empty;
            DOBPicker.Text = DateTime.Today.ToString();
        }
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır seçili mi kontrol et
            {
                StNameTb.Text = StudentsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                StGenCb.SelectedItem = StudentsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                DOBPicker.Text = StudentsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                ClassCb.SelectedItem = StudentsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                FeesTb.Text = StudentsDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                AddressTb.Text = StudentsDGV.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (string.IsNullOrEmpty(StNameTb.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(StudentsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Öğrenci seçiniz.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Delete from StudentTbl Where StId= @StKey", con);
                    cmd.Parameters.AddWithValue("@StKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci silindi.");
                    con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Update StudentTbl Set StName=@SName,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StFees=@SFees,StAdd=@SAdd where StId=@SID", con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@SID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci güncellendi.");
                    con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }
    }
}

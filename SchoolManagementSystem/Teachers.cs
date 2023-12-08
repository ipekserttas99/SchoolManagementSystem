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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }

        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ipek_\OneDrive\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTeachers()
        {
            con.Open();
            string query = "select * from TeacherTbl";
            SqlDataAdapter sda = new(query, con);
            SqlCommandBuilder builder = new(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            ds.Tables[0].Columns[0].ColumnName = "Öğretmen No";
            ds.Tables[0].Columns[1].ColumnName = "Adı";
            ds.Tables[0].Columns[2].ColumnName = "Cinsiyeti";
            ds.Tables[0].Columns[3].ColumnName = "Telefon No";
            ds.Tables[0].Columns[4].ColumnName = "Branşı";
            ds.Tables[0].Columns[5].ColumnName = "Adresi";
            ds.Tables[0].Columns[6].ColumnName = "Doğum Tarihi";

            TeachersDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            key = 0;
            TNameTb.Text = string.Empty;
            SubCb.Text = string.Empty;
            TGenCb.Text = string.Empty;
            TPhoneTb.Text = string.Empty;
            TAddTb.Text = string.Empty;
            TDOB.Text = DateTime.Today.ToString();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Insert into TeacherTbl(Tname,TGen,TPhone,TSub,TAdd,TDOB) values (@Tname,@TGen,@TPhone,@TSub,@TAdd,@TDOB)", con);
                    cmd.Parameters.AddWithValue("@Tname", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen eklendi.");
                    con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır seçili mi kontrol et
            {
                TNameTb.Text = TeachersDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                TGenCb.SelectedItem = TeachersDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                TPhoneTb.Text = TeachersDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                SubCb.SelectedItem = TeachersDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                TAddTb.Text = TeachersDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
                TDOB.Text = TeachersDGV.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (string.IsNullOrEmpty(TNameTb.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(TeachersDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Öğretmen seçiniz.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Delete from TeacherTbl Where TId= @TKey", con);
                    cmd.Parameters.AddWithValue("@TKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen silindi.");
                    con.Close();
                    DisplayTeachers();
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
            if (TNameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Update TeacherTbl Set Tname=@Tname,TGen=@TGen,TPhone=@TPhone,TSub=@TSub,TAdd=@TAdd,TDOB=@TDOB where TId=@TeachId", con);
                    cmd.Parameters.AddWithValue("@Tname", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TeachID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen güncellendi.");
                    con.Close();
                    DisplayTeachers();
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
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}

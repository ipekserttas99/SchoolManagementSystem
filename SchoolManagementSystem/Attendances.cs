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
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            DisplayAttendances();
            FillStudId();
        }
        private void FillStudId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(sqlDataReader);
            StIdCb.ValueMember = "StId";
            StIdCb.DataSource = dt;
            con.Close();
        }
        private void GetStudName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@SID", con);
            cmd.Parameters.AddWithValue("@SID", StIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();

            }
            con.Close();
        }
        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ipek_\OneDrive\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAttendances()
        {
            con.Open();
            string query = "select * from AttendanceTbl";
            SqlDataAdapter sda = new(query, con);
            SqlCommandBuilder builder = new(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            ds.Tables[0].Columns[0].ColumnName = "Yoklama No";
            ds.Tables[0].Columns[1].ColumnName = "Öğrenci No";
            ds.Tables[0].Columns[2].ColumnName = "Öğrenci Adı";
            ds.Tables[0].Columns[3].ColumnName = "Tarih";
            ds.Tables[0].Columns[4].ColumnName = "Durumu";

            
            AttendancesDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Insert into AttendanceTbl(AttStId,AttStName,AttDate,AttStatus) values (@StId,@StName,@AttDate,@Status)", con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yoklama alındı.");
                    con.Close();
                    DisplayAttendances();
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

        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }
        private void Reset()
        {
            key = 0;
            StNameTb.Text = string.Empty;
            AttStatusCb.SelectedIndex = -1;
            StIdCb.SelectedIndex = -1;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void AttendancesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır seçili mi kontrol et
            {
                StIdCb.SelectedValue = AttendancesDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                StNameTb.Text = AttendancesDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                AttDatePicker.Text = AttendancesDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                AttStatusCb.SelectedItem = AttendancesDGV.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (string.IsNullOrEmpty(StNameTb.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(AttendancesDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("Update AttendanceTbl Set AttStId=@StId,AttStName=@StName,AttDate=@ADate,AttStatus=@AStatus where AttNum=@ANum", con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", AttStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yoklama güncellendi.");
                    con.Close();
                    DisplayAttendances();
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
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}

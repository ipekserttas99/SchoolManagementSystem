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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees();
            FillStudId();
        }
        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ipek_\OneDrive\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayFees()
        {
            con.Open();
            string query = "select * from FeesTbl";
            SqlDataAdapter sda = new(query, con);
            SqlCommandBuilder builder = new(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            ds.Tables[0].Columns[0].ColumnName = "Ödeme No";
            ds.Tables[0].Columns[1].ColumnName = "Öğrenci No";
            ds.Tables[0].Columns[2].ColumnName = "Öğrenci Adı";
            ds.Tables[0].Columns[3].ColumnName = "Ödeme Ayı";
            ds.Tables[0].Columns[4].ColumnName = "Miktar (TL)";

            FeesDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FillStudId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", con);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(sqlDataReader);
            StdIdCb.ValueMember = "StId";
            StdIdCb.DataSource = dt;
            con.Close();
        }
        private void GetStudName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@SID", con);
            cmd.Parameters.AddWithValue("@SID", StdIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();

            }
            con.Close();
        }
        private void Reset()
        {
            key = 0;
            StNameTb.Text = string.Empty;
            StdIdCb.SelectedIndex = -1;
            AmountTb.Text = string.Empty;
        }
        int key = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Eksik bilgi!");
            }
            else
            {
                string paymentPeriode;
                paymentPeriode = PeriodDate.Value.Month.ToString() + "/" + PeriodDate.Value.Year.ToString();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from FeesTbl where StId = '" + StdIdCb.SelectedValue.ToString() + "' and Month = '" + paymentPeriode.ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Bu aya ait ödeme yok.");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into FeesTbl(StId,StName,Month,Amt) values (@SId,@SName,@SMonth,@SAmt)", con);
                    cmd.Parameters.AddWithValue("@SId", StdIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SMonth", paymentPeriode);
                    cmd.Parameters.AddWithValue("@SAmt", AmountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ödemeler başarıyla ödendi.");

                }
                con.Close();
                DisplayFees();
                Reset();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
    }
}

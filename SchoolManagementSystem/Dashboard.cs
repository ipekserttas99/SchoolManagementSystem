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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ipek_\OneDrive\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Hide();
        }
        private void CountStudent()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select count(*) from StudentTbl", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            StLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountTeachers()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select count(*) from TeacherTbl", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            TLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void CountEvents()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select count(*) from EventsTbl", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ELbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void SumFees()
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Sum(Amt) from FeesTbl", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            FeesLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeachers();
            CountEvents();
            SumFees();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

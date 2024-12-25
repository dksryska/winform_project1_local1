using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashTudo
{
    public partial class Logins : Form
    {
        public Logins()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\test\Documents\CarWasDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public static string Username = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "SELECT COUNT(*) FROM EmployeeTbl WHERE EName = @EName AND EPass = @EPass";
                SqlCommand cmd = new SqlCommand(query, Con);
                
                cmd.Parameters.AddWithValue("@EName", UNameTbl.Text);
                cmd.Parameters.AddWithValue("@EPass", PasswordTb.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    Username = UNameTbl.Text;
                    Employees employ = new Employees();
                    employ.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName Or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Con.Close();
            }
        }

    }
}

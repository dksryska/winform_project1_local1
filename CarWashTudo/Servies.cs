using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashTudo
{
    public partial class Servies : Form
    {
        // 화면에 바로 보여줄 것들
        public Servies()
        {
            InitializeComponent();
            displayServices();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\test\Documents\CarWasDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void Reset()
        {
            SNameTb.Text = "";
            PriceTb.Text = "";
        }

        private void displayServices()
        {
            Con.Open();
            string Query = "select * from ServiceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ServiceDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void SNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        // Save 버튼
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ServiceTbl(SName, Sprice) values(@SN, @SP)", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@Sp", PriceTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service Saved");

                    Con.Close();
                    Reset();
                    displayServices();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Edit 버튼
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update ServiceTbl set SName=@Sen,Sprice=@Sep", Con);
                cmd.Parameters.AddWithValue("@Sen", SNameTb.Text);
                cmd.Parameters.AddWithValue("@Sep", PriceTb.Text);
                cmd.Parameters.AddWithValue("@SeId", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Saved");

                Con.Close();

                Reset();
                displayServices();
            }
        }

        // Delete 버튼
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Services");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from ServiceTbl where SId=@SeId", Con);
                cmd.Parameters.AddWithValue("@SeId", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Deleted");

                Con.Close();
                displayServices();
                Reset();
            }
        }

        // Cancel 버튼
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Guna2 DataGridView
        int Key = 0;
        private void ServiceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = ServiceDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = ServiceDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ServiceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Logins Obj = new Logins();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Employees employ = new Employees();
            this.Hide();
            employ.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Servies Obj = new Servies();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Logins Obj = new Logins();
            Obj.Show();
            this.Hide();
        }
    }
}

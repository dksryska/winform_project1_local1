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
    public partial class Customers : Form
    {
        // 화면에 바로 보여줄 것들
        public Customers()
        {
            InitializeComponent();
            displayCust();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\test\Documents\CarWasDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void Reset()
        {
            CNameTb.Text = "";
            CAddTb.Text = "";
            CCarTb.Text = "";
            CPhoneTb.Text = "";
            CStatusCb.SelectedIndex = -1;
        }

        private void displayCust()
        {
            Con.Open();
            string Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        // Cancel 버튼
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Save 버튼
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAddTb.Text == "" || CStatusCb.SelectedIndex == -1 || CPhoneTb.Text == "" || CCarTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CName, CPhone, CAdd, CStatus, CCar) values(@Cn, @Cp, @Ca, @Cs, @Cc)", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", CPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAddTb.Text);
                    cmd.Parameters.AddWithValue("@Cs", CStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Cc", CCarTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Saved");

                    Con.Close();

                    Reset();
                    displayCust();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //Edit 버튼
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAddTb.Text == "" || CStatusCb.SelectedIndex == -1 || CPhoneTb.Text == "" || CCarTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update CustomerTbl set CName=@Cun, CPhone=@Cup, CAdd=@Cua, CStatus=@Cus, CCar=@Cuc where CId=@CuId", Con);
                cmd.Parameters.AddWithValue("@Cun", CNameTb.Text);
                cmd.Parameters.AddWithValue("@Cup", CPhoneTb.Text);
                cmd.Parameters.AddWithValue("@Cua", CAddTb.Text);
                cmd.Parameters.AddWithValue("@Cus", CStatusCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Cuc", CCarTb.Text);
                cmd.Parameters.AddWithValue("@CuId", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Saved");

                Con.Close();

                Reset();
                displayCust();
            }
        }

        int Key = 0;
        // Delete 버튼
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Customer");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CId=@CuId", Con);
                cmd.Parameters.AddWithValue("@CuId", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted");

                Con.Close();
                displayCust();
                Reset();
            }
        }

        // guna2 DataGridView임
        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            CPhoneTb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            CAddTb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();
            CStatusCb.SelectedItem = CustomersDGV.SelectedRows[0].Cells[4].Value.ToString();
            CCarTb.Text = CustomersDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CNameTb_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Servies Obj = new Servies();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

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
// DB 사용하기 위한 것임
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CarWashTudo
{
    public partial class Employees : Form
    {
        // 화면에 바로 보여줄 것들
        public Employees()
        {
            InitializeComponent();
            displayEmp();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\test\Documents\CarWasDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        // Save 버튼
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ENameTbl.Text == "" || EPhoneTb.Text == "" || EGenCb.SelectedIndex == -1 || EAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl(EName, EPhone, EGen, EAdd, EPass) values(@En, @Ep, @Eg, @Ea, @Epa)", Con);
                    cmd.Parameters.AddWithValue("@En", ENameTbl.Text);
                    cmd.Parameters.AddWithValue("@Ep", EPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Eg", EGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Ea", EAddTb.Text);
                    cmd.Parameters.AddWithValue("@Epa", PasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved");

                    Con.Close();

                    Reset();
                    displayEmp();
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
            if (ENameTbl.Text == "" || EPhoneTb.Text == "" || EGenCb.SelectedIndex == -1 || EAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update EmployeeTbl set EName=@En, EPhone=@Ep, EGen=@Eg, EAdd=@Ea where EId=@EmId", Con);
                cmd.Parameters.AddWithValue("@En", ENameTbl.Text);
                cmd.Parameters.AddWithValue("@Ep", EPhoneTb.Text);
                cmd.Parameters.AddWithValue("@Eg", EGenCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Ea", EAddTb.Text);
                cmd.Parameters.AddWithValue("@EmId", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Updated");

                Con.Close();

                Reset();
                displayEmp();
            }
        }

        // Delete 버튼
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Employee");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EId=@EmId", Con);
                cmd.Parameters.AddWithValue("@EmId", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted");

                Con.Close();
                displayEmp();
                Reset();
            }
        }

        // Table의 내용을 화면에 뿌려줌
        int Key = 0;
        private void EmployeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ENameTbl.Text = EmployeesDGV.SelectedRows[0].Cells[1].Value.ToString();
            EPhoneTb.Text = EmployeesDGV.SelectedRows[0].Cells[2].Value.ToString();
            EGenCb.Text = EmployeesDGV.SelectedRows[0].Cells[3].Value.ToString();
            EAddTb.Text = EmployeesDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (ENameTbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            ENameTbl.Text = "";
            EAddTb.Text = "";
            EPhoneTb.Text = "";
            EGenCb.SelectedIndex = -1;
        }

        private void displayEmp()
        {
            Con.Open();
            string Query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeesDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        // Cancel 버튼
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ENameTbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Logins Obj = new Logins();
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
            Servies Obj = new Servies();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

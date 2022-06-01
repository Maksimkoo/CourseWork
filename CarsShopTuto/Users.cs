using System.Data;
using System.Data.SqlClient;

namespace CarsShopTuto
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksym\Documents\CarShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl"; // displays all data from the DB
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        // SAVE BUTTON
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }

        // RESET BUTTON
        private void Reset()
        {
            UnameTb.Text = "";
            PassTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // DELETE BUTTON
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }

        // DGV
        int key = 0; // id предмету по якому клікнув користувач
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.CurrentRow.Cells[1].Value.ToString();
            PhoneTb.Text = UserDGV.CurrentRow.Cells[2].Value.ToString();
            AddTb.Text = UserDGV.CurrentRow.Cells[3].Value.ToString();
            PassTb.Text = UserDGV.CurrentRow.Cells[4].Value.ToString();
            
            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }

        // EDIT BUTTON
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set UName='" + UnameTb.Text + "',UPhone='" + PhoneTb.Text + "',UAdd='" + AddTb.Text + "',UPass='" + PassTb.Text + "' where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        /**************** LOGOUT ******************/
        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CarsShop Obj = new CarsShop();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

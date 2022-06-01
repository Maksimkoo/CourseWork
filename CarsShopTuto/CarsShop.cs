using System.Data;
using System.Data.SqlClient;

namespace CarsShopTuto
{
    public partial class CarsShop : Form
    {
        public CarsShop()
        {
            InitializeComponent();
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       
        /// /////////////////////////////////////////////// Carts Parts Shop Module ////////////////////////////////////////////////////////
        
        // Database conection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksym\Documents\CarShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from ShopTbl"; // displays all data from the DB
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            Con.Open();
            string query = "select * from ShopTbl where CCat='"+CatCbSearchCb.SelectedItem.ToString()+"'"; // displays data by categories
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        // SAVE BUTTON
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(CTitleTb.Text =="" || CProducerTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || CCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ShopTbl values('" + CTitleTb.Text + "','" + CProducerTb.Text + "','" + CCatCb.SelectedItem.ToString() + "'," + QtyTb.Text + "," + PriceTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Parts Saved Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
               
            }
        }

        private void CatCbSearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void button5_Click(object sender, EventArgs e) // Refresh button
        {
            populate();
        }

        // RESET BUTTON
        private void Reset()
        {
            CTitleTb.Text = "";
            CProducerTb.Text = "";
            CCatCb.SelectedIndex = -1;
            QtyTb.Text = "";
            PriceTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
           
        }

        int key = 0;

        // DGV
        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CTitleTb.Text = CarsDGV.CurrentRow.Cells[1].Value.ToString();
            CProducerTb.Text = CarsDGV.CurrentRow.Cells[2].Value.ToString();
            CCatCb.SelectedItem = CarsDGV.CurrentRow.Cells[3].Value.ToString();
            QtyTb.Text = CarsDGV.CurrentRow.Cells[4].Value.ToString();
            PriceTb.Text = CarsDGV.CurrentRow.Cells[5].Value.ToString();
            if (CTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CarsDGV.CurrentRow.Cells[0].Value.ToString());
            }
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
                    string query = "delete from ShopTbl where CId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Parts Deleted Successfully");
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

        // EDIT BUTTON
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CTitleTb.Text == "" || CProducerTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || CCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ShopTbl set CTitle='"+CTitleTb.Text+"',CProducer='"+CProducerTb.Text+"',CCat='"+CCatCb.SelectedItem.ToString()+"',CQty="+QtyTb.Text+",CPrice="+PriceTb.Text+" where CId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Parts Updated Successfully");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /**************** LOGOUT **************/
        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }

        private void CarsShop_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
    }


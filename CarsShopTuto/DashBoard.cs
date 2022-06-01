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

namespace CarsShopTuto
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        /**************** LOGOUT *****************/
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

        private void label7_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksym\Documents\CarShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(CQty) from ShopTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PartsStocklbl.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(Amount) from BillTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Amountlbl.Text = dt1.Rows[0][0].ToString();
            Con.Close();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from UserTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            UserTotallbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();

        }

        private void Amountlbl_Click(object sender, EventArgs e)
        {

        }

        private void PartsStocklbl_Click(object sender, EventArgs e)
        {

        }
    }
}

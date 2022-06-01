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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /**************************** UPDATE IN THE DGV QTY  AFTER ADDING TO THE BILL ********************************/
        private void UpdateCarsParts()
        {
           int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                Con.Open();
                string query = "update ShopTbl set CQty=" + newQty + " where CId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Parts Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ex.Message");
            }
        }

        /**************************** ADDING PARTS TO THE BILL ******************************/
        int n = 0, Grdtotal=0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if(QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text)>stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceeTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                //newRow.Cells[0].Value = n + 1;
                newRow.Cells[0].Value = CTitleTb.Text;
                newRow.Cells[1].Value = PriceeTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateCarsParts();
                Grdtotal = Grdtotal + total;
                TotalLbl.Text = "AllT: "+Grdtotal;
            }
        }

        int key = 0,stock=0;
        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CTitleTb.Text = CarsDGV.CurrentRow.Cells[1].Value.ToString();
            //QtyTb.Text = CarsDGV.CurrentRow.Cells[4].Value.ToString();
            PriceeTb.Text = CarsDGV.CurrentRow.Cells[5].Value.ToString();
            if (CTitleTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(CarsDGV.CurrentRow.Cells[0].Value.ToString());
                stock = Convert.ToInt32(CarsDGV.CurrentRow.Cells[4].Value.ToString());
            }
        }

                   /**************** Print Button **********************/
        private void EditBtn_Click(object sender, EventArgs e)
        {
            

            if (ClientNameTb.Text == "" || CTitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('"  + UserNameLbl.Text + "','" + ClientNameTb.Text + "'," + Grdtotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                

            }
        }

        int /*prodid*/ prodqty, prodprice, tottal, pos = 60;

        /**************** LOGOUT **************/
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CTitleTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        /**************** User Name is fetched based on login ***************/
        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Cars Parts Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(80));
            e.Graphics.DrawString("PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                //prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column1"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column2"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column3"].Value);
                tottal = Convert.ToInt32(row.Cells["Column4"].Value);

                //e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(30, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(100, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(160, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(210, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: " + Grdtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("***********Cars Parts Shop***********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(26, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            Grdtotal = 0;
        }

        

        private void Reset()
        {
            CTitleTb.Text = "";
            QtyTb.Text = "";
            PriceeTb.Text = "";
            ClientNameTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

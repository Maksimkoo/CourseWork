using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsShopTuto
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UPassTb.Text == "Password")
            {
                CarsShop Obj = new CarsShop();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password.Contact The Admin");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void UPassTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

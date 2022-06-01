namespace CarsShopTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // downloading page 
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            Myprogress.Value = startpos;
            PercentageLbl.Text = startpos + "%";
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
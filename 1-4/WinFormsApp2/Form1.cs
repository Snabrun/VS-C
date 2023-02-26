namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tulostavaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            tulostusLB.Text = teksti;
            tulostusLB.Visible= true;
        }
    }
}
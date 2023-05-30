namespace teht_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeButton_Click(object sender, EventArgs e)
        {
            DateTime synt = dateTimePicker1.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt-synt).TotalDays);
            vuosLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            kuuLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            paLB.Text = (erotus + " päivää");
            tunLB.Text = (erotus * 24 + " tuntia");
            minLB.Text = (erotus * 24 * 60 + " sekuntia");
            sekLB.Text = (erotus * 24 * 3600 + " sekuntuia");
            vuosLB.Visible = true;
            kuuLB.Visible = true;
            paLB.Visible = true; 
            tunLB.Visible = true; 
            minLB.Visible = true; 
            sekLB.Visible = true;
        }
    }
}
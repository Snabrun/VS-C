namespace DataTimerPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = syntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            vuosiLB.Text = Math.Ceiling(erotus / 365.25) + " kuukautta";
            paivaLV.Text = (erotus + " päivää");
            tunttiLB.Text = (erotus * 24 + " tuntia");
            minLB.Text = (erotus * 24 * 60 + " minuuttia");
            sekLB.Text = (erotus * 24 * 3600 + " sekuntia");
            vuosiLB.Visible = true;
            kuukausiLV.Visible = true;
            paivaLV.Visible = true;
            tunttiLB.Visible = true;
            minLB.Visible = true;
            sekLB.Visible = true;
        }
    }
}
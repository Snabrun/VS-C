namespace Teht_7__8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilometriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
                laina = Convert.ToDouble(LainaTB.Text);
                nesteet = Convert.ToDouble(NesteetTB.Text);
                vakuutus = Convert.ToDouble(VakuutuksetTB.Text);
                pesut = Convert.ToDouble(PesutTB.Text);
                huollot = Convert.ToDouble(HuollotTB.Text);
                renkaat = Convert.ToDouble(RenkaatTB.Text);
                muut = Convert.ToDouble(MuutTB.Text);
                energia = Convert.ToDouble(HuollotTB.Text);
                kilometrit = Convert.ToDouble(KilometriCB.Text);
                kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + energia + muut) / (kilometrit/12);
                VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
                VastausLB.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
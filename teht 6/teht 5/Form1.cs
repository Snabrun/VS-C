namespace teht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salasanaPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if (kayttajaTB.Text == "Egor" && salasanaTB.Text == "Testi@123")
            {
                tervetuloaPL.Visible= true;

            }
            else
            {
                virheLB.Visible = true;
                virheLB.Text = "Käyttäjätunnus tai salasana on virheellinen";
            }
        }
    }
}
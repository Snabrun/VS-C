namespace SalasananTarkastus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salasanaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            if (kauttajaTB.Text == "Egor" && salasanaTB.Text == "AbiGap84")
            {
                salasanaPanel.Visible= false;
                salasanaOikeinP.Visible = true;
                salasanaOikeinP.BringToFront();

            }
            else
            {
                virheviestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen";
                virheviestiLB.Visible = true;
            }
        }
    }
}
namespace laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Luku1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            string merkki = LaskuCB.SelectedItem.ToString();
            float luku1, luku2, Vastaus;

            luku1 = float.Parse(Luku1TB.Text);
            luku2 = float.Parse(Luku2TB.Text);
            switch (merkki)
            {
                case "+":
                    Vastaus = luku1 + luku2;
                    break;
                case "-":
                    Vastaus = luku1 - luku2;
                    break;
                case "*":
                    Vastaus = luku1 * luku2;
                    break;
                case "/":
                    Vastaus = luku1 / luku2;
                    break;
                default:
                    Vastaus = 0;
                    break;
            }
            VastausLB.Text = Convert.ToString(Vastaus);
            VastausLB.Visible = true;
        }

        private void Vastaus_Click(object sender, EventArgs e)
        {

        }
    }
}

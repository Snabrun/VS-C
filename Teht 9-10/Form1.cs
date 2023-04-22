namespace Teht_9_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double temp = Convert.ToDouble(textBox1.Text);
            if(celRB.Checked)
            {
                vastaus = temp * 1.8 + 32;
                vastausLB.Text = temp + " Fahrenheitia on " + vastaus + " Celsius astetta";
                vastausLB.Visible = true;
            }
            else if ( fahRB.Checked) 
            {
                vastaus = (temp - 32) / 1.8;
                vastausLB.Text = temp + " Celsiusta on " + vastaus + " Fahrenheit astetta";
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = temp + "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                vastausLB.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
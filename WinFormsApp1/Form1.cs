namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0 , pituus = 0 ;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus *  pituus), 2);
            if(bmi< 18.5 )
            {
                vastausLB.Text = "Painoindeksi on: " + bmi;
                vastausLB.ForeColor= Color.Aqua;
                vastausLB2.Text = "Alipaino";
                vastausLB2.ForeColor= Color.Aqua;
                vastausLB2.Visible= true;
                vastausLB.Visible= true;
            }
            else if(bmi < 25)
            {
                vastausLB.Text = "Painoindeksi on: " + bmi;
                vastausLB.ForeColor = Color.Green;
                vastausLB2.Text = "Normaalipaino";
                vastausLB2.ForeColor = Color.Green;
                vastausLB2.Visible = true;
                vastausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                vastausLB.Text = "Painoindeksi on: " + bmi;
                vastausLB.ForeColor = Color.Gold;
                vastausLB2.Text = "Ylipaino";
                vastausLB2.ForeColor = Color.Gold;
                vastausLB2.Visible = true;
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "Painoindeksi on: " + bmi;
                vastausLB.ForeColor = Color.Red;
                vastausLB2.Text = "Huomattava ylipaino";
                vastausLB2.ForeColor = Color.Red;
                vastausLB2.Visible = true;
                vastausLB.Visible = true;
            }
        }
    }
}
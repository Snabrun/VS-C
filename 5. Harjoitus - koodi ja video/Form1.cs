namespace _5._Harjoitus___koodi_ja_video
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " ";
                    }
                    vastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }


        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    

        private void uusiLukuTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}
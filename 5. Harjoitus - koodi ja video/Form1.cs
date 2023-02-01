namespace _5._Harjoitus___koodi_ja_video
{
    public partial class Form1 : Form
    {
        
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
        List<int> jono = new List<int>();
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    vastausTB.Text = "";  
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                      vastausTB.Text += jasen + " ";
                    }
                    vastausTB.Visible = true;
                }

            }
            else
            {               
                jono.Add(Int32.Parse(uusiLukuTB.Text));
                uusiLukuTB.Text = "";
                
            }

            if (e.KeyChar == (char)Keys.Escape)
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
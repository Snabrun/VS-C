namespace teht_16
{
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            int minuutit = int.Parse(minuuttiCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekCM.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTM.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTM.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopBT.Enabled= false;
            for (int i=0; i < 60; i++) 
            {
                minuuttiCB.Items.Add(i.ToString());
                sekCM.Items.Add(i.ToString());
            }
            minuuttiCB.SelectedIndex = 30;
            sekCM.SelectedIndex = 0;
        }

        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();

            }
            else
            {
                ajastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
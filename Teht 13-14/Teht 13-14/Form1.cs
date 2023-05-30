using Microsoft.VisualBasic.ApplicationServices;

namespace Teht_13_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible= false;
            string[] tytot = File.ReadAllLines("C:/Users/shcka/Downloads/Telegram Desktop/tytot.txt");
            string[] pojat = File.ReadAllLines("C:/Users/shcka/Downloads/Telegram Desktop/pojat.txt");
            string nimi = nimiTB.Text;
            int laskuriP = 1;
            int laskuriT = 1;
            foreach ( string poika in pojat)
            {
                if (nimi == poika)
                {
                    vastausLB.Text = "Nimesi on " + laskuriP + ". suosituin poikien nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskuriP++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi == tytto ) 
                {
                    vastausLB.Text = "Nimesi on " + laskuriT + ". suosituin tyttöjen nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskuriT++;
            }
            if (vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta!";
                vastausLB.Visible = true;
            }
        
        
        
        
        }
    }
}
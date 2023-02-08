using System.Drawing.Text;

namespace Teht_12
{
    public partial class Form1 : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        public Form1()
        {
            InitializeComponent();
            vastausARB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            vastausBRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            vastausCRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            vastausDRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void kysymysLB_Click(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                kysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                vastausARB.Enabled= false;
                vastausBRB.Enabled= false;
                vastausCRB.Enabled= false;
                vastausDRB.Enabled= false;
                for(int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            tyhjaaVastaus(); 
        }
        private void tyhjaaVastaus()
        {
            if(vastausARB.Checked == true)
            {
                vastausARB.Checked = false;
                laskuri--;
            }
            if (vastausBRB.Checked == true)
            {
                vastausBRB.Checked = false;
                laskuri--;
            }
            if (vastausCRB.Checked == true)
            {
                vastausCRB.Checked = false;
                laskuri--;
            }
            if (vastausDRB.Checked == true)
            {
                vastausDRB.Checked = false;
                laskuri--;
            }          
        }
    }
}
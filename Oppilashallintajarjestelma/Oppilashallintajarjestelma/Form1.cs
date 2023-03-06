using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oppilashallintajarjestelma
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new  OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void tietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            enimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            onroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
            idTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            enimiTB.Text = "";
            snimiTB.Text = "";
            puhTB.Text = "";
            emailTB.Text = "";
            onroTB.Text = "";
        }

        private void talennaBT_Click(object sender, EventArgs e)
        {
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puhelin = puhTB.Text;
            String email = emailTB.Text;
            int onro = Int32.Parse(onroTB.Text);

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                if(lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else
                {
                    MessageBox.Show("Utta opiskelijaa ei pystyty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK,MessageBoxIcon.Information );

                }
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            }
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            {
                String enimi = enimiTB.Text;
                String snimi = snimiTB.Text;
                String puhelin = puhTB.Text;
                String email = emailTB.Text;
                int onro = Int32.Parse(onroTB.Text);

                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
                {
                    MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                    if (lisaaAsiakas)
                    {
                        MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Utta opiskelijaa ei pystyty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                }
            }
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = idTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }
    }
}

namespace teht17
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiTiedosto()
        {
            try
            {
                if(!string.IsNullOrEmpty(tekstiTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");
                }
                else
                {
                    tekstiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }

        }
        private void TalennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(tekstiTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, tekstiTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tekstiTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa! ");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            fontDialog= new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
        }

        private void talennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TalennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tekstiTB.Text))
                {
                    TalennaTiedosto();
                }
                else
                {
                    this.Close();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    tekstiTB.Font= fontDialog.Font;
                }
            }
            catch (Exception ex )
            {

            }
        }
    }
}
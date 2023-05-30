using System.Diagnostics;

namespace teht_15_16
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkati = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kelloLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkati.Elapsed);
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            sekkati.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkati.Stop();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            sekkati.Reset();
        }
    }
}
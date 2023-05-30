namespace teht14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string teksti = File.ReadAllText("C:/Users/shcka/Downloads/Telegram Desktop/demo.txt");
            syottoTB.Text = teksti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += syottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Users/shcka/Downloads/Telegram Desktop/demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
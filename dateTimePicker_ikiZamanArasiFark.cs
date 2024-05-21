namespace dateTimeİkiZamanArası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime zaman1 = new DateTime(); //tairh nesnesi oluşturduk
        DateTime zaman2 = new DateTime();
        private TimeSpan zamanFarki; //zamanlar arasında fark hesaplamada hata olmaması için

        private void button1_Click(object sender, EventArgs e)
        {
            zaman1 = dateTimePicker1.Value;
            listBox1.Items.Add(zaman1); //seçtiğimiz tarihi nesne yardımı ile yazdırdık
            zaman2 = dateTimePicker2.Value;
            listBox1.Items.Add(zaman2);

            zamanFarki = zaman2 - zaman1;

            listBox2.Items.Add(zamanFarki);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }
    }
}

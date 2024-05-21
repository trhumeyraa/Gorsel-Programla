namespace combobox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nevþehir");
            comboBox1.Items.Add("Konya");
        }
//comboboxtaki deðeri selectedIndex kullanmadan seçilen deðere göre ilçesini yazmaa

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Nevþehir")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Göreme");
                listBox1.Items.Add("Ürgüp");

            }
            else if (comboBox1.Text == "Konya")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Meram");
                listBox1.Items.Add("selçuklu");

            }
        }
    }
}

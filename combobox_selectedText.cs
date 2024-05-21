namespace combobox3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //textboxa girilen ili hem comboboxda seçsin hemde listboxa ilçe yazdýrsýn. tek tek selectedIndex yapmayalým

        private void button1_Click(object sender, EventArgs e)
        {
            String isim = Convert.ToString(textBox1.Text);


            comboBox1.SelectedText = isim;

            if (isim == "Nevþehir")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Göreme");
                listBox1.Items.Add("Ürgüp");
                comboBox1.Items.Clear();

            }
            else if (isim == "Konya")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Meram");
                listBox1.Items.Add("selçuklu");

            }
            else if (isim == "Ankara")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Çankaya");
                listBox1.Items.Add("Keçiören");

            }
            else if (isim == "Ýstanbul")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Kadýköy");
                listBox1.Items.Add("Ümraniye");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

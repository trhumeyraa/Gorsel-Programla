namespace WinFormsApp1
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
//comboboxa girilen deðerlerin index deðerine göre ilçesini yazdýrma

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Göreme");
                listBox1.Items.Add("Ürgüp");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Meram");
                listBox1.Items.Add("selçuklu");

            }
        }

       
    }
}

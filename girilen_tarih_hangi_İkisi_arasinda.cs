namespace girilenTarihiHangiİkisiArasinda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime zaman = new DateTime();
        DateTime zaman2 = new DateTime();

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime zaman = dateTimePicker1.Value.Date;
            DateTime zaman2= dateTimePicker2.Value.Date;
            DateTime tarih;

            tarih = Convert.ToDateTime(textBox1.Text);

            if (tarih == zaman)
            {
                MessageBox.Show("Girdiginiz deger baslangic tarihi ile aynı.");
            }
            else if (tarih == zaman2)
            {
                MessageBox.Show("Girdiginiz deger bitis tarihi ile aynı.");
            }
            else if (tarih < zaman)
            {
                MessageBox.Show("Girdiginiz deger baslangic tarihinden once.");
            }
            else if (tarih > zaman2)
            {
                MessageBox.Show("Girdiginiz deger bitis tarihinden sonra.");
            }
            else
            {
                MessageBox.Show("Girdiginiz deger her iki degerin arasindadir.");
            }
        }
    }
}

namespace ikiTarihArasiKacTaneOGunHesaplar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime zaman = new DateTime();
        DateTime zaman2 = new DateTime();
        private TimeSpan fark;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime zaman = dateTimePicker1.Value;
            DateTime zaman2 = dateTimePicker2.Value;
            DateTime tarih = Convert.ToDateTime(textBox1.Text);

            if (tarih == DayOfWeek.Monday )
            {
                while (true)
                {
                    int sayac = 0;
                    sayac++;
                    MessageBox.Show("toplam gun: " + sayac);
                }
            }


        }
    }
}

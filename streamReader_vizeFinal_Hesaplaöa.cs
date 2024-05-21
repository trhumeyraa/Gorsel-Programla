namespace vizefinalorthesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader nesne = new StreamReader("\"C:\\Users\\humey\\Desktop\\sinavNotu.txt.txt\"");
            string satir1;
            string vize = "";
            string final = "";

            while ((satir1 = nesne.ReadLine()) != null)
            {
                vize = satir1.Substring(0, 2);
                final = satir1.Substring(3, 2);
                int vize2= Convert.ToInt32(vize);
                int final2= Convert.ToInt32(final);

                double ortalama = ((vize2 *0.4) + (final2 * 0.6)) / 2;
                listBox1.Items.Add(ortalama);
            }





        }
    }
}

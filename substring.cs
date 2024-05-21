using System.Windows.Forms;

namespace substring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //substring kullanýmý 
            var fs = new FileStream("oku.txt", FileMode.Open);
            for (int i = 0; i < fs.Length; i++)
            {
                listBox1.Items.Add((char)fs.ReadByte());

            }
            fs.Close();

            String Text = "Hacý Bektaþ Veli Üniversitesi";
            String Subs = Text.Substring(2, 4);
            Subs = Text.Substring(5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader("oku.txt");
            string satir1;
            while ((satir1=sr1.ReadLine()) != null)
            {
                listBox1.Items.Add(satir1);
                if (satir1.Contains("Veli"))
                {
                    label1.Text = satir1.Substring(satir1.Length);

                }
            }
        }
    }
}

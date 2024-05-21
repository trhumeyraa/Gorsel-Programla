using System.Collections;

namespace queue_stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue kuyruk = new Queue();
        int sira = 0;

        Stack yýgýn = new Stack();
        int sayac = 0;
        void listelestack()
        {
            listBox1.Items.Clear();
            foreach (var item in yýgýn)
            {
                listBox1.Items.Add(item);
            }
        }

        void listelequeue()
        {
            listBox1.Items.Clear();
            foreach (var item in kuyruk)
            {
                listBox1.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)

        {
            
            sira++;
            listBox1.Items.Add(sira);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sira--;
            listelequeue();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listelestack();
            sayac++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listelestack();
            sayac--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

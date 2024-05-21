namespace _2.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, GroupBox groupBox, TextBox textBox)
        {

            Control Gbox1 = ((Button)sender).Parent;

            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is TextBox)
                        {
                             (item2 as TextBox).Clear();
                        }
                    }
                }
            }
        }
    }
}


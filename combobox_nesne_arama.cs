namespace combobox4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("ListBox");
            comboBox1.Items.Add("Label");
            comboBox1.Items.Add("Button");
            comboBox1.Items.Add("TextBox");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Control Gbox = ((Button)sender).Parent;
            int sayac = 0;

            if (comboBox1.SelectedIndex == 0)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control item2 in (item as GroupBox).Controls)
                        {
                            if (item2 is ListBox)
                            {
                                sayac++;
                                label5.Text = Convert.ToString(sayac);

                            }

                        }
                    }
                }
            }


            else if (comboBox1.SelectedIndex == 1) {
                Control goupBox1 = ((Button)sender).Parent;

            
                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control item2 in (item as GroupBox).Controls)
                        {
                            if (item2 is Label)
                            {
                                sayac++;
                                label5.Text = Convert.ToString(sayac);
                                a= combobox4.Text
                            }

                        }
                    }
                }

            }


            else if (comboBox1.SelectedIndex == 2)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control item2 in (item as GroupBox).Controls)
                        {
                            if (item2 is Button)
                            {
                                sayac++;
                                label5.Text = Convert.ToString(sayac);

                            }

                        }
                    }
                }

            }


            else if (comboBox1.SelectedIndex == 3)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control item2 in (item as GroupBox).Controls)
                        {
                            if (item2 is TextBox)
                            {
                                sayac++;
                                label5.Text = Convert.ToString(sayac);

                            }

                        }
                    }
                }

            }




        }

    }
}


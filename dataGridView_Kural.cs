namespace DataGridV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "BÝRÝNCÝ";
            dataGridView1.Columns[1].Name = "ÝKÝNCÝ";
            dataGridView1.Columns[2].Name = "ÜÇÜNCÜ";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;


            dataGridView1.Rows.Add("100", "200", "300");
        }
    }
}

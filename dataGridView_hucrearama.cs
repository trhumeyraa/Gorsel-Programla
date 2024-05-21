namespace datagridview2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Kolon1";
            dataGridView1.Columns[1].Name = "Kolon2";
            dataGridView1.Columns[2].Name = "Kolon3";

            dataGridView1.Rows.Add("1", "2", "3");
            dataGridView1.Rows.Add("4", "5", "6");
            dataGridView1.Rows.Add("Ayse", "Murat", "Gokhan");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0) 
            {
                if (e.RowIndex == 1)
                {
                    label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();   
                }
            
            
            }
        }
    }
}

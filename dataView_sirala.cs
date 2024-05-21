using System.Data;

namespace dataView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.DefaultView.Sort = "Ort ASC";
            tbl = tbl.DefaultView.ToTable();
            dataGridView1.DataSource= tbl;
        }
       
    }
}

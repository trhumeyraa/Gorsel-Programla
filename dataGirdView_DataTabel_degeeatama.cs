using System;
using System.Data;
using System.Drawing;
using System.Reflection;

namespace datagridviewedatatabelatamak
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
        DataTable list = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Columns.Add("Ders Adý", typeof(string));
            list.Columns.Add("Vize", typeof(int));
            list.Columns.Add("Final", typeof(int));
            list.Columns.Add("Ortalama", typeof(double));

            dataGridView1.DataSource = list;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string dersadi = textBox1.Text;
            int vize = Convert.ToInt32(textBox2.Text);
            int final = Convert.ToInt32(textBox3.Text);
            list.Rows.Add(dersadi, vize, final, 0.0);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {  //secili satir olup olamdýgýný sorgulama
               // birden fazla satir secebilme özelligi acýlýrsa (multiselect= true) 0dan fazla olup olmadýgý
               //bakýlýr          
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index); //secili satiri silme

            }
            else
            {
                MessageBox.Show("lütfen satýr seçin");
            }
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int vize = Convert.ToInt32(list.Rows[index][1]);
                int final = Convert.ToInt32(list.Rows[index][2]);

                list.Rows[index][3] =
                    (double)vize * 0.4 + (double)final * 0.6;

                dataGridView1.DataSource = list;
            }
        }

        private void allcount_Click(object sender, EventArgs e)
        {
            int vize = 0;
            int final = 0;

            int satirsayi = dataGridView1.RowCount;
            for (int i = 0; i < satirsayi - 1; i++)
            { //satirsayisi-1 yapmamýzýn sebebi tabloda en altta hep boþ bir satir olur ve bunu da iþlemden sayar ama dolu olmadaýðý için hata verir.            {
                vize = Convert.ToInt32(list.Rows[i][1]);
                final = Convert.ToInt32(list.Rows[i][2]);

                list.Rows[i][3] =
                    (double)vize * 0.4 + (double)final * 0.6;

                dataGridView1.DataSource = list;
            }
        }

        private void sirala_Click(object sender, EventArgs e)
        {
            /*DataTable tbl = new DataTable();
            tbl.DefaultView.Sort = "Ortalama ASC";
            tbl = tbl.DefaultView.ToTable();
            dataGridView1.DataSource = tbl;*/

            list = sirala(list, "Ortalama", "DESC");
            dataGridView1.DataSource = list;

        }

        public static DataTable sirala (DataTable dt, string sutun, string yon)
        {
            dt.DefaultView.Sort = sutun + " "+ yon;
            dt = dt.DefaultView.ToTable();
            return dt;
        }
    }

}

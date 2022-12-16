using IronXL;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sabina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Load data
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string filename = openFileDialog1.FileName;
                if (filename == null)
                {
                    MessageBox.Show("Путь к файлу пустой!");
                    return;
                }
                // подключение к файлу
                WorkBook workBook = WorkBook.Load(filename);
                // получение первого листа xlsx файла
                WorkSheet sheet = workBook.DefaultWorkSheet;

                int rowCount = sheet["B1"].Int32Value; // получение количества строк данных из ячейки

                DataTable dt = sheet[$"A3:I{rowCount+3}"].ToDataTable(true);

                dataGridView1.DataSource = dt;

                


            }
            catch
            {
                MessageBox.Show("Произошла ошибка чтения файла");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // провести анализ
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            // сортировка по убыванию  цены
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);

            // Подсчет суммы стоимости всех товраов
            int Sum = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Sum += Convert.ToInt32(dataGridView1[4, i].Value);
            }

            // Вычесление  Y_i
            double[] arrY = new double[dataGridView1.RowCount];
            for (int i = 0; i < arrY.Length ; i++)
            {
                arrY[i] = (Convert.ToDouble(dataGridView1[4, i].Value) / Sum ) * 100;
            }

            // Вычесление h_i
            double[] arrH= new double[dataGridView1.RowCount];
            arrH[0] = arrY[0];
            for (int i = 1; i < arrH.Length ; i++)
            {
                arrH[i] = arrY[i] + arrH[i - 1];
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (arrH[i] < 80)
                {
                    dataGridView1[dataGridView1.ColumnCount - 1, i].Value = "A";
                    continue;
                }
                if (arrH[i] < 95)
                {
                    dataGridView1[dataGridView1.ColumnCount - 1, i].Value = "B";
                    continue;
                }
                else
                {
                    dataGridView1[dataGridView1.ColumnCount - 1, i].Value = "C";
                    continue;
                }
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[dataGridView1.ColumnCount-1].Value.ToString() == "A")
                    row.DefaultCellStyle.BackColor = Color.Green;
                if (row.Cells[dataGridView1.ColumnCount - 1].Value.ToString() == "B")
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                if (row.Cells[dataGridView1.ColumnCount - 1].Value.ToString() == "C")
                    row.DefaultCellStyle.BackColor = Color.Orange;
            }

            // делаем поля для фильтра по группе активными
            comboBox1.Enabled = true;
            btn_sortByGrop.Enabled = true;
            comboBox1.SelectedIndex = 0;
        }

        private void btn_sortByGrop_Click(object sender, EventArgs e)
        {
            // ДЕЛАЕМ ВСЕ СТРОКИ ВИДИМЫМИ
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = true;

            var selectedType = comboBox1.SelectedIndex;
            string groupStr = "";

            switch (selectedType)
            {
                case 0:
                    groupStr = "A";
                    break;
                case 1:
                    groupStr = "B";
                    break;
                case 2:
                    groupStr = "C";
                    break;
            }
            dataGridView1.CurrentRow.Selected = false;
            dataGridView1.CurrentCell = null;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = dataGridView1[8, i].Value.ToString() == groupStr;

        }

        private void btn_sortDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = true;

            var selectedDate = dateTimePicker1.Value.ToShortDateString();

            dataGridView1.CurrentRow.Selected = false;
            dataGridView1.CurrentCell = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Visible = Convert.ToDateTime(dataGridView1[1, i].Value).ToShortDateString() == selectedDate;

        }

    }

}
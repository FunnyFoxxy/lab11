using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11._1_ManinYaroslav_AlekseevIgor_374
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string sort;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "товарDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.товарDataSet.Tovar);
            // типсортироки
            int ColCount = this.товарDataSet.Tovar.Columns.Count;
            // перебираемколонкивцикле
            for (int i = 0; i < ColCount; i++)
            {
                // получаем название колонок и добавляем в комбобокс
                this.comboBox1.Items.Add(this.товарDataSet.Tovar.Columns[i].ToString());



            }
            this.radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сортировать
                this.tovarBindingSource.Sort = this.comboBox1.Text + sort;
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {// При выборе радио кнопки 1
         // если радио кнопка 2 включена
            if (radioButton2.Checked)
            {
                radioButton2.Checked = false; // отключаемеё
            }
            sort = " ASC"; // тип сортировки по возростанию
            radioButton1.Checked = true; // Кнопкавыбрана
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {// При выборе радио кнопки 3
         // если радио кнопка 1 включена
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false; // отключаемеё
            }
            sort = " DESC"; // тип сортировки по возростанию
            radioButton2.Checked = true;
        }

        }

    }

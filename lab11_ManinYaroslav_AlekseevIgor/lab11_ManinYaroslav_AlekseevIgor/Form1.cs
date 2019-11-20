using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11_ManinYaroslav_AlekseevIgor
{
    public partial class Form1 : Form
    {
        public string sort; // типсортироки

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.таблица1TableAdapter.Fill(this.planetsDataSet.Таблица1);
            this.таблица1TableAdapter.Fill(this.planetsDataSet.Таблица1);
           
            int ColCount = this.planetsDataSet.Таблица1.Columns.Count;
           
            for (int i = 0; i < ColCount; i++)
            {
                this.comboBox1.Items.Add(this.planetsDataSet.Таблица1.Columns[i].ToString());

            }
            this.radioButton1.Checked = true;
        }
        
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Checked = false; // отключаемеё
            }
            sort = " ASC"; // тип сортировки по возростанию
            radioButton1.Checked = true; // Кнопкавыбрана
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false; // отключаемеё
            }
            sort = " DESC"; // тип сортировки по возростанию
            radioButton2.Checked = true; // Кнопкавыбрана


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.таблица1BindingSource.Sort = this.comboBox1.Text + sort;
        }
    }
}

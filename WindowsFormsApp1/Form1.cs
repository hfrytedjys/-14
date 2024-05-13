using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Добавление столбцов
         //   listView1.Columns.Add("Column 1", 100); // Название столбца и ширина

            // Установка свойств ListView для отображения в виде таблицы
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            // Добавление колонок
            listView1.Columns.Add("Дата", 100);
            listView1.Columns.Add("Месяц", 100);
            listView1.Columns.Add("Текст", 100);
            // Добавление строк


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "")
            {
                ListViewItem item1 = new ListViewItem(new[] { textBox2.Text, textBox3.Text, textBox1.Text }); // Создание строки с элементами
                listView1.Items.Add(item1);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }
    }
}

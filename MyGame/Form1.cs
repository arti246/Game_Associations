using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form1 : Form
    {
        Form2 newForm = new Form2();
        public int num_level;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Level1_Click(object sender, EventArgs e)
        { 
            newForm.label_level2.Text = "1";
            newForm.label_task.Text = "Для этого нужен билет";
            button_Level1.BackColor = Color.FromArgb(9, 191, 255);//доработать цвет первой кнопки
            newForm.BackColor = Color.FromArgb(9, 191, 255);
            newForm.label_block1.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.label_block2.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.label_block3.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.label_block4.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.label_block5.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.label_block6.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.label_block7.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.textBox1.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.button_add.ForeColor = Color.FromArgb(9, 191, 255);
            newForm.ShowDialog();
            num_level = 0;
        }

        private void button_Level2_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "2";
            newForm.label_task.Text = "Предмет в ванной";
            newForm.BackColor = Color.FromArgb(0, 255, 255);
            newForm.label_block1.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.label_block2.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.label_block3.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.label_block4.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.label_block5.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.label_block6.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.label_block7.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.textBox1.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.button_add.ForeColor = Color.FromArgb(0, 255, 255);
            newForm.ShowDialog();
            num_level = 1;
        }

        private void button_Level3_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "3";
            newForm.label_task.Text = "Вещи, которые часто теряются";
            newForm.BackColor = Color.FromArgb(0, 255, 192);
            newForm.label_block1.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.label_block2.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.label_block3.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.label_block4.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.label_block5.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.label_block6.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.label_block7.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.textBox1.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.button_add.ForeColor = Color.FromArgb(0, 255, 192);
            newForm.ShowDialog();
            num_level = 2;
        }

        private void button_Level4_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "4";
            newForm.label_task.Text = "Русское блюдо";
            newForm.BackColor = Color.FromArgb(0, 255, 87);
            newForm.label_block1.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.label_block2.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.label_block3.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.label_block4.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.label_block5.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.label_block6.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.label_block7.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.textBox1.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.button_add.ForeColor = Color.FromArgb(0, 255, 87);
            newForm.ShowDialog();
            num_level = 3;
        }

        private void button_Level5_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "5";
            newForm.label_task.Text = "Грызуны";
            newForm.BackColor = Color.FromArgb(96, 255, 1);
            newForm.label_block1.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.label_block2.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.label_block3.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.label_block4.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.label_block5.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.label_block6.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.label_block7.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.textBox1.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.button_add.ForeColor = Color.FromArgb(96, 255, 1);
            newForm.ShowDialog();
            num_level = 4;
        }

        private void button_Level6_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "6";
            newForm.label_task.Text = "Вид транспорта";
            newForm.BackColor = Color.FromArgb(163, 255, 1);
            newForm.label_block1.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.label_block2.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.label_block3.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.label_block4.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.label_block5.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.label_block6.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.label_block7.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.textBox1.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.button_add.ForeColor = Color.FromArgb(163, 255, 1);
            newForm.ShowDialog();
            num_level = 5;
        }

        private void button_Level7_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "7";
            newForm.label_task.Text = "Вкусный десерт";
            newForm.BackColor = Color.FromArgb(221, 255, 1);
            newForm.label_block1.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.label_block2.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.label_block3.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.label_block4.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.label_block5.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.label_block6.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.label_block7.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.textBox1.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.button_add.ForeColor = Color.FromArgb(221, 255, 1);
            newForm.ShowDialog();
            num_level = 6;
        }

        private void button_Level8_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "8";
            newForm.label_task.Text = "Первое, что я делаю утром";
            newForm.BackColor = Color.FromArgb(248, 255, 1);
            newForm.label_block1.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.label_block2.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.label_block3.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.label_block4.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.label_block5.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.label_block6.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.label_block7.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.textBox1.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.button_add.ForeColor = Color.FromArgb(248, 255, 1);
            newForm.ShowDialog();
            num_level = 7;
        }

        private void button_Level9_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "9";
            newForm.label_task.Text = "Кухонная утварь";
            newForm.BackColor = Color.FromArgb(253, 207, 0);
            newForm.label_block1.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.label_block2.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.label_block3.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.label_block4.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.label_block5.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.label_block6.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.label_block7.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.textBox1.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.button_add.ForeColor = Color.FromArgb(253, 207, 0);
            newForm.ShowDialog();
            num_level = 8;
        }

        private void button_Level10_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "10";
            newForm.label_task.Text = "Домашнее животное";
            newForm.BackColor = Color.FromArgb(254, 158, 1);
            newForm.label_block1.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.label_block2.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.label_block3.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.label_block4.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.label_block5.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.label_block6.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.label_block7.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.textBox1.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.button_add.ForeColor = Color.FromArgb(254, 158, 1);
            newForm.ShowDialog();
            num_level = 9;
        }

        private void button_Level11_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "11";
            newForm.label_task.Text = "Из этого можно собрать коллекцию";
            newForm.BackColor = Color.FromArgb(255, 109, 1);
            newForm.label_block1.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.label_block2.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.label_block3.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.label_block4.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.label_block5.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.label_block6.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.label_block7.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.textBox1.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.button_add.ForeColor = Color.FromArgb(255, 109, 1);
            newForm.ShowDialog();
            num_level = 10;
        }

        private void button_Level12_Click(object sender, EventArgs e)
        {
            newForm.label_level2.Text = "12";
            newForm.label_task.Text = "Фруктовые деревья";
            newForm.BackColor = Color.FromArgb(255, 63, 0);
            newForm.label_block1.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.label_block2.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.label_block3.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.label_block4.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.label_block5.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.label_block6.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.label_block7.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.textBox1.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.button_add.ForeColor = Color.FromArgb(255, 63, 0);
            newForm.ShowDialog();
            num_level = 11;
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            button_Level2.Enabled = true;
            button_Level3.Enabled = true;
            button_Level4.Enabled = true;
            button_Level5.Enabled = true;
            button_Level6.Enabled = true;
            button_Level7.Enabled = true;
            button_Level8.Enabled = true;
            button_Level9.Enabled = true;
            button_Level10.Enabled = true;
            button_Level11.Enabled = true;
            button_Level12.Enabled = true;
        }
    }
}

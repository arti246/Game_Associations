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
    public partial class Form2 : Form
    {
        public void Save() 
        { 
            
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            string[][] nums = new string[12][];
            nums[0] = new string[] {"автобус", "кино", "театр", "метро", "цирк", "поезд", "самолёт" };
            nums[1] = new string[] {"мочалка", "мыло", "раковина", "душ", "зубная щетка", "полотенце"};
            nums[2] = new string[] {"кошелек", "пульт", "телефон", "ключи", "очки", "носки"};
            nums[3] = new string[] {"борщ", "холодец", "уха", "блины", "оливье", "окрошка", "пельмени"};
            nums[4] = new string[] {"мышь", "суслик", "крыса", "бобёр", "белка", "бурундук", "хомяк"};
            nums[5] = new string[] {"машина", "троллейбус", "автобус", "поезд", "трамвай", "самолёт", "велосипед"};
            nums[6] = new string[] {"торт", "пирог", "тирамису", "мороженное", "кекс", "шоколад", "пирожное"};
            nums[7] = new string[] {"чищу зубы", "одеваюсь", "завтракаю", "зарядка", "моюсь", "встаю", "иду в душ"};
            nums[8] = new string[] {"кастрюля", "нож", "вилка", "половник", "сковорода", "ложка"};
            nums[9] = new string[] {"кот", "хомяк", "собака", "рыбки", "черепаха", "попугай"};
            nums[10] = new string[] {"бабочки", "картины", "монеты", "марки", "фантики", "машины", "книги", "игрушки"};
            nums[11] = new string[] {"яблоня", "груша", "апельсин", "персик", "вишня", "слива"};

            int KolSlov = 1;
            int num_level = 1;
            string text = textBox1.Text;
            for(int i = 0; i > 12; i++)
            {
                for (int j = 0; j < KolSlov; j++)
                {
                    if (text == nums[i][j] && num_level == i) 
                    { 
                        
                    }
                }

            }
        }
    }
}

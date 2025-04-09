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

namespace OOP_lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                int ch1 = textBox1.Text == "" ? 0 : Convert.ToInt32(textBox1.Text, 2);
                int ch2 = textBox2.Text == "" ? 0 : Convert.ToInt32(textBox2.Text, 2);
                int result = 0;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        result = ch1 + ch2;
                        break;
                    case 1:
                        result = ch1 - ch2;
                        break;
                    case 2:
                        result = ch1 * ch2;
                        break;
                    case 3:
                        if (ch2 != 0)
                            result = ch1 / ch2;
                        else
                        {
                            label5.Text = "Помилка: Ділення на нуль!";
                            return;
                        }
                        break;
                    default:
                        label5.Text = "Поважний користувач ☺☻ оберіть операцію";
                        return;
                }

                label5.Text = Convert.ToString(result, 2);
            }
            catch (FormatException)
            {
                label5.Text = "Помилка: Некоректне двійкове число!";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
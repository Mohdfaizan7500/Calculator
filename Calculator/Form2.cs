using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int value1=0, value2=0;
        int result;

        char sign;
        string second_value;

        
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
        }




        //-----------------------------------------------------------

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = textBox1.Text + "1";

        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "2";

        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "3";

        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "4";

        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "5";

        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "6";

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "7";

        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "8";

        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "9";

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "0";

        }

        private void button_point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void button_plus_Click_1(object sender, EventArgs e)
        {
            

            if (textBox1.Text=="")
            {

            }
            else
            {
                value1 = int.Parse(textBox1.Text);
                textBox2.Text = value1 + "+";
                sign = '+';
                textBox1.Text = "";

            }
            //textBox1.Text = textBox1.Text + "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                value1 = int.Parse(textBox1.Text);
                textBox2.Text = value1 + "-";
                sign = '-';
                textBox1.Text = "";

            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                value1 = int.Parse(textBox1.Text);
                textBox2.Text = value1 + "x";
                sign = '*';
                textBox1.Text = "";
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                value1 = int.Parse(textBox1.Text);
                textBox2.Text = value1 + "/";
                sign = '/';
                textBox1.Text = "";
            }
        }

        private void button_persent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                value1 = int.Parse(textBox1.Text);
                textBox2.Text = value1 + "%";
                sign = '%';
                textBox1.Text = result.ToString();
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

            }
            else 
            { 

                //second_value = Convert.ToString(textBox1.Text);
                textBox2.Text = textBox2.Text + textBox1.Text + "=";
                if (value1 == 0 && value2 == 0)
                {

                }
                else
                {

                    value2 = int.Parse(textBox1.Text);

                    if (sign == '+')
                    {
                        result = value1 + value2;
                        textBox1.Text = result.ToString();
                    }
                    else if (sign == '-')
                    {
                        result = value1 - value2;
                        textBox1.Text = result.ToString();
                    }
                    else if (sign == '*')
                    {
                        result = value1 * value2;
                        textBox1.Text = result.ToString();
                    }
                    else if (sign == '/')
                    {
                        result = value1 / value2;
                        textBox1.Text = result.ToString();
                    }
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if ((String.Compare(textBox1.Text, " ") < 0))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1 + 1);
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_menue_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button_menu_hide_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            value1 = 0;
            value2 = 0;
            textBox1.Text = "0";


        }


    }
}

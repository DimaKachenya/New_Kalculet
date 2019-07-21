using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double a, b;
        string number1, number2;
        char znak = 'p';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

       
        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
           
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
           
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            
        }

      

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
           

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
            
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
            
        }
      


        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";

        }
        private void Button16_Click(object sender, EventArgs e)
        {
            int pozishn = 0;
            textBox1.Text += "=";
            char[] arr = textBox1.Text.ToCharArray();
            int razmer = arr.Length;
            for (int i = 0; i < razmer; i++)
            {
                if (arr[i] == '*' || arr[i] == '/' || arr[i] == '+' || arr[i] == '-' || arr[i] == '^' || arr[i] == '√')
                {
                    znak = arr[i];
                    pozishn = i + 1;
                    break;
                }
                else
                    number1 += arr[i];



            }
            for (; pozishn < razmer; pozishn++)
            {
                if (arr[pozishn] == '=')
                    break;
                number2 += arr[pozishn];

            }


            a = Convert.ToDouble(number1);
            b = Convert.ToDouble(number2);

            if (znak == '+')
                textBox1.Text += a + b;
            else if (znak == '*')
                textBox1.Text += a * b;
            else if (znak == '-')
                textBox1.Text += a - b;
            else if (znak == '/')
                textBox1.Text += a / b;
            else if (znak == '^')
                textBox1.Text += Math.Pow(a, b);
            else if (znak == '√')
                textBox1.Text += Math.Sqrt(b);
            number1 = "";
            number2 = "";
            znak = 'p';


        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

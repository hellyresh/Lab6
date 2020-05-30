using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Lab6_Sokolova_Calculator
{
    public partial class Form1 : Form
    {
        double first = 0;
        double sec = 0;
        string lastOper = "";
        bool isOper = false;
        bool isEqual = false;
        bool isDot = false;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result.Text == "0" || isEqual)
                result.Text = button.Text;
            else result.Text += button.Text;
            isEqual = false;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (result.Text != "0" && !isDot && !isEqual)
            {
                result.Text += ",";
                isDot = true;
            }
                
        }


        private void equally_Click(object sender, EventArgs e)
        {
            if (isOper)
                sec = Convert.ToDouble(result.Text.Split(' ')[2]);
            else sec = Convert.ToDouble(result.Text);
                switch (lastOper)
            {
                case "+":
                    result.Text = (first + sec).ToString();
                    break;
                case "-":
                    result.Text = (first - sec).ToString();
                    break;
                case "*":
                    result.Text = (first * sec).ToString();
                    break;
                case "/":
                    result.Text = (first / sec).ToString();
                    break;
                default:
                    break;

            }
            Clipboard.SetText(result.Text);
            first = 0;
            sec = 0;
            lastOper = "";
            isOper = false;
            isEqual = true;
            isDot = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (result.Text != "0")
                result.Text = "0";
            first = 0;
            sec = 0;
            isOper = false;
            isEqual = false;
            isDot = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!isOper)
            {
                lastOper = button.Text;
                first = double.Parse(result.Text);
                result.Text += " " + lastOper + " ";
                isOper = true;
                isEqual = false;
                isDot = false;
            }
            
        }
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch (e.KeyChar)
            {
                case '1': 
                    one.PerformClick(); 
                    break;
                case '2':
                    two.PerformClick();
                    break;
                case '3':
                    three.PerformClick();
                    break;
                case '4':
                    four.PerformClick();
                    break;
                case '5':
                    five.PerformClick();
                    break;
                case '6':
                    six.PerformClick();
                    break;
                case '7':
                    seven.PerformClick();
                    break;
                case '8':
                    eight.PerformClick();
                    break;
                case '9':
                    nine.PerformClick();
                    break;
                case '0':
                    zero.PerformClick();
                    break;
                case ',':
                    dot.PerformClick();
                    break;
                case '.':
                    dot.PerformClick();
                    break;
                case '*':
                    multiply.PerformClick();
                    break;
                case '/':
                    divide.PerformClick();
                    break;
                case '-':
                    minus.PerformClick();
                    break;
                case '+':
                    plus.PerformClick();
                    break;
                case '=':
                    equally.PerformClick();
                    break;
                case (char)Keys.Back:
                    ce.PerformClick();
                    break;
                case (char)Keys.Enter:
                    equally.PerformClick();
                    break;
                default:
                    break;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

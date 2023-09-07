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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            zero.Click += addZero;
            one.Click += addOne;
            two.Click += addTwo;
            three.Click += addThree;
            four.Click += addFour;
            five.Click += addFive;
            six.Click += addSix;
            seven.Click += addSeven;
            eight.Click += addEight;
            nine.Click += addNine;
            delete.Click += deleteText;
            addFloat.Click += addFloatToNumber;

            answer.KeyPress += answer_KeyPress;
        }

        public void dividerCheck()
        {
            if(!answer.Text.Contains('.'))
            {
                if(answer.Text.Length == 3 || answer.Text.Length == 7 
                    || answer.Text.Length == 11 || answer.Text.Length == 13)
                {
                    answer.Text += ' ';
                }
            }
        }

        // Добавление цифр
        private void addFloatToNumber(object sender, EventArgs e)
        {
            if (answer.Text.Length >= 14)
                return;
            if (!answer.Text.Contains('.'))
                if (answer.Text == "")
                    answer.Text += "0.";
                else
                    answer.Text += '.';
        }
        private void addZero(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text != "0")
                answer.Text += '0';
        }
        private void addOne(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "1";
            else
                answer.Text += '1';
        }
        private void addTwo(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "2";
            else
                answer.Text += '2';
        }
        private void addThree(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "3";
            else
                answer.Text += '3';
        }
        private void addFour(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "4";
            else
                answer.Text += '4';
        }
        private void addFive(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "5";
            else
                answer.Text += '5';
        }
        private void addSix(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "6";
            else
                answer.Text += '6';
        }
        private void addSeven(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "7";
            else
                answer.Text += '7';
        }
        private void addEight(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "8";
            else
                answer.Text += '8';
        }
        private void addNine(object sender, EventArgs e)
        {
            dividerCheck();
            if (answer.Text.Length >= 14)
                return;
            if (answer.Text == "0")
                answer.Text = "9";
            else
                answer.Text += '9';
        }

        // Работа с полем ввода
        private void answer_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if(answer.Text == "0")
            {
                answer.Text = "";
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void deleteText(object sender, EventArgs e)
        {
            answer.Text = "0";
        }

    }
}

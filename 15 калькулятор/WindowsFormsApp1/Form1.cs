using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        decimal num1 = 0;
        decimal num2 = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                AddDecimal();
            }
            else
            {
                if (resultBox.Text == "0")
                {
                    resultBox.Text = button.Text;
                }
                else
                {
                    resultBox.Text += button.Text;
                }
            }
        }
        private void AddDecimal()
        {
            if (resultBox.Text.Contains(","))
            {
                return;
            }
            if (resultBox.Text == "")
            {
                resultBox.Text = "0,";
            }
            else
            {
                resultBox.Text += ",";
            }
        }
        private void operationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            decimal.TryParse(resultBox.Text, out num1);
            resultBox.Text = "";
        }
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            decimal.TryParse(resultBox.Text, out num2);
            decimal result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя");
                        return;
                    }   
                    result = num1 / num2;
                    break;    
            }
            if (result % 1 == 0) 
            {
                resultBox.Text = result.ToString("F0"); 
            }
            else
            {
                resultBox.Text = result.ToString("F2"); 
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            num1 = 0;
            num2 = 0;
            operation = "";
        }
        private void changeSignButton_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.StartsWith("-"))
            {
                resultBox.Text = resultBox.Text.Substring(1);
            }
            else
            {
                resultBox.Text = "-" + resultBox.Text;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1);
            }
        }
    }
}







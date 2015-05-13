using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Calculator aCalculator=new Calculator();
        private void addButton_Click(object sender, EventArgs e)
        {
            
            aCalculator.firstNumber = Convert.ToDouble(firstTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(aCalculator.GetSum());

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(aCalculator.GetSub());

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(aCalculator.GetMul());

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            aCalculator.firstNumber = Convert.ToDouble(firstTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondTextBox.Text);
            resultTextBox.Text = Convert.ToString(aCalculator.GetDiv());

        }
    }
}

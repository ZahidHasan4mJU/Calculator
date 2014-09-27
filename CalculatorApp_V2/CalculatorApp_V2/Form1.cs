using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp_V2
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private Calculator calculator;

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Add().ToString();
        }

        private void IniatilizeFirstNoSecondNo()
        {
            calculator.firstNumber = Convert.ToDouble(firstNameTextBox.Text);
            calculator.secondNumber = Convert.ToDouble(secondNameTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Subtract().ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Divide().ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Multiply().ToString();
        }
    }
}

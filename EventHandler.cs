using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Form1 : Form
    {
        private double num1, num2;

        private bool IsDigital(string num_str)
        {
            bool isDigit = double.TryParse(num_str, out double num);
            return isDigit;
        }

        private double TextBoxCheckout(TextBox textBox)
        {
            double num;

            if (double.TryParse(textBox.Text, out num))
            {
                return num;
            }
            else
            {
                textBox.Text = "1";
                return 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = TextBoxCheckout(textBox1);
            UpdateResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = TextBoxCheckout(textBox2);
            UpdateResult();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "Answer";

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                

                num1 = TextBoxCheckout(textBox1);
                num2 = TextBoxCheckout(textBox2);

                double result = 0;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        result = num1 + num2;
                        break;

                    case 1:
                        result = num1 - num2;
                        break;

                    case 2:
                        result = num1 * num2;
                        break;

                    case 3:
                        result = num1 / num2;
                        break;

                    case 4:
                        result = Convert.ToInt32(Math.Pow(num1, num2));
                        break;

                    case 5:
                        result = num1 % num2;
                        break;
                }

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Answer";
                MessageBox.Show("Input error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateResult()
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                double num1, num2;

                num1 = TextBoxCheckout(textBox1);
                num2 = TextBoxCheckout(textBox2);

                double result = 0;

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        result = num1 + num2;
                        break;

                    case 1:
                        result = num1 - num2;
                        break;

                    case 2:
                        result = num1 * num2;
                        break;

                    case 3:
                        result = num1 / num2;
                        break;

                    case 4:
                        result = Convert.ToInt32(Math.Pow(num1, num2));
                        break;

                    case 5:
                        result = num1 % num2;
                        break;
                }

                label2.Text = result.ToString();
            }
            else
            {
                label2.Text = "Answer";
            }
        }
    }
}


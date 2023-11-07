using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class Form2 : Form
    {
        private GasStation gas_station = new GasStation();

        private double gasPrice = 0;
        private double genPrice = 0;
        private double foodPrice = 0;

        private double burgerPrice = 0;
        private double sandwichPrice = 0;
        private double kebabPrice = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void as95_CheckedChanged(object sender, EventArgs e)
        {
            if (as95.Checked)
            {
                NumericAs95.Increment = 1;

                NumericAs94.Value = 0;
                NumericEuro.Value = 0;

                NumericAs94.Increment = 0;
                NumericEuro.Increment = 0;
            }
        }

        private void as94_CheckedChanged(object sender, EventArgs e)
        {
            if (as94.Checked)
            {
                NumericAs94.Increment = 1;

                NumericAs95.Value = 0;
                NumericEuro.Value = 0;

                NumericAs95.Increment = 0;
                NumericEuro.Increment = 0;
            }
        }

        private void euro95_CheckedChanged(object sender, EventArgs e)
        {
            if (euro95.Checked)
            {
                NumericEuro.Increment = 1;

                NumericAs95.Value = 0;
                NumericAs94.Value = 0;

                NumericAs95.Increment = 0;
                NumericAs94.Increment = 0;
            }
        }

        private void NumericAs95_ValueChanged(object sender, EventArgs e)
        {
            gasPrice = gas_station.CountGas(1, (double)NumericAs95.Value);
            fuelPrice.Text = gasPrice.ToString();

            genPrice = Math.Round(double.Parse(cafePrice.Text) + double.Parse(fuelPrice.Text), 2);
            GeneralTextBox.Text = genPrice.ToString();
        }

        private void NumericAs94_ValueChanged(object sender, EventArgs e)
        {
            gasPrice = gas_station.CountGas(2, (double)NumericAs94.Value);
            fuelPrice.Text = gasPrice.ToString();

            genPrice = Math.Round(double.Parse(cafePrice.Text) + double.Parse(fuelPrice.Text), 2);
            GeneralTextBox.Text = genPrice.ToString();
        }

        private void NumericEuro_ValueChanged(object sender, EventArgs e)
        {
            gasPrice = gas_station.CountGas(3, (double)NumericEuro.Value);
            fuelPrice.Text = gasPrice.ToString();

            genPrice = Math.Round(double.Parse(cafePrice.Text) + double.Parse(fuelPrice.Text), 2);
            GeneralTextBox.Text = genPrice.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            as95.Checked = true;

            fuelPrice.Text = gasPrice.ToString();
            cafePrice.Text = foodPrice.ToString();

            genPrice = gasPrice + foodPrice;
            GeneralTextBox.Text = genPrice.ToString();
        }

        private void CheckBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxBurger.Checked)
            {
                burger.Increment = 1;
            }
            else
            {
                burger.Value = 0;
                burger.Increment = 0;
            }
        }

        private void CheckBoxSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSandwich.Checked)
            {
                sandwich.Increment = 1;
            }
            else
            {
                sandwich.Value = 0;
                sandwich.Increment = 0;
            }
        }

        private void CheckBoxKebab_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxKebab.Checked)
            {
                kebab.Increment = 1;
            }
            else
            {
                kebab.Value = 0;
                kebab.Increment = 0;
            }
        }

        private void burger_ValueChanged(object sender, EventArgs e)
        {
            burgerPrice = gas_station.CountBurgerPrice((double)burger.Value);
            foodPrice = burgerPrice + sandwichPrice + kebabPrice;

            cafePrice.Text = foodPrice.ToString();

            genPrice = Math.Round(double.Parse(cafePrice.Text) + double.Parse(fuelPrice.Text), 2);
            GeneralTextBox.Text = genPrice.ToString();
        }

        private void sandwich_ValueChanged(object sender, EventArgs e)
        {
            sandwichPrice = gas_station.CountSandwichPrice((double)sandwich.Value);
            foodPrice = burgerPrice + sandwichPrice + kebabPrice;

            cafePrice.Text = foodPrice.ToString();

            genPrice = Math.Round(double.Parse(cafePrice.Text) + double.Parse(fuelPrice.Text), 2);
            GeneralTextBox.Text = genPrice.ToString();
        }

        private void kebab_ValueChanged(object sender, EventArgs e)
        {
            kebabPrice = gas_station.CountKebabPrice((double)kebab.Value);
            foodPrice = burgerPrice + sandwichPrice + kebabPrice;

            cafePrice.Text = foodPrice.ToString();

            genPrice = Math.Round(double.Parse(cafePrice.Text) + double.Parse(fuelPrice.Text), 2);
            GeneralTextBox.Text = genPrice.ToString();
        }
    }
}

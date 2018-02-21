using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class FrmMain : Form
    {
        //proof of change
        public FrmMain()
        {
            InitializeComponent();
        }

        //Constants
        const int weeksPerYear = 52;

        //Tax bracket 1 (lowest) figures
        const int taxBracket1Min = 0;
        const int taxBracket1Max = 9325;
        const double taxBracket1Rate = .10;

        //Tax bracket 2 figures
        const int taxBracket2Max = 37950;
        const double taxBracket2Rate = .15;

        //Tax bracket 3 figures
        const int taxBracket3Max = 91900;
        const double taxBracket3Rate = .25;

        //Tax bracket 4 figures
        const int taxBracket4Max = 191650;
        const double taxBracket4Rate = .28;

        //Tax bracket 5 figures
        const int taxBracket5Max = 416700;
        const double taxBracket5Rate = .33;

        //Tax bracket 6 figures
        const int taxBracket6Max = 418400;
        const double taxBracket6Rate = .35;

        //Tax bracket 7 (highest) figures
        const double taxBracket7Rate = .396;

        //Users inputs
        double userHourlyInput;
        double hoursPerWeek;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                userHourlyInput = Convert.ToDouble(txtUserHourlyRate.Text);
                hoursPerWeek = Convert.ToDouble(txtUserHoursPerWeekInput.Text);

                double result = userHourlyInput * hoursPerWeek * weeksPerYear;

                txtResultYearlySalary.Text = result.ToString("C");

                //Tax bracket calculators
                //Bracket 1
                if (result >= taxBracket1Min && result <= taxBracket1Max)
                {
                    double Taxes = result * taxBracket1Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket1Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
                //Bracket 2
                else if (result > taxBracket1Max && result <= taxBracket2Max)
                {
                    double Taxes = result * taxBracket2Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket2Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
                //Bracket 3
                else if (result > taxBracket2Max && result <= taxBracket3Max)
                {
                    double Taxes = result * taxBracket3Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket3Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
                //Bracket 4
                else if (result > taxBracket3Max && result <= taxBracket4Max)
                {
                    double Taxes = result * taxBracket4Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket4Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
                //Bracket 5
                else if (result > taxBracket4Max && result <= taxBracket5Max)
                {
                    double Taxes = result * taxBracket5Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket5Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
                //Bracket 6
                else if (result > taxBracket5Max && result <= taxBracket6Max)
                {
                    double Taxes = result * taxBracket6Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket6Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
                //Bracket 7
                else
                {
                    double Taxes = result * taxBracket7Rate;
                    txtResultTax.Text = Taxes.ToString("C");
                    txtResultTaxRate.Text = (taxBracket7Rate * 100).ToString() + "%";
                    Taxes -= result;
                    txtResultAfterTaxes.Text = Taxes.ToString("C");
                }
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtUserHourlyRate.Text))
                {
                    MessageBox.Show("The \"Hourly Rate\" textbox is empty! Please enter a valid whole/decimal number.");
                }
                else if (string.IsNullOrEmpty(txtUserHoursPerWeekInput.Text))
                {
                    MessageBox.Show("The \"Hours Per Week\" textbox is empty! Please enter a valid whole/decimal number.");
                }
                else
                {
                    MessageBox.Show("Please make sure only whole/decimal numbers are entered.\nYou may have too many decimals.");
                }
            }
        }

        //Ensures only numbers are entered in the textbox.
        //Does not prevent multiple decimals e.g., "1..01"
        private void txtHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Ensures only numbers are entered in the textbox.
        //Does not prevent multiple decimals e.g., "1..01"
        private void txtUserHoursPerWeekInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

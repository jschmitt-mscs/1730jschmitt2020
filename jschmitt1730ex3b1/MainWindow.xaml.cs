using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jschmitt1730ex3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal subtotal = Convert.ToDecimal(inputTextBox0a.Text);
                resultTextBox0.Text = Ex3bCalculations.GetDiscountPercent(subtotal).ToString("f3");

            } catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text);
                resultTextBox0.Text = "";
            }

            try
            {
                decimal subtotal = Convert.ToDecimal(inputTextBox1a.Text);
                decimal discountPercent = 0m;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");

            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox1a.Text);
                resultTextBox1.Text = "";
            }

            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(inputTextBox3b.Text);
                decimal monthlyInterestRate = Convert.ToDecimal(inputTextBox3c.Text);
                decimal futureValue = 0m;
                int months = Convert.ToInt32(inputTextBox3a.Text);

                Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);

                resultTextBox3.Text = futureValue.ToString("c2");
            } catch {

                MessageBox.Show("Invalid input: \n" 
                    + this.inputTextBox3a.Text + "\n"
                    + this.inputTextBox3b.Text + "\n"
                    + this.inputTextBox3c.Text + "\n"
                    );

                resultTextBox3.Text = "";
            }

            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(inputTextBox2b.Text);
                decimal monthlyInterestRate = Convert.ToDecimal(inputTextBox2c.Text);
                int months = Convert.ToInt32(inputTextBox2a.Text);

                resultTextBox2.Text = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months).ToString("c2");
            }
            catch
            {

                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox2a.Text + "\n"
                    + this.inputTextBox2b.Text + "\n"
                    + this.inputTextBox2c.Text + "\n"
                    );

                resultTextBox2.Text = "";
            }

            try
            {
                double fa = Double.Parse(inputTextBox4a.Text);
                resultTextBox4.Text = Ex3bCalculations.FahrenheitToCelsius(fa).ToString("f1");

            } catch {
                MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text);
                resultTextBox4.Text = "";
            }

            try
            {
                double ce = Double.Parse(inputTextBox5a.Text);
                double fahr = 0;
                Ex3bCalculations.CelsiusToFahrenheit(ce, out fahr);
                resultTextBox5.Text = fahr.ToString("f1");

            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox5a.Text);
                resultTextBox5.Text = "";
            }

            try
            {
                decimal hours = Decimal.Parse(inputTextBox6a.Text);
                decimal pay = Decimal.Parse(inputTextBox6b.Text);
                resultTextBox6.Text = Ex3bCalculations.GrossPay(hours, pay).ToString("c2");
            } catch
            {
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text + "\n"
                );

                resultTextBox6.Text = "";
            }

            try
            {
                string strHours = inputTextBox7a.Text;
                resultTextBox7.Text = Ex3bCalculations.TotalHours(strHours).ToString("0.00");
            } catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox7a.Text);
            }

            try
            {
                resultTextBox8.Text = Ex3bCalculations.GrossPay(inputTextBox8a.Text, Convert.ToDecimal(inputTextBox8b.Text)).ToString("c2");

            } catch
            {
                MessageBox.Show("Invalid input: \n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text + "\n"
                );
            }
        }
    }
}

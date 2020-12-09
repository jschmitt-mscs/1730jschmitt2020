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

namespace jschmitt1730ex3c
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
                int dayIndex = Int32.Parse(inputTextBox0a.Text);
                resultTextBox0.Text = Ex3cCalculations.Calc0(dayIndex);
            } catch { }




            try
            {
                string day = inputTextBox1a.Text;
                resultTextBox1.Text = Ex3cCalculations.Calc1(day);
            } catch
            {

            }



            int[] numbers2 = { 11, 22, 23, 34, 10 };
            resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();




            double[] numbers3 = { 11.1, 22.2, 23.3, 24.4, 9.0 };
            try
            {
                int index = Int32.Parse(inputTextBox3a.Text);
                resultTextBox3.Text = Ex3cCalculations.Calc3(numbers3, index).ToString();

            } catch { }


            double[] numbers4 = new double[inputListBox4a.Items.Count];

            for(int i = 0; i < inputListBox4a.Items.Count; i++)
            {
                numbers4[i] = Double.Parse(inputListBox4a.Items.GetItemAt(i).ToString());
            }

            resultTextBox4.Text = Ex3cCalculations.Calc3(numbers4, numbers4.Length).ToString();



            double[] numbers5 = new double[inputListBox5a.Items.Count];

            for (int i = 0; i < inputListBox5a.Items.Count; i++)
            {
                numbers5[i] = Double.Parse(inputListBox5a.Items.GetItemAt(i).ToString());
            }

            resultTextBox5.Text = Ex3cCalculations.Calc5(numbers5).ToString();



            double[] numbers6 = new double[inputListBox5a.Items.Count];

            for (int i = 0; i < inputListBox6a.Items.Count; i++)
            {
                numbers6[i] = Double.Parse(inputListBox6a.Items.GetItemAt(i).ToString());
            }

            double[] aboveAvg = Ex3cCalculations.Calc6(numbers6);

            foreach(double num in aboveAvg)
            {
                resultListBox6.Items.Add(num.ToString("0.0"));
            }
        }

        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double input = Double.Parse(inputTextBox4a.Text);
                inputListBox4a.Items.Add(input.ToString("n1"));
                inputListBox4a.ScrollIntoView(inputListBox4a.Items[inputListBox4a.Items.Count - 1]);

            } catch 
            { 
                MessageBox.Show("Invalid Input: " + inputTextBox4a.Text);
                inputTextBox4a.Focus();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");
        }

        private void inputTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}

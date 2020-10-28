using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex2f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //#1
            result1TextBox.Text = Ex2fCalculations.Calc01(input1ATextBox.Text);

            //#2
            result2TextBox.Text = Ex2fCalculations.Calc02(input2ATextBox.Text);

            //#3
            result3TextBox.Text = Ex2fCalculations.Calc03(input3ATextBox.Text);

            //#4
            result4TextBox.Text = Ex2fCalculations.Calc01(input4ATextBox.Text);

            //#5 better range test
            result5TextBox.Text = Ex2fCalculations.Calc01(input5ATextBox.Text);

            //#6
            result6TextBox.Text = Ex2fCalculations.Calc06(input6ATextBox.Text, input6BTextBox.Text);

            //7
            result7TextBox.Text = Ex2fCalculations.Calc07(input7ATextBox.Text);

            //8
            result8TextBox.Text = Ex2fCalculations.Calc08(input8ATextBox.Text, input8BTextBox.Text);

            //9
            result9TextBox.Text = Ex2fCalculations.Calc09(input9ATextBox.Text, input9BTextBox.Text);

            //10
            result10TextBox.Text = Ex2fCalculations.Calc10(input10ATextBox.Text, input10BTextBox.Text);
        }
    }
}

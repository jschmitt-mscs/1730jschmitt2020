using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex2g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //switch with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1ATextBox.Text);

            //if statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1ATextBox.Text);

            //else if statements
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1ATextBox.Text);

            //nested if statements
            resultNestedIf01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1ATextBox.Text);

            //switch with default
            resultSwitchWDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1ATextBox.Text);


            //section 02
            //if statements
            resultIf02TextBox.Text = Ex2gCalculations.IfDefault01(input1ATextBox.Text);

            //else if
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1ATextBox.Text);

            //nested if
            resultNestedIf02TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1ATextBox.Text);

            //section03
            //switch 02
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input02TextBox.Text);

            //if 02
            resultIf03TextBox.Text = Ex2gCalculations.If02(input02TextBox.Text);

            //else if 02
            resultElseIf03TextBox.Text = Ex2gCalculations.ElseIf02(input02TextBox.Text);

            //nested if else
            resultNestedIfElse03TextBox.Text = Ex2gCalculations.NestedIfElse02(input02TextBox.Text);



        }

    }
}

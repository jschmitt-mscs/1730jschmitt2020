using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt17302d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetPassValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "Johnson";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
        }

        private void btnSetFailValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Bob";
            textBox2Input.Text = "text";
            textBox3Input.Text = "2.5";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "6";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "4";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "250";
            textBox10InputA.Text = "5";
            textBox10InputB.Text = "3";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";

            if (textBox1Input.Text == "Frank")
            {
                textBox1ResultA.Text = "Success";
            };

            if (textBox2Input.Text == "")
            {
                textBox2ResultA.Text = "Success";
            };

            if (Convert.ToDecimal(textBox3Input.Text) == 2.3m)
            {
                textBox3ResultA.Text = "Success";
            };

            if (Convert.ToBoolean(textBox4Input.Text) == false)
            {
                textBox4ResultA.Text = "Success";
            };

            if (textBox5InputA.Text == textBox5InputB.Text)
            {
                textBox5ResultA.Text = "Success";
            };

            if (textBox6Input.Text != "Jones")
            {
                textBox6ResultA.Text = "Success";
            };

            if (Convert.ToInt32(textBox7Input.Text) > 0)
            {
                textBox7ResultA.Text = "Success";
            };

            if (Convert.ToInt32(textBox8InputA.Text) < Convert.ToInt32(textBox8InputB.Text))
            {
                textBox8ResultA.Text = "Success";
            };

            if (Convert.ToInt32(textBox9Input.Text) >= 500)
            {
                textBox9ResultA.Text = "Success";
            };

            if (Convert.ToInt32(textBox10InputA.Text) <= Convert.ToInt32(textBox10InputB.Text))
            {
                textBox10ResultA.Text = "Success";
            }



            if (textBox1Input.Text != "Frank")
            {
                textBox1ResultB.Text = "Fail";
            };

            if (textBox2Input.Text != "")
            {
                textBox2ResultB.Text = "Fail";
            };

            if (Convert.ToDecimal(textBox3Input.Text) != 2.3m)
            {
                textBox3ResultB.Text = "Fail";
            };

            if (Convert.ToBoolean(textBox4Input.Text) != false)
            {
                textBox4ResultB.Text = "Fail";
            };

            if (textBox5InputA.Text != textBox5InputB.Text)
            {
                textBox5ResultB.Text = "Fail";
            };

            if (textBox6Input.Text == "Jones")
            {
                textBox6ResultB.Text = "Fail";
            };

            if (Convert.ToInt32(textBox7Input.Text) == 0)
            {
                textBox7ResultB.Text = "Fail";
            };

            if (Convert.ToInt32(textBox8InputA.Text) > Convert.ToInt32(textBox8InputB.Text))
            {
                textBox8ResultB.Text = "Fail";
            };

            if (Convert.ToInt32(textBox9Input.Text) < 500)
            {
                textBox9ResultB.Text = "Fail";
            };

            if (Convert.ToInt32(textBox10InputA.Text) > Convert.ToInt32(textBox10InputB.Text))
            {
                textBox10ResultB.Text = "Fail";
            }




        }
    }
}

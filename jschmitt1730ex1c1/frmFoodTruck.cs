using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotdogSubtotal.Text = (
                Convert.ToDecimal(txtHotDogs.Text) * 4.0m
                ).ToString("0.00");

            txtHamburgerSubtotal.Text = (
                Convert.ToDecimal(txtHamburgers.Text) * 6.0m
                ).ToString("0.00");

            txtFriesSubtotal.Text = (
                Convert.ToDecimal(txtFries.Text) * 3.0m
                ).ToString("0.00");

            txtPreTaxTotal.Text = (
                Convert.ToDecimal(txtHotdogSubtotal.Text) +
                Convert.ToDecimal(txtHamburgerSubtotal.Text) +
                Convert.ToDecimal(txtFriesSubtotal.Text)
                ).ToString("0.00");

            txtTax.Text = (
                Convert.ToDecimal(txtPreTaxTotal.Text) * 0.06875m
                ).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtTax.Text) +
                Convert.ToDecimal(txtPreTaxTotal.Text)
                ).ToString("0.00");

            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtFries.Text = "0";

            txtHamburgerSubtotal.Text = "";
            txtHotdogSubtotal.Text = "";
            txtFriesSubtotal.Text = "";

            txtPreTaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }
    }
}

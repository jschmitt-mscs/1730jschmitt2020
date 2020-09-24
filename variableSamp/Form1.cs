using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variableSamp
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotdogSubtotal.Text = (
            //    Convert.ToDecimal(txtHotDogs.Text) * 4.0m
            //    ).ToString("0.00");

            int hotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal hotDogPrice = 4.00m;
            decimal hotDogSubtotal = hotDogPrice * hotDogs;
            txtHotdogSubtotal.Text = hotDogSubtotal.ToString("0.00");

            //txtHamburgerSubtotal.Text = (
            //    Convert.ToDecimal(txtHamburgers.Text) * 6.0m
            //    ).ToString("0.00");

            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 6.00m;
            decimal hamburgerSubtotal = hamburgerPrice * hamburgers;
            txtHamburgerSubtotal.Text = hamburgerSubtotal.ToString("0.00");


            //txtFriesSubtotal.Text = (
            //    Convert.ToDecimal(txtFries.Text) * 3.0m
            //    ).ToString("0.00");


            int fries = Convert.ToInt32(txtFries.Text);
            decimal fryPrice = 3.00m;
            decimal frySubtotal = fryPrice * fries;
            txtFriesSubtotal.Text = frySubtotal.ToString("0.00");


            //txtPreTaxTotal.Text = (
            //    Convert.ToDecimal(txtHotdogSubtotal.Text) +
            //    Convert.ToDecimal(txtHamburgerSubtotal.Text) +
            //    Convert.ToDecimal(txtFriesSubtotal.Text)
            //    ).ToString("0.00");

            decimal preTaxTotal = hotDogSubtotal + hamburgerSubtotal + frySubtotal;
            txtPreTaxTotal.Text = preTaxTotal.ToString("0.00");

            txtTax.Text = (
                Convert.ToDecimal(txtPreTaxTotal.Text) * 0.06875m
                ).ToString("0.00");

            decimal tax = preTaxTotal * 0.06875m;
            txtTax.Text = tax.ToString("0.00");

            //txtTotal.Text = (
            //    Convert.ToDecimal(txtTax.Text) +
            //    Convert.ToDecimal(txtPreTaxTotal.Text)
            //    ).ToString("0.00");

            decimal total = tax + preTaxTotal;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

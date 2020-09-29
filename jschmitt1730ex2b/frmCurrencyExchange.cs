using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex2b
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountCAD.Text = "0.00";
            txtAmountGBP.Text = "0.00";
            txtAmountICK.Text = "0.00";
            txtAmountSAR.Text = "0.00";

            txtRateCAD.Text = "0.76";
            txtRateGBP.Text = "1.33";
            txtRateICK.Text = "0.0072";
            txtRateSAR.Text = "0.06";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountCAD = Convert.ToDecimal(txtAmountCAD.Text);
            decimal amountGBP = Convert.ToDecimal(txtAmountGBP.Text);
            decimal amountICK = Convert.ToDecimal(txtAmountICK.Text);
            decimal amountSAR = Convert.ToDecimal(txtAmountSAR.Text);

            decimal rateCAD = Convert.ToDecimal(txtRateCAD.Text);
            decimal rateGBP = Convert.ToDecimal(txtRateGBP.Text);
            decimal rateICK = Convert.ToDecimal(txtRateICK.Text);
            decimal rateSAR = Convert.ToDecimal(txtRateSAR.Text);

            decimal usdCAD = amountCAD * rateCAD;
            decimal usdGBP = amountGBP * rateGBP;
            decimal usdICK = amountICK * rateICK;
            decimal usdSAR = amountSAR * rateSAR;

            txtUSDCAD.Text = usdCAD.ToString("0.00");
            txtUSDGBP.Text = usdGBP.ToString("0.00");
            txtUSDICK.Text = usdICK.ToString("0.00");
            txtUSDSAR.Text = usdSAR.ToString("0.00");

            txtTotalUSD.Text = (usdCAD + usdGBP + usdICK + usdSAR).ToString("0.00");



        }
    }
}

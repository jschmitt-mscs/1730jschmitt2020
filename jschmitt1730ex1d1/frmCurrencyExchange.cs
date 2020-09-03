using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex1d1
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void cadTextChanged(object sender, EventArgs e)
        {
            txtUSDCAD.Text = (Convert.ToDecimal(txtAmountCAD.Text) *
                Convert.ToDecimal(txtRateCAD.Text)).ToString("0.00");
        }

        private void ickTextChanged(object sender, EventArgs e)
        {
            txtUSDICK.Text = (Convert.ToDecimal(txtAmountICK.Text) *
                Convert.ToDecimal(txtRateICK.Text)).ToString("0.00");
        }

        private void gbpTextChanged(object sender, EventArgs e)
        {
            txtUSDGBP.Text = (Convert.ToDecimal(txtAmountGBP.Text) *
                Convert.ToDecimal(txtRateGBP.Text)).ToString("0.00");
        }

        private void sarTextChanged(object sender, EventArgs e)
        {
            txtUSDSAR.Text = (Convert.ToDecimal(txtAmountSAR.Text) *
                Convert.ToDecimal(txtRateSAR.Text)).ToString("0.00");
        }

        private void totalTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDCAD.Text) +
                Convert.ToDecimal(txtUSDICK.Text) +
                Convert.ToDecimal(txtUSDGBP.Text) +
                Convert.ToDecimal(txtUSDSAR.Text)).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex1f
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }

        private void frmCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnScotland.BackgroundImage = picScotlandDark.Image;
            btnIceland.BackgroundImage = picIcelandDark.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDark.Image;

            txtCurrency.Focus();

            lblCurrency.Text = btnCanada.Text + ": ";
            groupBox1.Left = 20;

            txtCurrency.ReadOnly = btnReset.TabStop;

            txtExchangeRate.Text = "0.76";
            lblCurrency.Text = txtCurrency.Text + txtExchangeRate.Text;
            groupBox1.Text = Convert.ToInt32("3" + "4").ToString();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnScotland.BackgroundImage = picScotlandDark.Image;
            btnIceland.BackgroundImage = picIcelandDark.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDark.Image;
            txtCurrency.Focus();

            lblCurrency.Text = btnCanada.Text + ": ";

            txtExchangeRate.Text = "0.76";

        }


        private void btnIceland_Click(object sender, EventArgs e)
        {
            btnIceland.BackgroundImage = picIceland.Image;
            btnCanada.BackgroundImage = picCanadaDark.Image;
            btnScotland.BackgroundImage = picScotlandDark.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDark.Image;
            txtCurrency.Focus();

            lblCurrency.Text = btnIceland.Text + ": ";

            txtExchangeRate.Text = "0.0074";


        }

        private void btnScotland_Click(object sender, EventArgs e)
        {
            btnScotland.BackgroundImage = picScotland.Image;
            btnCanada.BackgroundImage = picCanadaDark.Image;
            btnIceland.BackgroundImage = picIcelandDark.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDark.Image;
            txtCurrency.Focus();

            lblCurrency.Text = btnScotland.Text + ": ";

            txtExchangeRate.Text = "1.29";

        }

        private void btnSouthAfrica_Click(object sender, EventArgs e)
        {
            btnSouthAfrica.BackgroundImage = picSouthAfrica.Image;
            btnCanada.BackgroundImage = picCanadaDark.Image;
            btnScotland.BackgroundImage = picScotlandDark.Image;
            btnIceland.BackgroundImage = picIcelandDark.Image;
            txtCurrency.Focus();

            lblCurrency.Text = btnSouthAfrica.Text + ": ";

            txtExchangeRate.Text = "0.061";
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text) *
                Convert.ToDecimal(txtExchangeRate.Text)).ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtTotalUSD.Text) +
                Convert.ToDecimal(txtUSDollars.Text)).ToString("0.00");

            lblSummary.Text = lblSummary.Text + " + " + txtUSDollars.Text;
            txtCurrency.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnScotland.BackgroundImage = picScotlandDark.Image;
            btnIceland.BackgroundImage = picIcelandDark.Image;
            btnSouthAfrica.BackgroundImage = picSouthAfricaDark.Image;

            lblCurrency.Text = btnCanada.Text;
            txtCurrency.Focus();

            txtExchangeRate.Text = "0.76";

            lblSummary.Text = "";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Text = "0.00";
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }
    }
}

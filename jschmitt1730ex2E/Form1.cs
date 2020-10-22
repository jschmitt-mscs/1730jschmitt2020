using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jschmitt1730ex2E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            result04aTextBox.Text = "";
            result04bTextBox.Text = "";
            result05aTextBox.Text = "";
            result05bTextBox.Text = "";
            result06aTextBox.Text = "";
            result06bTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09aTextBox.Text = "";
            result09bTextBox.Text = "";
            result10TextBox.Text = "";

            //01
            decimal subtotal = Convert.ToDecimal(Input01aTextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            //02
            decimal timeInService = Convert.ToDecimal(Input02aTextBox.Text);
            //result02TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            result02TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            //03 - 06 init
            bool isValid = Convert.ToBoolean(Input03aTextBox.Text);
            int years = Convert.ToInt32(Input03cTextBox.Text);

            //03
            int counter = Convert.ToInt32(Input03bTextBox.Text);
            //result03TextBox.Text = (isValid == true && counter++ < years).ToString();
            result03TextBox.Text = LogicalOperations.q03(isValid, years, counter).ToString();
            result03bTextBox.Text = counter.ToString();

            //04 
            counter = Convert.ToInt32(Input03bTextBox.Text);
            //result04aTextBox.Text = (isValid == true & counter++ < years).ToString();
            result04aTextBox.Text = LogicalOperations.q04(isValid, years, counter).ToString();
            result04bTextBox.Text = counter.ToString();

            //05
            counter = Convert.ToInt32(Input03bTextBox.Text);
            //result05aTextBox.Text = (isValid == true || counter++ < years).ToString();
            result05aTextBox.Text = LogicalOperations.q05(isValid,years, counter).ToString();
            result05bTextBox.Text = counter.ToString();

            //06
            counter = Convert.ToInt32(Input03bTextBox.Text);
            //result06aTextBox.Text = (isValid == true | counter++ < years).ToString();
            result06aTextBox.Text = LogicalOperations.q06(isValid, years, counter).ToString();
            result06bTextBox.Text = counter.ToString();

            //07
            DateTime startDate = Convert.ToDateTime(Input07aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(Input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(Input07cTextBox.Text);
            isValid = Convert.ToBoolean(Input07dTextBox.Text);
            //result07TextBox.Text = (
            //    date > startDate && date < expirationDate || isValid == true
            //    ).ToString();

            result07TextBox.Text = (
                    LogicalOperations.q07(startDate, expirationDate, date, isValid)
                ).ToString();

            //08
            int thisYTD = Convert.ToInt32(Input08aTextBox.Text);
            int lastYTD = Convert.ToInt32(Input08bTextBox.Text);
            String empType = Input08cTextBox.Text;
            int startYear = Convert.ToInt32(Input08dTextBox.Text);
            int currentYear = Convert.ToInt32(Input08eTextBox.Text);
            //result08TextBox.Text = (
            //    ((thisYTD > lastYTD) || empType=="Part time") && startYear < currentYear
            //    ).ToString();

            result08TextBox.Text = (
                    LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)
                ).ToString();

            //09
            counter = Convert.ToInt32(Input09aTextBox.Text);
            years = Convert.ToInt32(Input09bTextBox.Text);
            //result09aTextBox.Text = (
            //    !(counter++ >= years)
            //    ).ToString();

            result09aTextBox.Text = (
                    LogicalOperations.q09(counter, years)
                ).ToString();

            result09bTextBox.Text = counter.ToString();

            //10
            int a = Convert.ToInt32(Input10aTextBox.Text);
            int b = Convert.ToInt32(Input10bTextBox.Text);
            int c = Convert.ToInt32(Input10cTextBox.Text);
            int d = Convert.ToInt32(Input10dTextBox.Text);

            //int x = b * c;
            //int y = a + x;
            //int z = y - d;
            //result10TextBox.Text = (
            //    a + b*c -d
            //    ).ToString();
            //result10TextBox.Text = z.ToString();

            //result10TextBox.Text = (
            //        a > b && b < c || c < d
            //    ).ToString();

            bool v = a > b;
            bool w = b < c;
            bool x = c < d;
            bool y = v && w;
            bool z = y || x;
            //result10TextBox.Text = z.ToString();
            result10TextBox.Text = LogicalOperations.q10(a, b, c, d).ToString();

            //11
            bool member = Convert.ToBoolean(Input11aTextBox.Text);
            decimal price = Convert.ToDecimal(Input11bTextBox.Text);
            float weight = Convert.ToSingle(Input11cTextBox.Text);
            result11TextBox.Text = (
                LogicalOperations.q11(member, price, weight)
                ).ToString();

            //12
            member = Convert.ToBoolean(Input12aTextBox.Text);
            price = Convert.ToDecimal(Input12bTextBox.Text);
            weight = Convert.ToSingle(Input12cTextBox.Text);
            result12TextBox.Text = (

                LogicalOperations.q12(member, price, weight)

                ).ToString();

            //13
            String state = Input13aTextBox.Text;
            String category = Input13bTextBox.Text;
            result13TextBox.Text = LogicalOperations.q13(state, category).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jschmitt1730ex2f
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = .2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2 if {block}

            decimal subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";
            decimal discountPercent = 0m;
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;

        }

        public static string Calc03(string input)
        {
            // #3 if else

            decimal subtotal = Decimal.Parse(input);
            decimal discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            //#4 if else if
            decimal subtotal = Decimal.Parse(input);
            decimal discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;

            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            //#5 better if else if
            decimal subtotal = Decimal.Parse(input);
            decimal discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            decimal subtotal = Decimal.Parse(inputA);
            decimal discountPercent = 0m;
            string customerType = inputB;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            //#5 better if else if

            if(input != "")
            {
                return (Decimal.Parse(input) * 200).ToString("n2");
            }

            return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping

            if(inputA != "" && inputB != "")
            {
                decimal quantity = Decimal.Parse(inputB);
                decimal price = Decimal.Parse(inputA);
                decimal subtotal = quantity * price;
                decimal shipping = 0;

                if(subtotal < 50)
                {
                    shipping = 5m;
                }

                return (subtotal + shipping).ToString("n2"); 
            }

            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate

            if (inputA != "" && inputB != "")
            {
                int reading1 = Convert.ToInt32(inputA);
                int reading2 = Convert.ToInt32(inputB);
                int difference = reading2 - reading1;
                decimal rate = 0.10m;
                decimal total = rate * difference;
                if (difference > 0)
                {
                    return total.ToString("n2");
                }
            }

            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0

            if(inputA != "" && inputB != "")
            {
                decimal num1 = Convert.ToDecimal(inputA);
                decimal num2 = Convert.ToDecimal(inputB);

                if(num1 > 0 && num2 > 0)
                {

                    if (num1 > num2)
                    {
                        return (num1 / num2).ToString("n2");
                    } else
                    {
                        return (num2 / num1).ToString("n2");
                    }
                }
            }
            return "Invalid input";
        }
    }
}

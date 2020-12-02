using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jschmitt1730ex3b1
{
    public class Ex3bCalculations
    {
        //1) Get Discount Percent
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if(subtotal >= 500)
            {
                discountPercent = 0.2m;
            } else
            {
                discountPercent = 0.1m;
            }

            return discountPercent;
        }

        //1) Get Discount Percent
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {

            if (subtotal >= 500)
            {
                discountPercent = 0.2m;
            }
            else
            {
                discountPercent = 0.1m;
            }

        }


        //2 Calculate future value
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for(int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        //4) Calculate degrees Celsius
        public static double FahrenheitToCelsius(double fa)
        {
            double celsius = (fa - 32) * 5 / 9;

            return celsius;
        }


        public static void CelsiusToFahrenheit(double ce, out double fahr)
        {
            fahr = 9 * ce / 5 + 32;
        }

        public static decimal GrossPay(decimal hours, decimal pay)
        {
            decimal grossPay = 0.00m;

            if(hours <= 40)
            {
                grossPay = hours * pay;
            } else
            {
                grossPay = ((hours - 40) * pay * 1.5m) + (40 * pay);
            }

            return grossPay;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal totalHours = 0;

            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                totalHours += number;
                startIndex = endIndex + 1;
            }

            return totalHours;
        }

        public static decimal GrossPay(string strNumbers, decimal pay)
        {
            decimal hours = TotalHours(strNumbers);

            return GrossPay(hours, pay);

        }


    }
}

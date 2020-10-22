using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jschmitt1730ex2E
{
    public class LogicalOperations
    {
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }

        public static bool q02(decimal timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;
        }

        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q04(bool isValid, int years, int counter)
        {
            return isValid == true & counter++ < years;
        }

        public static bool q05(bool isValid, int years, int counter)
        {
            return isValid == true || counter++ < years;
        }

        public static bool q06(bool isValid, int years, int counter)
        {
            return isValid == true | counter++ < years;
        }

        public static bool q07(DateTime startDate, DateTime expirationDate, DateTime date, bool isValid)
        {
            return date > startDate && date < expirationDate || isValid == true;
        }

        public static bool q08(int thisYTD, int lastYTD, String empType, int startYear, int currentYear)
        {
            return ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear;
        }

        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }

        public static bool q10(int a, int b, int c, int d)
        {
            bool v = a > b;
            bool w = b < c;
            bool x = c < d;
            bool y = v && w;
            return  y || x;
        }

        public static bool q11(bool member, decimal price, float weight)
        {
            return member || price >= 25 || weight <= 1;
        }

        public static bool q12(bool member, decimal price, float weight)
        {
            return price >= 25 && weight < 1 || member;
        }

        public static bool q13(String state, String category)
        {
            return state == "MN" && !(category == "Clothing" || category == "Food");
        }
    }
}

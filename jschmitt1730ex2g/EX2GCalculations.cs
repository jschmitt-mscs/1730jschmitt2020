﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace jschmitt1730ex2g
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                    discountPercent = 0.1m;
                    break;
                case "C":
                    discountPercent = 0.2m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }

        public static string If01(string customerType)
        {
            decimal discountPercent = -1m;
            if(customerType == "R")
            {
                discountPercent = 0.1m;
            }

            if(customerType == "C")
            {
                discountPercent = 0.2m;
            }

            return discountPercent.ToString("0.0");
        }

        public static string ElseIf01(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }else if (customerType == "C")
            {
                discountPercent = 0.2m;
            }
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElse01(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = 0.2m;
                }
            }
            return discountPercent.ToString("0.0");
        }

        public static string SwitchDefault01(string customerType)
        {
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                    discountPercent = 0.1m;
                    break;
                case "C":
                    discountPercent = 0.2m;
                    break;
                default:
                    discountPercent = 0.0m;
                    break;

            }
            return discountPercent.ToString("0.0");
        }

        public static string IfDefault01(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }

            if (customerType == "C")
            {
                discountPercent = 0.2m;
            }

            if (customerType != "C" && customerType != "R")
            {
                discountPercent = 0.0m;
            }

            return discountPercent.ToString("0.0");
        }

        public static string ElseIfDefault01(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }
            else if (customerType == "C")
            {
                discountPercent = 0.2m;
            }
            else
            {
                discountPercent = 0.0m;
            }
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElseDefault01(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = 0.2m;
                } else
                {
                    if (customerType != "C" && customerType != "R")
                    {
                        discountPercent = 0.0m;
                    }
                }
            } 

            return discountPercent.ToString("0.0");
        }

        public static string Switch02(string customerType)
        {

            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                case "C":
                    discountPercent = 0.2m;
                    break;
                case "T":
                    discountPercent = 0.4m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }

        public static string If02(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = 0.2m;
            }

            if (customerType == "C")
            {
                discountPercent = 0.2m;
            }

            if (customerType == "T")
            {
                discountPercent = 0.4m;
            }

            return discountPercent.ToString("0.0");
        }

        public static string ElseIf02(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R" || customerType == "C")
            {
                discountPercent = 0.2m;
            } else if(customerType == "T")
            {
                discountPercent = 0.4m;
            }
            
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElse02(string customerType)
        {
            decimal discountPercent = -1m;
            if (customerType == "R" || customerType == "C")
            {
                discountPercent = 0.2m;
            }
            else
            {
                if (customerType == "T")
                {
                    discountPercent = 0.4m;
                }
            }
            return discountPercent.ToString("0.0");
        }

    }
}

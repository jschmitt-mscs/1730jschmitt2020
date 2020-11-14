using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace _1730jschmittex2h2
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            //change
            catch
            {

            }

            return result;

        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch
            {

            }
            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);

            result = date.ToShortDateString();
            
            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            TimeSpan timespan;
            try
            {
                timespan = DateTime.Parse(strDateA) - DateTime.Parse(strDateB);
                result = timespan.Days.ToString() + " days";
            }
            catch
            {

            }
            return result;
        }

        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            TimeSpan timespan;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                timespan = dateA - dateB;


                if (dateA > dateB)
                    result = timespan.Days.ToString() + " days past due";
                else 
                    result = "On time";

            }
            catch
            {

            }
            return result;
        }

        public static string StringCalc01(string s)
        {

            //late to crate
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Remove(0, 1);
                result = result.Insert(0, "cr");
            } catch { }


            return result;
        }

        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Remove(1, 1);
                result = result.Insert(1, "rit");
            }
            catch { }


            return result;
        }

        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Substring(2, 4);
                result = result.ToUpper();
            }
            catch { }


            return result;
        }

        public static string StringCalc04(string s)
        {
            string result = "Invalid input";

            try
            {
                s = s.Trim();
                result = s.PadLeft(10, '*');
            }
            catch { }

            return result;
        }

        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Replace("(","");
                result = result.Replace(" ", "");
                result = result.Replace(")", "");
                result = result.Replace("-", "");
            }
            catch { }
            return result;
        }

        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Replace("(", "");
                result = result.Replace(" ", "");
                result = result.Replace(")", "");
                result = result.Replace("-", "");
                if(result.Length > 7)
                {
                    result = result.Insert(3, ".");
                    result = result.Insert(7, ".");
                } else
                    result = result.Insert(3, ".");

            }
            catch { }
            return result;
        }

        public static string StringCalc07(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                s = s.ToLower();

                if (s.Contains("pioneer"))
                {
                    result = "Found";
                }
                else
                    result = "Not found";
            }
            catch { }
            return result;
        }

        public static string StringCalc08(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Substring(s.IndexOf(", "));
                result = result.Substring(2);
            }
            catch { }
            return result;
        }

        public static string StringCalc09(string s)
        {
            string result = "Invalid input";
            try
            {
                s = s.Trim();
                result = s.Substring(s.LastIndexOf(" "));
                result = result.Trim();
            }
            catch { }
            return result;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            string result = "Invalid input";
            try
            {
                StringBuilder r2 = new StringBuilder();
                r2.Append(s1);
                r2.Append(", ");
                r2.Append(s2);
                r2.Append(", ");
                r2.Append(s3);
                result = r2.ToString();
            } catch
            {

            }

            return result;
        }
    }
}
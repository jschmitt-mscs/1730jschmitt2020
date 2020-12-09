using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jschmitt1730ex3c
{
    public class Ex3cCalculations
    {
        public static string Calc0(int day)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if(day > 1 && day < 7)
            {
                return days[day];
            } else if( day == 1)
            {
                return days[0];
            } else if(day == 7)
            {
                return days[6];
            } else 
            {
                return "Invalid index";
            }

        }

        public static string Calc1(string day)
        {
            day = day.Trim();
            string cleanDay = day.ToUpper();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int hourIndex = Array.IndexOf(days, cleanDay);

            if(hourIndex >= 0 && hourIndex <= 6)
            {
                return hours[hourIndex];
            } else
            {
                return "Invalid input";
            }

        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        public static double Calc3(double[] numbers, int num)
        {
            double sum = 0.0;
            if(num <= numbers.Length)
            {
                for (int i = 0; i < num; i++)
                {
                    sum += numbers[i];
                }
            } else
            {
                return 0.0;
            }

            return sum;
        }

        public static double Calc5(double[] numbers)
        {
            double average = 0;
            if(numbers.Length > 0)
            {
                double sum = Calc3(numbers, numbers.Length);
                average = sum / numbers.Length;
            }
            return average;
        }

        public static double[] Calc6(double[] numbers)
        {

            int length = numbers.Length;
            List<double> aboveAvg = new List<double>();
            if(length > 0)
            {
                double avg = Calc5(numbers);

                foreach(double num in numbers)
                {
                    if(num > avg)
                    {
                        aboveAvg.Add(num);
                    }
                }
            }

            return aboveAvg.ToArray();
        }
    }
}

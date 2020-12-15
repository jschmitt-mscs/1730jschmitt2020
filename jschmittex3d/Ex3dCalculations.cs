using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jschmittex3d
{
    public class Ex3dCalculations
    {

        public static string ArrayToString(int[] values)
        {
            // Create StringBuilder object: sbResult
            // loop
            //     convert current value to string, append to sbResult
            //     append ", " to sbResult
            // convert sbResult to string: result
            // remove last ", " from result
            // return result

            StringBuilder sbresult = new StringBuilder();
            for(int i = 0; i < values.Length; i++)
            {
                sbresult.Append(values[i].ToString() + ", ");
            }

            sbresult.Remove(sbresult.Length - 2, 2);
            string result = sbresult.ToString();

            return result;
        }

        public static int ValueCount(int[] values, int searchValue)
        {
            // create counter variable
            // loop
            //     increment counter if current value equals searchValue
            // return counter

            int counter = 0;
            for(int i = 0; i < values.Length; i++)
            {
                if(values[i] == searchValue)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int RangeCount(int[] values, int searchMin, int searchMax)
        {
            // create counter variable
            // loop
            //     increment counter if current value between min and max (inclusive)
            // return counter

            int counter = 0;
            for(int i = 0; i< values.Length; i++)
            {
                if(values[i] <= searchMax && values[i] >= searchMin)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}

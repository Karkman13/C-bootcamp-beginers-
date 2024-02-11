using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public static class ConvertSystem
    {
        public static int? ConverIntoNumber(string number)
        {
            int? res = null;

            try
            {
                res = Int32.Parse(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Value {0} is not a number.", number);
            }

            return res;
        }

        public static List<int> ConvertListNumbers(string numbers, char spliter = ',')
        {
            var splitedNumbers = numbers.Split(spliter);
            var list = new List<int>();
            foreach(var e in splitedNumbers)
            {
                try
                {
                    list.Add(Int32.Parse(e));
                }
                catch
                {
                    Console.WriteLine("'{0}' is not a number", e);
                }
            }
            return list;
        }
        public static string[] ConverStringToArray(string text, char spliter = ',')
        {
            var slitedText = text.Split(spliter);
            return slitedText;
        }
    }
}

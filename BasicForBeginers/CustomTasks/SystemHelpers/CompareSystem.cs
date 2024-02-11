using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks.SystemHelpers
{
    public static class CompareSystem
    {
        public static bool IfConsecutive(List<int> numbers)
        {
            if (numbers.Count < 2)
                return false;
            var signIndecator = IncreasingOrDecreasing(numbers[0], numbers[1]);
            if (signIndecator == null)
                return false;
            for (int i = 0; i < (numbers.Count -1); i++)
                if (IncreasingOrDecreasing(numbers[i], numbers[i + 1]) != signIndecator)
                    return false;
            return true;

        }
        private static bool? IncreasingOrDecreasing(int number1, int number2)
        {
            var res = number1 - number2;
            if (res > 0)
                return true;
            else if (res < 0)
                return false;
            else return null;
        }
        public static List<int> IfDuplicate(List<int> numbers)
        {
            numbers.Sort();
            var res = new List<int>();
            for (int i = 0; i < (numbers.Count - 1); i++)
                if (numbers[i] == numbers[i + 1] && !res.Contains(numbers[i]))
                    res.Add(numbers[i]);
            return res;
        }
    }
}

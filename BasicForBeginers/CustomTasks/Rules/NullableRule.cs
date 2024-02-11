using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks.Rules
{
    public class NullableRule : IRules
    {
        public bool IsRule(int? number)
        {
            if (number == null)
            {
                Console.WriteLine("Number should between 1 to 10");
                return false;
            }
            else
                return true;
        }
    }
}

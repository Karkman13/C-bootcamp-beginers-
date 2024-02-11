using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public class StartConditionalTask1Rule : IRules
    {
        public bool IsRule(int? number)
        {
            if (number <= 10)
                return true;
            else
            {
                Console.WriteLine("Your number is valid");
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public sealed class NaturalRule : IRules
    {
        public bool IsRule(int? numner)
        {
            if (numner > 0)
                return true;
            else
            {
                Console.WriteLine("Your number is valid");
                return false;
            }
        }
    }
}

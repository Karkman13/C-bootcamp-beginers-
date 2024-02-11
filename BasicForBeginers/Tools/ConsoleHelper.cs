using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.Tools
{
    static class ConsoleHelper
    {
        public static string ReadLine(string level)
        {
            Console.Write(level);
            var res = Console.ReadLine();
            return res;
        }
    }
}

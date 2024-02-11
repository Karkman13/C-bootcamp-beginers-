using BasicForBeginers.TaskSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskLauncher = new TaskLauncher();

            taskLauncher.StartLauncher();

            //Console.ReadLine();
        }
    }

    

    
}

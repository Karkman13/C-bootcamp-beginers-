using BasicForBeginers.CustomTasks.SystemHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public static class TextTask
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public static void StartTextTask1()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var answer = Console.ReadLine();
            if (answer == "exite")
                return;
            var listNum = ConvertSystem.ConvertListNumbers(answer, '-');
            var msg = CompareSystem.IfConsecutive(listNum) ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public static void StartTextTask2()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "exit" || answer == "")
                return;
            var listNum = ConvertSystem.ConvertListNumbers(answer, '-');
            var duplacateList = CompareSystem.IfDuplicate(listNum);
            if(duplacateList.Count > 0 )
            {
                Console.Write("Duplicats:");
                foreach (var d in duplacateList)
                    Console.Write(" {0},", d);
                Console.WriteLine();
            }
            else
                Console.WriteLine("Not Duplicate");
        }
        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static void StartTextTask3()
        {
            Console.Write("Enter time: ");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "exit")
                return;
            else if (String.IsNullOrWhiteSpace(answer))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var time = ConvertSystem.ConvertListNumbers(answer, ':');
            if(time.Count == 2)
            {
                if(time[0] >= 0 && time[0] <= 23 && time[1] >= 0 && time[1] <= 59)
                    Console.WriteLine("ok. You time is: {0}:{1}", time[0], time[1]);
                else
                    Console.WriteLine("Invalid Time");
            }
            else
                Console.WriteLine("Invalid Time");
        }
        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>
        public static void StartTextTask4()
        {
            Console.Write("Enter a few words: ");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "exit")
                return;
            else if (String.IsNullOrWhiteSpace(answer))
            {
                Console.WriteLine("Error");
                return;
            }

            var res = "";
            foreach (var word in answer.Split(' '))
                res += char.ToUpper(word[0]) + word.ToLower().Substring(1);
            Console.WriteLine(res);
        }
        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        public static void StartTextTask5()
        {
            Console.Write("Enter a word: ");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "exit")
                return;
            else if (String.IsNullOrWhiteSpace(answer))
            {
                Console.WriteLine("Error");
                return;
            }

            var vowels = new Dictionary<char, int>()
            {
                {'a', 0 },
                {'e', 0 },
                {'o', 0 },
                {'u', 0 },
                {'i', 0 }
            };
            var sum = 0;

            foreach (var letter in answer)
                if (vowels.ContainsKey(letter))
                {
                    vowels[letter]++;
                    sum++;
                }
            var sumstring = "";
            foreach (var key in vowels.Keys)
                sumstring += key + " - " + vowels[key].ToString() + " ";

            Console.WriteLine("Count of vowels: {0}. Total number of vowels: " + sumstring, sum);
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public static class ArraysandListsTask
    {
        /// <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        public static void StartArrayTask1()
        {
            var names = new List<string>();
            do
            {
                Console.WriteLine("Type a name(or hit ENTER to quit): ");
                var answer = Console.ReadLine();

                if (String.IsNullOrEmpty(answer))
                    break;
                names.Add(answer);
            } while (true);

            if (names.Count == 0)
                Console.WriteLine();
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post", names[0]);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
        }
        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        public static void StartArrayTask2()
        {
            Console.WriteLine("Enter you name");
            var answer = Console.ReadLine();

            var array = new char[answer.Length];
            for (int i = 0; i < answer.Length; i++)
                array[i] = answer[i];
            Array.Reverse(array);
            var reversed = new string(array);
            Console.WriteLine("Reversed: {0}", reversed);


        }
        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        public static void StartArrayTask3()
        {
            var isTaskEnd = false;
            var listNumbers = new List<int>();

            Console.WriteLine("Please enter 5 unique numbers");
            do
            {
                Console.WriteLine("{0} numbers left to enter", (5 - listNumbers.Count));
                var answer = Console.ReadLine();
                if (answer.ToLower() == "exit")
                    isTaskEnd = true;
                else if(ConvertSystem.ConverIntoNumber(answer) != null)
                {
                    if (!listNumbers.Contains((int)ConvertSystem.ConverIntoNumber(answer)))
                    {
                        listNumbers.Add((int)ConvertSystem.ConverIntoNumber(answer));
                    }
                }
                if (listNumbers.Count == 5)
                {
                    listNumbers.Sort();
                    Console.Write("Your list is: ");
                    foreach (var number in listNumbers)
                        Console.Write("{0}, ", number);
                    isTaskEnd = true;
                }
            } while (!isTaskEnd);
        }
        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>
        public static void StartArrayTask4()
        {
            var isTaskEnd = false;
            var listNumbers = new List<int>();
            do
            {
                Console.WriteLine("Please enter number or Quit to finish");
                var answer = Console.ReadLine();
                if (answer == "Quit" || answer.ToLower() == "quit" || answer == "exit")
                    isTaskEnd = true;
                else if (ConvertSystem.ConverIntoNumber(answer) != null)
                    listNumbers.Add((int)ConvertSystem.ConverIntoNumber(answer));
            } while (!isTaskEnd);

            var res = new List<int>();
            foreach (var number in listNumbers)
                if (!res.Contains(number))
                    res.Add(number);
            res.Sort();

            Console.Write("Your unique numbers is: ");
            foreach(var number in res)
                Console.Write("{0} ", number);

        }
        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        /// the 3 smallest numbers in the list.
        /// 
        /// </summary>
        public static void StartArrayTask5()
        {
            var isTaskEnd = false;
            var listNumbers = new List<int>();

            do
            {
                Console.Write("Enter a list of comma-separated numbers (at least 5 numbers): ");
                var answer = Console.ReadLine();
                var res = ConvertSystem.ConvertListNumbers(answer);
                if (answer == "exit")
                    isTaskEnd = true;
                else if (res.Count < 5)
                    Console.WriteLine("Invalid list. Please try again");
                else
                {
                    res.Sort();
                    Console.Write("Three smallest numbers in your list: ");
                    for (int i = 0; i < 3; i++)
                        Console.Write("{0} ", res[i]);
                    Console.WriteLine();
                    isTaskEnd = true;
                }
            } while (!isTaskEnd);
        }
    }
}

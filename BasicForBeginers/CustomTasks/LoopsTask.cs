using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public static class LoopsTask
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
        public static void StartLoopsTask1()
        {
            var count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("The numbers between 1 and 100 whis is divisible 3 is: {0}", count);
        }
        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        public static void StartLoopsTask2()
        {
            var sum = 0;
            var isTaskEnd = false;
            do
            {
                Console.WriteLine("Please enter the number");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "ok" || answer.ToLower() == "exit")
                    isTaskEnd = true;
                else
                {
                    var number = ConvertSystem.ConverIntoNumber(answer);
                    if (number != null)
                        sum += (int)number;
                    else
                        continue;
                }
            } while (!isTaskEnd);

            Console.WriteLine("Sum of all numbers is: " + sum);
        }
        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary
        public static void StartLoopsTask3()
        {
            var isTaskEnd = false;
            var factorial = 1;

            do
            {
                Console.WriteLine("Please enter the number");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "exit")
                    isTaskEnd = true;
                else
                {
                    var number = ConvertSystem.ConverIntoNumber(answer);
                    if (number != null)
                    {
                        for (int i = (int)number; i > 0; i--)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine("{0}! = {1}", number, factorial);
                        isTaskEnd = true;
                    }
                    else
                        continue;
                }
            } while (!isTaskEnd);
        }
        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        /// </summary>
        public static void StartLoopsTask4()
        {
            var isTaskEnd = false;
            var attempts = 4;
            var number = new Random().Next(1, 10);
            do
            {
                Console.WriteLine("Guess the secret number (from 1 to 10). You have {0} attempt", attempts);
                var answer = Console.ReadLine();
                if (answer.ToLower() == "exit")
                    isTaskEnd = true;
                else if (ConvertSystem.ConverIntoNumber(answer) == null)
                    continue;
                else if (ConvertSystem.ConverIntoNumber(answer) != number)
                {
                    attempts--;
                    Console.WriteLine("You didn't guess");
                }
                else if (ConvertSystem.ConverIntoNumber(answer) == number)
                {
                    Console.WriteLine("You won");
                    isTaskEnd = true;
                }
                if(attempts == 0)
                {
                    Console.WriteLine("You lose");
                    isTaskEnd = true;
                }

            } while (!isTaskEnd);
        }
        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>
        public static void StartLoopsTask5()
        {
            Console.WriteLine("Please enter you series of numbers separated by comma");

            var answer = Console.ReadLine();
            var list = ConvertSystem.ConvertListNumbers(answer);
            try
            {
                var max = list[0];
                foreach(var l in list)
                {
                    if (l > max)
                        max = l;
                }
                Console.WriteLine("Max is {0}", max);
            }
            catch
            {
                Console.WriteLine("Your list is empty");
            }
        }
    }
}

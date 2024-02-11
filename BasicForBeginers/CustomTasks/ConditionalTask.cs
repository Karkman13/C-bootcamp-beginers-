using BasicForBeginers.CustomTasks.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks.ConditionalTasks
{
    public class ConditionalTask
    {
        public static void StartConditionalTask1Tyy2()
        {
            var isTaskend = false;
            int? number;

            var rules = new List<IRules>();
            rules.Add(new NullableRule());
            rules.Add(new NaturalRule());
            rules.Add(new StartConditionalTask1Rule());

            do
            {
                Console.WriteLine("Please enter the number between 1 to 10");
                var answer = Console.ReadLine();

                if (answer != "exit")
                {
                    number = ConvertSystem.ConverIntoNumber(answer);
                    var isnumbervalid = true;
                    foreach (var rule in rules)
                    {
                        if (!rule.IsRule(number))
                        {
                            isnumbervalid = false;
                            break;
                        }
                    }
                    if (!isnumbervalid)
                        continue;
                    else
                        Console.WriteLine("Your nubmer is: {0}", number);
                }
                else
                    isTaskend = true;

            } while (!isTaskend);
        }
        /// <summary>
        /// 1- Write a program and ask the user to enter a number. 
        /// The number should be between 1 to 10. If the user enters a valid number, 
        /// display "Valid" on the console. Otherwise, display "Invalid". 
        /// (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        /// </summary>
        public static void StartConditionalTask1()
        {
            Console.WriteLine("Please enter the number between 1 to 10");

            var isTaskend = false;
            int? number;

            var rules = new List<IRules>();
            rules.Add(new NaturalRule());
            rules.Add(new StartConditionalTask1Rule());

            do
            {
                var answer = Console.ReadLine();

                if (answer != "exit")
                {
                    number = ConvertSystem.ConverIntoNumber(answer);
                    if(number != null)
                    {
                        if (number >= 1 && number <= 10)
                        {
                            Console.WriteLine("Your number is valid");
                        }
                        else
                            Console.WriteLine("Your number is invalid");
                    }
                    else
                    {
                        Console.WriteLine("Number should between 1 to 10");
                        continue;
                    }
                }
                else
                    isTaskend = true;

            } while (!isTaskend);
        }

        /// <summary>
        /// 2- Write a program which takes two numbers from the console 
        /// and displays the maximum of the two.
        /// </summary>
        public static void StartConditionalTask2()
        {
            Console.WriteLine("Please enter two numbers");

            var isTaskEnd = false;
            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("Enter the {0} number.", (SequenceNumber)numbers.Count);
                var answer = Console.ReadLine();
                if(answer != "exit")
                {
                    var res = ConvertSystem.ConverIntoNumber(answer);

                    if (res != null)
                        numbers.Add((int)res);
                    else
                        continue;

                    if (numbers.Count == 2)
                    {
                        Console.WriteLine("Max vulue is {0}", numbers.Max());
                        numbers.Clear();
                    }                  
                }
                else
                    isTaskEnd = true;
                
            } while (!isTaskEnd);

        }

        /// <summary>
        /// 3- Write a program and ask the user to enter the 
        /// width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public static void StartConditionalTask3()
        {
            Console.WriteLine("Please enter width and height of the image");

            var isTaskEnd = false;
            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("Enter {0} of the image.", (ImageExpansion)numbers.Count);
                var answer = Console.ReadLine();
                if (answer != "exit")
                {
                    var res = ConvertSystem.ConverIntoNumber(answer);

                    if (res != null)
                        numbers.Add((int)res);
                    else
                        continue;

                    if (numbers.Count == 2)
                    {
                        if(numbers.IndexOf(numbers.Max()) == 0)
                        {
                            Console.WriteLine("Image is portrait");
                        }
                        else
                            Console.WriteLine("Image is landscape");
                        numbers.Clear();
                    }
                }
                else
                    isTaskEnd = true;

            } while (!isTaskEnd);

        }

        /// <summary>
        /// 4- Your job is to write a program for a speed camera. 
        /// For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks 
        /// the user to enter the speed limit. Once set, the program asks 
        /// for the speed of a car. If the user enters a value less than 
        /// the speed limit, program should display Ok on the console. 
        /// If the value is above the speed limit, the program should calculate 
        /// the number of demerit points. For every 5km/hr above the speed limit, 
        /// 1 demerit points should be incurred and displayed on the console. 
        /// If the number of demerit points is above 12, the program should display 
        /// License Suspended.
        /// </summary>
        public static void StartConditionalTask4()
        {
            var isTaskEnd = false;
            //int speedLimit = 0;

            do
            {
                Console.WriteLine("Please enter speed limet.");
                var answer = Console.ReadLine();
                if (answer != "exit")
                {
                    var speedLimit = ConvertSystem.ConverIntoNumber(answer);
                    if (speedLimit != null)
                    {
                        var speedScore = 0;
                        do
                        {
                            Console.WriteLine("Please enter speed.");
                            var speedAnswer = Console.ReadLine();
                            if (speedAnswer != "exit")
                            {
                                var speed = ConvertSystem.ConverIntoNumber(speedAnswer);
                                if (speed != null)
                                {
                                    if (speed > speedLimit)
                                    {
                                        speedScore += (int)(speed - speedLimit) / 5;
                                        if (speedScore >= 12)
                                        {
                                            Console.WriteLine("Your License Suspended!");
                                            break;
                                        }
                                    }
                                }
                                else
                                    continue;
                            }
                            else
                                isTaskEnd = true;
                        }
                        while (!isTaskEnd);
                    }
                    else
                        continue;
                }
                else
                    isTaskEnd = true;


            } while (!isTaskEnd);
        }
    }

    public enum SequenceNumber
    {
        First,
        Second
    }
    
    public enum ImageExpansion
    {
        Height,
        Width
    }
}

using BasicForBeginers.CustomTasks;
using BasicForBeginers.CustomTasks.ConditionalTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.TaskSystem
{
    public class TaskLauncher
    {
        public void StartLauncher()
        {
            Console.WriteLine("Hello here is program of test tasks of the course.");

            //DisplayTasksCategory();;

            EnumHelper.DisplayTasksCategory(typeof(Exersises));

            var isExitCommand = false;
            do
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "display":
                        EnumHelper.DisplayTasksCategory(typeof(Exersises));
                        break;
                    case "1":
                        Console.WriteLine("start first category");
                        DisplayFirstCategory();
                        break;
                    case "2":
                        Console.WriteLine("start second category");
                        DisplaySecondCategory();
                        break;
                    case "3":
                        Console.WriteLine("start third category");
                        DisplayThirdCategory();
                        break;
                    case "4":
                        Console.WriteLine("start fourth category");
                        DisplayFourthCategory();
                        break;
                    case "5":
                        Console.WriteLine("start fifth category");
                        DisplayFifthCategory();
                        break;
                    case "exit":
                        isExitCommand = true;
                        break;
                    default:
                        Console.WriteLine("unknown");
                        break;
                }
            } while (!isExitCommand);
        }

        private void DisplayFirstCategory()
        {
            EnumHelper.DisplayTasksCategory(typeof(ConditionalTasks));
            var isExitCommand = false;
            do
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "display":
                        EnumHelper.DisplayTasksCategory(typeof(ConditionalTasks));
                        break;
                    case "1":
                        ConditionalTask.StartConditionalTask1();
                        break;
                    case "2":
                        ConditionalTask.StartConditionalTask2();
                        break;
                    case "3":
                        ConditionalTask.StartConditionalTask3();
                        break;
                    case "4":
                        ConditionalTask.StartConditionalTask4();
                        break;
                    case "exit":
                        isExitCommand = true;
                        break;
                    default:
                        break;
                }
            } while (!isExitCommand);
        }
        private void DisplaySecondCategory()
        {
            EnumHelper.DisplayTasksCategory(typeof(LoopsTasks));
            var isExitCommand = false;
            do
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "display":
                        EnumHelper.DisplayTasksCategory(typeof(LoopsTasks));
                        break;
                    case "1":
                        LoopsTask.StartLoopsTask1();
                        break;
                    case "2":
                        LoopsTask.StartLoopsTask2();
                        break;
                    case "3":
                        LoopsTask.StartLoopsTask3();
                        break;
                    case "4":
                        LoopsTask.StartLoopsTask4();
                        break;
                    case "5":
                        LoopsTask.StartLoopsTask5();
                        break;
                    case "exit":
                        isExitCommand = true;
                        break;
                    default:
                        break;
                }
            } while (!isExitCommand);
        }
        private void DisplayThirdCategory()
        {
            EnumHelper.DisplayTasksCategory(typeof(ArraysandListsTasks));
            var isExitCommand = false;
            do
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "display":
                        EnumHelper.DisplayTasksCategory(typeof(ArraysandListsTasks));
                        break;
                    case "1":
                        ArraysandListsTask.StartArrayTask1();
                        break;
                    case "2":
                        ArraysandListsTask.StartArrayTask2();
                        break;
                    case "3":
                        ArraysandListsTask.StartArrayTask3();
                        break;
                    case "4":
                        ArraysandListsTask.StartArrayTask4();
                        break;
                    case "5":
                        ArraysandListsTask.StartArrayTask5();
                        break;
                    case "exit":
                        isExitCommand = true;
                        break;
                    default:
                        break;
                }
            } while (!isExitCommand);
        }
        private void DisplayFourthCategory()
        {
            EnumHelper.DisplayTasksCategory(typeof(TextTasks));
            var isExitCommand = false;
            do
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "display":
                        EnumHelper.DisplayTasksCategory(typeof(TextTasks));
                        break;
                    case "1":
                        TextTask.StartTextTask1();
                        break;
                    case "2":
                        TextTask.StartTextTask2();
                        break;
                    case "3":
                        TextTask.StartTextTask3();
                        break;
                    case "4":
                        TextTask.StartTextTask4();
                        break;
                    case "5":
                        TextTask.StartTextTask5();
                        break;
                    case "exit":
                        isExitCommand = true;
                        break;
                    default:
                        break;
                }
            } while (!isExitCommand);
        }
        private void DisplayFifthCategory()
        {
            EnumHelper.DisplayTasksCategory(typeof(FilesTasks));
            var isExitCommand = false;
            do
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "display":
                        EnumHelper.DisplayTasksCategory(typeof(FilesTasks));
                        break;
                    case "1":
                        FilesTask.StartFileTask1();
                        break;
                    case "2":
                        FilesTask.StartFileTask2();
                        break;
                    case "3":
                        TextTask.StartTextTask3();
                        break;
                    case "4":
                        TextTask.StartTextTask4();
                        break;
                    case "5":
                        TextTask.StartTextTask5();
                        break;
                    case "exit":
                        isExitCommand = true;
                        break;
                    default:
                        break;
                }
            } while (!isExitCommand);
        }


    }

    public enum Exersises
    {
        [Description("Conditional Statements")]
        ConditionalStatements = 1,
        [Description("Loops")]
        Loops = 2,
        [Description("Arrays and Lists")]
        Arrays = 3,
        [Description("Working with Text")]
        Text = 4,
        [Description("Working with Files")]
        Files = 5
    }

    public enum ConditionalTasks
    {
        [Description("First Task")]
        Task1 = 1,
        [Description("Second Task")]
        Task2 = 2,
        [Description("Third Task")]
        Task3 = 3,
        [Description("Fourth Task")]
        Task4 = 4
    }
    public enum LoopsTasks
    {
        [Description("First Task")]
        Task1 = 1,
        [Description("Second Task")]
        Task2 = 2,
        [Description("Third Task")]
        Task3 = 3,
        [Description("Fourth Task")]
        Task4 = 4,
        [Description("Fifth Task")]
        Task5 = 5
    }
    public enum ArraysandListsTasks
    {
        [Description("First Task")]
        Task1 = 1,
        [Description("Second Task")]
        Task2 = 2,
        [Description("Third Task")]
        Task3 = 3,
        [Description("Fourth Task")]
        Task4 = 4,
        [Description("Fifth Task")]
        Task5 = 5
    }
    public enum TextTasks
    {
        [Description("First Task")]
        Task1 = 1,
        [Description("Second Task")]
        Task2 = 2,
        [Description("Third Task")]
        Task3 = 3,
        [Description("Fourth Task")]
        Task4 = 4,
        [Description("Fifth Task")]
        Task5 = 5
    }
    public enum FilesTasks
    {
        [Description("First Task")]
        Task1 = 1,
        [Description("Second Task")]
        Task2 = 2,
    }
}

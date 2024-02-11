using BasicForBeginers.CustomTasks.SystemHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks
{
    public static class FilesTask
    {
        /// <summary>
        /// Write a program that reads a text file and displays the number of words.
        /// </summary>
        public static void StartFileTask1()
        {
            var symbolToIgnore = ".,\n-";
            var text = FileSystem.ReadFile(symbolToIgnore);
            var textArray = ConvertSystem.ConverStringToArray(text, ' ');
            var counter = 0;
            foreach (var word in textArray)
                if(word.Length > 1)
                    counter++;
            Console.WriteLine("Number words in the texr: {0}", counter);
        }
        /// <summary>
        /// Write a program that reads a text file and displays the longest word in the file.
        /// </summary>
        public static void StartFileTask2()
        {
            var symbolToIgnore = ".,\n-";
            var text = FileSystem.ReadFile(symbolToIgnore);
            var textArray = ConvertSystem.ConverStringToArray(text, ' ');
            var longestWord = 0;
            var index = 0;
            foreach(var word in textArray)
                if(word.Length > longestWord)
                {
                    longestWord = word.Length;
                    index = Array.IndexOf(textArray, word);
                }
            Console.WriteLine("Longest word in text: {0} - {1}", textArray[index], longestWord);
        }
    }
}

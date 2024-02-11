using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BasicForBeginers.CustomTasks.SystemHelpers
{
    public static class FileSystem
    {
        private static string _folderpath = @"FilesForTask";
        private static string _filepath = _folderpath + "\\FileForTask.txt";
        private static void CreateFile()
        {
            if(!Directory.Exists(_folderpath))
                Directory.CreateDirectory(_folderpath);

            if (!File.Exists(_filepath))
            {
                var text = "Write a program that reads a text file and displays the number of words. \n\nWrite a program that reads a text file and displays the longest word in the file.";

                var fs = File.Create(_filepath);
                fs.Dispose();
                File.WriteAllText(_filepath, text);
            }
        }

        public static string ReadFile(string symbolToIgnore = " ")
        {
            CreateFile();
            var fs = File.ReadAllText(_filepath);
            string res = "";
            if (symbolToIgnore != " ")
                res = Regex.Replace(fs, $"[{Regex.Escape(symbolToIgnore)}]", "");
            return res;
        }
    }
}

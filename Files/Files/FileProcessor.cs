using System;
using static System.Console;
using System.IO;

namespace Files
{
    internal class FileProcessor
    {
        private string filePath;

        public FileProcessor(string filePath)
        {
            this.filePath = filePath;
        }

        internal void Process()
        {
            WriteLine($"File processing started");

            //check if file exists
            if (!File.Exists(filePath))
            {
                WriteLine($"file doesnot exist {filePath}");
                return;
            }
            else
            {
                WriteLine($"file exists {filePath}");

            }
        }
    }
}
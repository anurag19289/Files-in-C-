using System;
using static System.Console;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Parsing the command line options");

            var command = args[0];

            if (command == "--file")
            {
                var filePath = args[1];
                WriteLine($"single file {filePath} selected");
                ProcessSingleFile(filePath);
            }
            else if (command == "--dir")
            {
                var dirPath = args[1];
                var fileType = args[2];
                WriteLine($"Directory  {dirPath} selected for {fileType} files");
                ProcessDirectory(dirPath, fileType);

            }
            else
            {
                WriteLine("Invalid command line option");
            }
            WriteLine("Press enter to exit");
            ReadLine();

        }
        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);
            fileProcessor.Process();
        }
        private static void ProcessDirectory(string dirPath, string fileType)
        {

        }


    }
}

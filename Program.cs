using System;
using System.IO;
namespace Lab1
{
    internal class Program1
    {
        static void Main()
        {
            string filePath = "C:\\C-DAC STUDY_MATERIAL\\c#.net\\Websites\\Lab1\\mytest.txt";
            string fileContent = "Hello and Welcome\nIt is the first content\nof the text file mytest.txt in C#";

            // Create the text file and write content to it
            File.WriteAllText(filePath, fileContent);

            // Read the content from the text file
            string readContent = File.ReadAllText(filePath);

            // Display the file's content
            Console.WriteLine($"Here is the content of the file {filePath}:\n{readContent}");
        }
    }


}
using ConsoleApp1;
using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
            string filePath = Path.Combine(projectRoot, "data", "testData.csv");


            FileReader.CSVFileReader(filePath);
        }
    }
}
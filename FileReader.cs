using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    internal class FileReader
    {
        public static void CSVFileReader(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    bool isFirstLine = true;
                    int ranking = 1;

                    //print header
                    Console.WriteLine($"{"Ranking",-10}{"Player",-25} {"Position",-10} {"Junior Team",-40}");
                    Console.WriteLine(new string('-', 90));

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }

                        string[] values = line.Split(',');

                        //skip lines that don't have 3 values
                        if (values.Length < 3) continue;

                        string player = values[0].Trim();
                        string position = values[1].Trim();
                        string juniorTeam = values[2].Trim();

                        Console.WriteLine($"{ranking,-10}{player,-25} {position,-10} {juniorTeam,-40}");
                        ranking++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}

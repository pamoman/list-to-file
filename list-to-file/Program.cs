using System;
using System.IO;
using System.Collections.Generic;

namespace list_to_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/PAMO001/Desktop/scores.txt";

            List<string> scores = new List<string>();

            scores.Add("10");
            scores.Add("40");
            scores.Add("42");

            File.WriteAllLines(path, scores);

            string[] readScores = File.ReadAllLines(path);

            List<string> scoreList = new List<string>(readScores);

            foreach (string score in scoreList)
            {
                Console.WriteLine(score);
            }
        }
    }
}

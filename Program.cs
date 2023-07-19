using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing the jagged array studentScores
            int[][] studentScores = new int[][] {
                 new int[] { 85, 92, 78 },       // Scores of student 1
                 new int[] { 90, 87, 93, 89 },   // Scores of student 2
                 new int[] { 76, 88 }            // Scores of student 3
        };

            // Printing the scores of each student using nested loops
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Scores of Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Calculating and printing the average score for each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine($"Average score of Student {i + 1}: {average:F2}");
            }

            // Calculating and printing the average score for all students combined
            int totalSum = 0;
            int totalLength = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalLength++;
                }
            }
            double totalAverage = (double)totalSum / totalLength;
            Console.WriteLine($"Average score of all students combined: {totalAverage:F2}");
            Console.ReadKey();


        }
    }
    
}

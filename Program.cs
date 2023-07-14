using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssign_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
               int[][] studentScores = new int[3][];
                studentScores[0] = new int[] { 85, 92, 78 };
                studentScores[1] = new int[] { 90, 87, 93, 89 };
                studentScores[2] = new int[] { 76, 88 };                
                for (int i = 0; i < studentScores.Length; i++)
                {
                    Console.WriteLine("Scores for Student " + (i + 1));
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        Console.WriteLine("Score " + (j + 1)  + studentScores[i][j]);
                    }
                    Console.WriteLine();
                }               
                for (int i = 0; i < studentScores.Length; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        sum += studentScores[i][j];
                    }
                    double average = sum / studentScores[i].Length;
                    Console.WriteLine("Average score for Student " + (i + 1) + average);
                }                
                double totalSum = 0;
                int totalCount = 0;
                for (int i = 0; i < studentScores.Length; i++)
                {
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        totalSum += studentScores[i][j];
                        totalCount++;
                    }
                }
                double totalAverage = totalSum / totalCount;
                Console.WriteLine("Average score for all students combined: " + totalAverage);
            Console.ReadKey();
        }



    }
}
    


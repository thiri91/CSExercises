using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] stud = new int[,] { 
                                        { 56, 84, 68, 29 }, 
                                        { 94, 73, 31, 89 },
                                        { 41, 63, 36, 90 },
                                        { 99, 9, 18, 17 },
                                        { 62, 3, 65, 75 }, 
                                        { 40, 96, 53, 23 },
                                        { 81, 15, 27, 30 },
                                        { 21, 70, 100, 22 },
                                        { 88, 50, 13, 12 },
                                        { 48, 54, 52, 78 },
                                        { 64, 71, 67, 25 }, 
                                        { 16, 93, 46, 72 } 
                                        };
            int sum,i,j;
            int rowLength = stud.GetLength(0);
            int colLength = stud.GetLength(1);
        //    Console.WriteLine("stud {0}", stud.Length);
            //problem a
            for (i = 0; i < rowLength; i++)
            {
                sum = 0;
                for (j = 0; j < colLength; j++)
                {
                    sum += stud[i, j];
                }
                Console.WriteLine("totalmarks {0}", sum);

            }
            //problem b&c
            int total = 0;
            for (i = 0; i < colLength; i++)
            {
                sum = 0;
                for (j = 0; j < rowLength; j++)
                {
                    sum += stud[j,i];
                }
                total += sum;
                Console.WriteLine("class average Student {0}", sum/12);

            }
            Console.WriteLine("all average Student {0}", total / stud.Length);
          
        }
    }
}

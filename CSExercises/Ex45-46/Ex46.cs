using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Random ram = new Random();
            int[] arr = new int[10];
            int scretNum;
           // scretNum = ram.Next(0, 9);

            for (int i=0;i<arr.Length;i++)
            {
                scretNum = ram.Next(0, 9);
                //Console.WriteLine(scretNum);
                 switch (scretNum)
                 {
                     case 0:
                    arr[scretNum]++;
                         break;
                     case 1:
                    arr[scretNum]++;
                         break;
                     case 2:
                    arr[scretNum]++;
                         break;
                     case 3:
                    arr[scretNum]++;
                         break;
                     case 4:
                    arr[scretNum]++;
                         break;
                     case 5:
                    arr[scretNum]++;
                         break;
                     case 6:
                         arr[scretNum]++;
                         break;
                     case 7:
                         arr[scretNum]++;
                         break;
                     case 8:
                         arr[scretNum]++;
                         break;
                     case 9:
                         arr[scretNum]++;
                         break;
                     //default:
                     //    break;
                 }
                // if (scretNum == arr[scretNum])
                //{
                //    Console.WriteLine("if");

                //    arr[scretNum]++;
                //}
            

            }
            Console.WriteLine("Number\tCount");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", i, arr[i].ToString().PadLeft(2,' '));
            }
            Console.WriteLine("Number\tCount");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}\t",i);
                for (int j = 0; j < arr[i]; j++)
                {
                    Console.Write("{0}","*");
                }
                Console.WriteLine();
            }
         
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
             int sum;
          //  Console.Write("Enter a Number : ");
          //  number = int.Parse(Console.ReadLine());
            for (int j = 1; j <= 1000; j++)
            {
                sum = 0;
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == j)
                {
                    Console.WriteLine("{0}",j);
                }

            }

            //////////////////////
           /* int sum = 0;
            int i, j = 1;

            for (i = 1; i <= 1000; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }

                }
                if (sum == i)
                {
                    Console.WriteLine("{0}", i);
                }
                sum = 0;
            }*/
        }
    }
}

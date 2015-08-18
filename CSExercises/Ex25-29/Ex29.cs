using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            /*
             * p a prime number, as follows:

                for p = 2:   21(22 − 1) = 6
                for p = 3:   22(23 − 1) = 28
                for p = 5:   24(25 − 1) = 496
                for p = 7:   26(27 − 1) = 8128.
             
                the form 2p−1(2p − 1)

             */
            int number,sum=0;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number;i++)
            {
                if (number % i == 0)
                {
                    sum=sum + i;
                }
            }
                if (sum == number)
                {
                    Console.WriteLine("Perfect Number");
                }
                else
                {
                    Console.WriteLine("Not Perfect Number");
                }
            }

        }
 }


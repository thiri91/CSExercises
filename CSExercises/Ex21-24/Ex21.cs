using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter integer number:");
            int num =-1;
            int guess = 88;
            while (num != guess)
            {

                  Console.WriteLine("Enter integer number:");
                   num = Convert.ToInt32(Console.ReadLine());
                   if (guess == num) Console.WriteLine("you got it");
                 //  else Console.WriteLine("Enter integer number:");
            }
        }
    }
}

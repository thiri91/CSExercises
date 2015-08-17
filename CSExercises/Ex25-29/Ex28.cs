using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int boundary = Convert.ToInt32(Math.Floor(Math.Sqrt(num)));
           // Console.Write("boundary:{0}", boundary);

            if (num == 1) Console.WriteLine("Not Prime");
            if (num == 2) Console.WriteLine("Prime");
            Boolean is_prime = true;

            for (int i = 2; i <= boundary; i++)
            {
                if (num % i == 0) is_prime=false;
                //Console.Write("is_prime:{0}", is_prime);

            }
            if (is_prime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
               

        }
        //n is a multiple of any integer between 2 and sqrt{n}. 

       /* public static bool isPrime(int number)
        {
            int boundary = Convert.ToInt32(Math.Floor(Math.Sqrt(number)));
            Console.Write("boundary:{0}", boundary);
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }*/
    }
}

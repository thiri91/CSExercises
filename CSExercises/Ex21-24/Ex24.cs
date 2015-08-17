using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random ram = new Random();

            Console.WriteLine("Enter number");
            int N = Convert.ToInt32(Console.ReadLine());

            int guess = ram.Next(1, N);
            Console.WriteLine("guess:{0}", guess);

            while(guess*guess!=N)
            {
                guess = (guess + N / guess) / 2;
            }

        }
    }
}

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

            double guess = ram.NextDouble();
            guess = guess * (N - 1);
            guess = guess + 1;
            //Console.WriteLine("guess:{0}", guess);

            bool result = true;
            do
            {
                result = Math.Abs((guess * guess) - N) < 0.0001;
               // Console.WriteLine(result);
                if (result == false)
                {
                    guess = (guess + N / guess) / 2;

                }
            } while (result == false);
                //while (result)
                //{
                //    result = Math.Abs((guess * guess) - N) < 0.0001;
                //    if(!result)
                //        guess = (guess + N / guess) / 2;
                //}
             //   Console.WriteLine(guess);
            Console.WriteLine("guess:{0}", guess);

        }
        
                
    }
}

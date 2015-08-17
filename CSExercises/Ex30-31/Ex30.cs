using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                bool is_prime = true;
                int boundary = Convert.ToInt32(Math.Floor(Math.Sqrt(i)));
                for (int j = 2; j <= boundary; j++)
                {
                    if (i % j == 0) is_prime = false;
                }
                if (is_prime) Console.WriteLine("{0}",i);
            }
        }
    }
}

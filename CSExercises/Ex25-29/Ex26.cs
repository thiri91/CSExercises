using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.Write("No\tInverse\tSquareRoot\tSquare");
            for (double i = 1.0; i <= 10.0; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0:0.0}\t{1:0.000}\t{20.000}\t{3:0.0}", i, 1/i, Math.Sqrt(i),i*i);
            }
        }
    }
}

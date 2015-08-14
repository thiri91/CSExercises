using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an Double Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square Root Result is {0}", Math.Sqrt(num));
        }
    }
}

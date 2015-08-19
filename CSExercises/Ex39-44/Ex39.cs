using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex39
    {
        public static double Factorial(double n)
        { 
            double result=1;
            if(n>1)
                 result = n * Factorial(n - 1);
            return result;
        }
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number");
            double num = Convert.ToDouble(Console.ReadLine());
            double result = Factorial(num);
            Console.WriteLine("result {0}", result);
        }
    }
}

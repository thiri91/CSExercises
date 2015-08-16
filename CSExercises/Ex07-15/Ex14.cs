using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");			
            double a = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());			
			
			double s=(a+b+c)/2;
            Console.WriteLine("{0}", Math.Sqrt(s*(s-a)*(s-b)*(s-c)));
        }
    }
}
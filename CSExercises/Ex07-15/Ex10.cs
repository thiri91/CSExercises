using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");			
            int x1 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

           double x = x2 - x1;
            double y = y2 - y1;
            double ans = Math.Pow(x, 2) + Math.Pow(y, 2);
          //  double ans = Math.Pow(x1, 2);
            Console.WriteLine("{0}", Math.Sqrt(ans));
        }
    }
}

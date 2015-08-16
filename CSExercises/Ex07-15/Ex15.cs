using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");			
            double x= Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            string input=x+""+y+""+z;
            double armstrong = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
            if (Convert.ToDouble(input) == armstrong)
                Console.WriteLine("armstrong number");
            else Console.WriteLine("not armstrong number");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
			
            Console.WriteLine("{0:0.##}", Math.Round(distance*0.4+2.40,2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
         
			Console.WriteLine("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
			
            Console.WriteLine("{0}", distance*0.4+2.40);
			
        }
    }
}

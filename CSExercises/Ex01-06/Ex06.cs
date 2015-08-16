using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0:0.###}", Math.Sqrt(num));
        }
    }
}

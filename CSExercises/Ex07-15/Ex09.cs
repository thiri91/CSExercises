using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double pow = Math.Pow(num, 2);
            Console.WriteLine("{0}", 2 * pow - 4 * num + 3);
        }
    }
}

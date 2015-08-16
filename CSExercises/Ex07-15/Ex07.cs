using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an salary: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:c}", num+(num*10/100)+(num*3/100));
        }
    }
}

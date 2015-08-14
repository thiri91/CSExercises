using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", num * num);
        }
    }
}

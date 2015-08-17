using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter gender M or F:");
            string gender = Console.ReadLine();
            if (gender.Equals("M"))
                Console.WriteLine("good Morning Mr.{0}", name);
            else if (gender.Equals("F"))
                Console.WriteLine("good Morning Ms.{1}", name);

        }
    }
}
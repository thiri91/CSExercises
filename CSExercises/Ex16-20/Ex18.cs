using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter mark:");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= 80 && mark <= 100)
                Console.WriteLine("you scored {0} marks which is a grade.",mark);
            else if (mark >= 60 && mark <= 79)
                //Console.WriteLine("B");
                Console.WriteLine("you scored {0} marks which is b grade.",mark);

            else if (mark >= 40 && mark <= 59)
                //Console.WriteLine("C");
                Console.WriteLine("you scored {0} marks which is c grade.",mark);

            else if (mark >= 0 && mark <= 40)
               // Console.WriteLine("F");
               Console.WriteLine("you scored {0} marks which is f grade.",mark);

            else if (mark < 0)
                Console.WriteLine("**Error**");
            else if (mark > 100)
                Console.WriteLine("**Error**");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A");
            int num_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B");
            int num_b = Convert.ToInt32(Console.ReadLine());
            double lcm = num_a * num_b;
            while (num_a != num_b)
            {              
                 if (num_a > num_b)
                    num_a -= num_b;
                else if(num_a < num_b)
                    num_b -= num_a;
            }
            Console.WriteLine("HFC:{0}", num_a);
            Console.WriteLine("LCM:{0}", lcm / num_a);
           
           

        }
    }
}

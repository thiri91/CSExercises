using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter factorial:");
            int fact = Convert.ToInt32(Console.ReadLine());
            int ans_i = 1;
                int ans_j=1;
            //problem a
            for (int i = 1; i <= fact; i++)
            {
                Console.Write("{0} ", i);
                ans_i *= i;
                Console.WriteLine("{0}", ans_i);
            }
            Console.WriteLine("");
            //problem b
           for (int j = fact; j >= 1; j--)
            {
                Console.Write("{0} ", j);
                ans_j *= j;
                Console.WriteLine("{0}", ans_j);
            }
               

        }
    }
}

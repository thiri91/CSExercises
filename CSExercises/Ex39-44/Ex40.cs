using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
           
            Console.Write("Please enter number");
           int ans = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(SQT(ans));
            for (int i = 1; i <=25; i++)
            {
                Console.WriteLine(SQT(i));
            }
        }

        public static double SQT(int y)
        {
            return Math.Sqrt(y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            //problem a
            Console.WriteLine("X\tY");
            for(int i=-5;i<=5;i++)
            {
                double pow = Math.Pow(i, 2);
                Console.WriteLine("{0:.0}\t{1:.0}", i,2 * pow - 4 * i + 3);

            }

            //problem b
            for (int i = -5; i <= 5; i++)
            {
                double pow = Math.Pow(i, 2);
                double ans = 2 * pow - 4 * i + 3;
                for (double j = ans; j >= 1;j-- )
                    Console.Write("{0}",'*');
                Console.WriteLine("");
            }

        }
    }
}

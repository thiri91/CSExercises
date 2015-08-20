using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {

            int[] count = new int[] { 0, 0, 0, 0, 0 };
            int[] cents = new int[] { 100, 50, 20, 10, 5 };
            Console.WriteLine("Enter the amount");
            double dollar = Convert.ToDouble(Console.ReadLine())*100;
           // double dollar = 1.40 * 100;

            for (int i = 0; i < cents.Length; i++)
            {
                
                while (dollar >= cents[i])
                {
                   
                    count[i] = Convert.ToInt32((Math.Floor(dollar / cents[i])));

                    dollar = dollar % cents[i];

                    //Console.WriteLine(count[i]);
                }

            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 1)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        Console.WriteLine("{0}c", cents[i]);
                    }
                }
                else if(count[i]>0)Console.WriteLine("{0}c", cents[i]);
            }
        }
    }
}

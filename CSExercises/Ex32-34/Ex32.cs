using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            //int[] sales = new int[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 12000 };
            int[] sales = new int[12];

            //enquire array
            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter Sales For Month:{0} ", i);
                int entry = Convert.ToInt32(Console.ReadLine());
                sales[i] = entry;
            }
            //ouput and sum array
            int sum = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write("{0} ", sales[i]);
                sum += sales[i];
            }

            Console.WriteLine();
            int large = sales.Max();
            int small = sales.Min();
            int large_index = sales.ToList().IndexOf(large);
            int small_index = sales.ToList().IndexOf(small);
            Console.WriteLine("Maximum Sales {0}", large_index);
            Console.WriteLine("Minimum Sales {0}", small_index);
            Console.WriteLine("Average Sales {0}", sum / 12);

            //another to find max and min
            //for (int i = 0; i < sales.Length; i++)
            //{
            //    for (int j = i+1; j < sales.Length; j++)
            //    {
            //       if(sales[i]>sales[j])
            //       {
            //           int temp=sales[i];
            //           sales[i] = sales[j];
            //           sales[j] = temp;
            //       }
            //    }
            //}
            //Console.WriteLine("after sorting");
            //sum = 0;
            //for (int i = 0; i < sales.Length; i++)
            //{
            //    Console.Write("{0} ", sales[i]);
            //    sum += sales[i];               
            //}
            //Console.WriteLine("Maximum Sales {0}", sales[11]);
            //Console.WriteLine("Minimum Sales {0}", sales[0]);
            //Console.WriteLine("Average Sales {0}", sum / 12);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);             
            }
            Console.WriteLine("");      
        }
    }
}

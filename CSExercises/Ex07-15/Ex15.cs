using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");			
            double x= Convert.ToDouble(Console.ReadLine());
			
            //Console.WriteLine("Enter y: ");
            //double y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter z: ");
            //double z = Convert.ToDouble(Console.ReadLine());
            int one_digit,two_digit,three_digit;//153
            one_digit = (int)x / 100;
            int remain =(int) x % 100;
            two_digit=(int)remain/10;
            three_digit=(int)remain%10;

          

          //  string input=x+""+y+""+z;
            double armstrong = Math.Pow(one_digit, 3) + Math.Pow(two_digit, 3) + Math.Pow(three_digit, 3);
            Console.WriteLine(armstrong);
            if (x == armstrong)
                Console.WriteLine("armstrong number");
            else Console.WriteLine("not armstrong number");
        }
    }
}
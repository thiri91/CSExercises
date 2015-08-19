using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.Write("Please integer to change hex");
            int num = Convert.ToInt32(Console.ReadLine());
            string ans=Hex(num);
            Console.WriteLine("Hex"+ans);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} {1}",i,Hex(i));
            }

        }
        public static string Hex(int i)
        {
            // Store integer 182
           // int decValue = 182;//default number

            // Convert integer 182 as a hex in a string variable
            string hexValue = i.ToString("X");
            //Console.WriteLine("hexValue{0}", hexValue);

            // Convert the hex string back to the number
            //int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

            return hexValue;
        }
    }
}

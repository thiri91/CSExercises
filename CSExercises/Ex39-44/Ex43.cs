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

           /* for (int i = 1; i <= 100; i++)//testing
            {
                Console.WriteLine("{0} {1}", i, i.ToString("X"));
            }*/

        }
        public static string Hex(int i)
        {
            string ans="";
            int remain=i;
            if (i >= 16)
            {
                while (i / 16 > 0)
                {
                    ans += (i / 16).ToString();
                    //Console.WriteLine("i" + i);
                    remain = i % 16;

                    i = i / 16;

                   // Console.WriteLine("remain" + remain);

                }
            }
            //Console.WriteLine(remain);
            switch (remain)
            {
                case 10:
                    ans += "A";
                    break;
                case 11:
                    ans += "B";
                    break;
                case 12:
                    ans += "C";
                    break;
                case 13:
                    ans += "D";
                    break;
                case 14:
                    ans += "E";
                    break;
                case 15:
                    ans += "F";
                    break;
                default:
                    ans += remain.ToString();
                    break;
            }
            return ans;
        }
    }
}
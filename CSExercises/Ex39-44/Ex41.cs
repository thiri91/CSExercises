using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.Write("Please string");
            string s1 = Console.ReadLine().ToLower();
            Console.Write("Please another string");
            string s2 = Console.ReadLine().ToLower();

            if (InString(s1, s2))
                Console.WriteLine("Found");
            else Console.WriteLine("Not Found");
        }
        public static bool InString(string s1, string s2)
        {
           // return false;
            string[] str_1 = s1.Split(' ');
            string[] str_2 = s2.Split(' ');
            int count = 0;
            for (int i = 0; i < str_1.Length; i++)
            {
                for (int j = 0; j < str_2.Length; j++)
                {
                    if (String.Compare(str_1[i], str_2[j]) == 0)
                    {
                        count++;
                    }
                }
            }
           // Console.WriteLine("count{0}", count);
           // Console.WriteLine("str_2{0}", str_2.Length);

            if (count > 0)
                return true;
            else return false;
        }
    }
}

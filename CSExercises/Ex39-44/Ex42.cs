using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {            
            Console.Write("Please string");
            string str1 = Console.ReadLine();

            Console.Write("Please another string");
            string str2 = Console.ReadLine();

            int ans = FindWord(str1, str2);
            Console.WriteLine("Index {0}", ans);
        }
        public static int FindWord(string s1, string s2)
        {
            int index = s1.IndexOf(s2);
            return index;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            string str=Substitute("This is me", 'i', 'a');
            Console.WriteLine(str);
        }

        public static string Substitute(string s, char c1, char c2)
        {
            char[] str_1 = s.ToArray();
            int count = 0;
            string ans = "";
            for (int i = 0; i < str_1.Length; i++)
            {
                
                    if (str_1[i]==c1)
                    {
                        str_1[i]=c2;
                    }
                    ans += str_1[i];
            }

            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {

            //            char[] match_arr ={'a', 'e', 'i', 'o', 'u'};
            //problem a
            Console.Write("Please enter a pharse");
            string phase = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < phase.Length; i++)
            {
                //  Console.WriteLine(phase.Substring(i,1));
                if (phase.Substring(i, 1).ToUpper().Equals("A") || phase.Substring(i, 1).ToUpper().Equals("E") || phase.Substring(i, 1).ToUpper().Equals("I") || phase.Substring(i, 1).ToUpper().Equals("O") || phase.Substring(i, 1).ToUpper().Equals("U"))
                {
                    count++;

                }

            }
            Console.WriteLine("Total number of vowels {0}", count);

            //problem b

            char[] phase_2 = phase.ToLower().Trim().ToArray();
          
            int count_a = 0;
            int count_e = 0;
            int count_i = 0;
            int count_o = 0;
            int count_u = 0;
            for (int i = 0; i < phase_2.Length; i++)
            {
                

                if (phase_2[i].Equals('a')) count_a++;
                else if (phase_2[i].Equals('e')) count_e++;
                else if (phase_2[i].Equals('i')) count_i++;
                else if (phase_2[i].Equals('o')) count_o++;
                else if (phase_2[i].Equals('u')) count_u++;

            }
            Console.WriteLine("number of a {0}", count_a);
            Console.WriteLine("number of e {0}", count_e);
            Console.WriteLine("number of i {0}", count_i);
            Console.WriteLine("number of o {0}", count_o);
            Console.WriteLine("number of u {0}", count_u);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[]{"John","Venkat","Mary","Victory","Betty"};
            int[] mark = new int[]{63,29,75,82,55};
            int mark_temp;
            string name_temp;
            //problem a
            for (int i = 0; i < mark.Length; i++)
            {
                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (mark[i] < mark[j])
                    {
                        mark_temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = mark_temp;

                        name_temp = name[i];
                        name[i] = name[j];
                        name[j] = name_temp;
                    }
                }
            }
            for (int i = 0; i < mark.Length; i++)
            {
                Console.Write("{0} ", mark[i]);
                Console.Write("{0} ", name[i]);
                Console.WriteLine();

            }

            //problem b
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (String.Compare(name[i], name[j]) > 0)//>0 ascending ,1 descending
                    {
                        name_temp = name[i];
                        name[i] = name[j];
                        name[j] = name_temp;


                        mark_temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = mark_temp;
                    }
                }
            }
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("{0} ", name[i]);
                Console.Write("{0} ", mark[i]);
                Console.WriteLine();
            }
            
        }
    }
}

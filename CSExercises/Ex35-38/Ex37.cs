using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static string ToTitleCase(string str)
        {
            string result = str;
            if (!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' ');
                for (int index = 0; index < words.Length; index++)
                {
                    var s = words[index];
                    if (s.Length > 0)
                    {
                        words[index] = s[0].ToString().ToUpper() + s.Substring(1);
                    }
                }
                result = string.Join(" ", words);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter a pharse");

            string phrase = Console.ReadLine();// "The quick  brown fox";
            string[] words;

            words = phrase.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                //Console.WriteLine(words[i]);
                string temp = words[i];
               // Console.WriteLine("temp {0}", temp);
                //  for (int j = 0; j < words[i].Length; j++)
                //  {
                if (temp.Length > 0)
                {
                    //Console.WriteLine(temp[0].GetType());//char get datatype from this variable
                   // Console.WriteLine(temp[0].ToString().ToUpper());//char get only one character
                    words[i]=temp[0].ToString().ToUpper()+temp.Substring(1);
                }
               // Console.WriteLine("After test");

                Console.Write(words[i]+" ");

            }
            Console.WriteLine();
        }
    }
}

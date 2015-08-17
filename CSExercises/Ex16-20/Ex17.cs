using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter gender M or F:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            string nametype="";

            if (gender.ToUpper().Equals('M'))
            {
                if (age >= 40)
                {
                    nametype = "Uncle";
                }
                else if (age < 40)
                {
                    nametype = "Mr.";
                }                
            }
            else if (gender.ToUpper().Equals('F'))
            {
                if (age >= 40)
                {
                    nametype = "Aunty";
                }
                else if (age < 40)
                {
                    nametype = "Mrs";
                }               
            }
          //  else Console.WriteLine("out of information");
            Console.WriteLine("Good Morning {0} {1}", nametype, name);
                
        }
    }
}
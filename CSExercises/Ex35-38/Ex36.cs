using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a pharse");

          //  string myList = "I am hnin";
            char[] myArray = Console.ReadLine().Trim().ToArray();
            int first = 0;
            int last = myArray.Length - 1;
            bool is_palindrome = false;
            while (first < last )
            {
                if (!myArray[first].Equals(myArray[last]))
                {
                    is_palindrome = false;
                }
                else is_palindrome = true;
                first++;
                last--;
            }
            if (is_palindrome) Console.WriteLine("Palindrome");
            else Console.WriteLine("Not Palindrome");
          
        }
    }
}

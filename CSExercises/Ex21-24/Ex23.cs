using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random mind=new Random();

            int guess ;
            
            int secretNumber = mind.Next(0,10);

            int count = 0;
            Console.WriteLine("secretNumber{0}", secretNumber);
            do
            {
                count++;

                Console.WriteLine("Enter interger 0-9");
               guess = Convert.ToInt32(Console.ReadLine());   

                if (guess == secretNumber)
                {
                    if (count == 1)
                    {
                        Console.WriteLine("you are wizard");
                        Console.WriteLine("count{0}", count);
                    }
                    else if (count == 2)
                    {
                        Console.WriteLine("You are a good guess");
                        Console.WriteLine("count{0}", count);
                    }
                    else if (count >= 3)
                    {
                        Console.WriteLine("You are lousy");
                        Console.WriteLine("count{0}", count);
                    }
                    else Console.WriteLine("try again");

                } else Console.WriteLine("Try again");

            } while (secretNumber != guess);
        }
    }
}

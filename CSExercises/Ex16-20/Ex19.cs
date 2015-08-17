using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter travel in km:");
            double travel_km = Math.Ceiling(Convert.ToDouble(Console.ReadLine())*10)/10;
        //    Console.WriteLine("{0}", travel_km);
           double ans=0.0;
            if (travel_km <= 0.5)
                ans = 2.40;
            else if (travel_km <= 8.5)
            {
                Console.WriteLine("ggg");
                ans = 2.40 + 85 * 0.04+(travel_km * 10 - 85) * 0.05;
            }                
            else if (travel_km >= 9.0)
            {
                Console.WriteLine("fff");
                ans = 2.40 + 85 * 0.04+(travel_km*10- 90) * 0.05;
            }
            Console.WriteLine("{0}", Math.Ceiling(ans * 10) / 10);

        }
    }
}
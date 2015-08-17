using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity for TV");
            int qty_tv =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter quantity for DVD");
            int qty_dvd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter quantity for MP3");
            int qty_mp3 = Convert.ToInt32(Console.ReadLine());

            double tv_dvd_charges = qty_tv * 900 + qty_dvd * 500;
            double discount=0.0;
            if (tv_dvd_charges <= 5000 && tv_dvd_charges >= 9999)
                discount=tv_dvd_charges*10/100;
            else if(tv_dvd_charges>=10000)
                discount = tv_dvd_charges * 15 / 100;
            tv_dvd_charges -= discount;

            double ans = tv_dvd_charges+qty_mp3 * 700;
            Console.WriteLine("{0}", ans);
        }
    }
}
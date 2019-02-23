using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exertional_Load_Calculator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int sets = 0;
            int load = 0;
            int reps = 0;
            int repsInReserve = 0;
            double exertionalLoad = 0;
            int repTime = 0;
            double totalTime = 0;
            double XLPerMin = 0;
            double totalXL = 0;

            Console.WriteLine("How many sets?");
            sets = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sets; i++)
            {
                Console.WriteLine("What is the load for set " + i + "?");
                load = int.Parse(Console.ReadLine());

                Console.WriteLine("How many reps for set " + i + "?");
                reps = int.Parse(Console.ReadLine());
                repTime = reps * 4;
                totalTime += repTime;
                repTime = 0;

                Console.WriteLine("How many reps in reserve for set " + i + "?");
                repsInReserve = int.Parse(Console.ReadLine());


                for (int j = reps; j > 0; j--)
                {
                    exertionalLoad += load * Math.Pow(2.71828, -0.215 * (reps + repsInReserve - j));
                }

                Console.WriteLine("The exertional load of this set is: " + exertionalLoad);
                Console.WriteLine("How long are you resting after the set in seconds?");
                totalTime += int.Parse(Console.ReadLine());
                totalXL += exertionalLoad;
                exertionalLoad = 0;
            }

            double totalMin = totalTime / 60;
            double min = Math.Floor(totalMin);
            double seconds = totalTime % 60;


            XLPerMin = totalXL / (totalMin);
            Console.WriteLine("The exertional load of the workout is: " + totalXL);
            Console.WriteLine("The total time of the workout is: " + min + " minutes, " + seconds + " seconds.");
            Console.WriteLine("The XL/minute is: " + XLPerMin);
            Console.ReadLine();
        }
    }

}

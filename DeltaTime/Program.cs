using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeltaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTime();
        }


        public static void TestTime()
        {
            int timeAllMinutes;

            int nowAllMinutes;

            do
            {
                string timeNow = DateTime.Now.ToString("HH:mm:ss:fff");

            string timeConst = "09:05:00";

            int timeHour = 9;

            int timeMinutes = 20;

            timeAllMinutes = timeHour * 60 + timeMinutes;

            string nowHour = DateTime.Now.ToString("HH");
            int intNowHour = Convert.ToInt32(nowHour);

            string nowMinutes = DateTime.Now.ToString("mm");
            int intnowMinutes = Convert.ToInt32(nowMinutes);

            nowAllMinutes = intNowHour * 60 + intnowMinutes;

            if (timeAllMinutes < nowAllMinutes)
            {
                
            }

            else
            {
                Console.WriteLine("Рано ещё!!! ");
            }



            Console.WriteLine("Привет мир");

            Console.WriteLine(timeNow);

            Console.WriteLine(timeConst);

            Console.WriteLine();
                Thread.Sleep(5000);
            } while (timeAllMinutes< nowAllMinutes);

            Console.WriteLine("Победа!!!");
        }

    }
}

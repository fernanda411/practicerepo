using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    public class Timer
    {
        public static void Timer1()
        {
           Init.Header(Init.op);
            Console.WriteLine("Para começar aperte qualquer tecla ");
            Console.ReadKey(true);
            DateTime time = new DateTime();
            do
            {
                if (Console.KeyAvailable == false)
                {
                    time = ScreenTimer(time);
                    Thread.Sleep(1000);
                }
                else
                {
                    FinalTimer(time);
                    Init.op = -1;
                    return;
                }
            } while (true);
        }

        public static DateTime ScreenTimer(DateTime time)
        {
            Init.Header(Init.op);
            time = time.AddSeconds(1);
            Console.Write(time.ToLongTimeString());
            return time;
        }
        public static void FinalTimer(DateTime time)
        {
            Init.Header(Init.op);
            Console.WriteLine(time.ToLongTimeString());
            Console.Write("Finalizado!");
        }

    }
}

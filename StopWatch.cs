using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    public class StopWatch
    {
        public static void StopWatch1()
        {
            Console.WriteLine("Digite o tempo desejado 0H:0M:0S");
            var time = Console.ReadLine();

            bool ok = DateTime.TryParse(time, out DateTime timeok);
            while (!ok)
            {
                Console.WriteLine("Digite da forma correta 0H:0M:0S");
                ok = DateTime.TryParse(Console.ReadLine(), out timeok);
            }

            DateTime timefixo = timeok;
            ScreenStopWatch(timeok, timefixo);
        }


        public static void ScreenStopWatch(DateTime timeok, DateTime timefixo)
        {
            Init.Header(Init.op);
            Console.WriteLine(timefixo.ToLongTimeString());

            if ((timeok.Hour > 0 || timeok.Minute > 0) || timeok.Second > 0)
            {
                Console.WriteLine(timeok.ToLongTimeString());
                Thread.Sleep(1000);
                timeok = timeok.AddSeconds(-1);
                ScreenStopWatch(timeok, timefixo);

            }
            else
            {
                Console.WriteLine("finalizado");
                Thread.Sleep(1000);
                return;
            }

        }
    }
}

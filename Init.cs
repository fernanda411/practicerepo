using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    public class Init
    {
        public static Dictionary<int, string> func = new Dictionary<int, string>()
        {
            {1 , "Cronometro" },
            {2 , "Temporizador" },
            {3 , "Relogio Mundial" },
            {0 , "Voltar" }
         };

        public static int op = -1;
        public static void Ini()
        {
            while (true)
            {
                Header(op);
                op = Options();
                if (op == 0)
                {
                    return;
                }
                else if (op == 1)
                {

                    Timer.Timer1();
                }
                else if (op == 2)
                {

                    StopWatch.StopWatch1();
                }
                else if (op == 3)
                {
                    Header(op);

                    WorldWatch.WorldWatch1();
                  

                }
            }


        }
        public static int Options()
        {
            Console.WriteLine("Escolha sua opção");
            foreach (var i in func)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }

            var ans = Console.ReadLine();
            bool ans_ok = int.TryParse(ans, out op);
            while (!ans_ok)
            {
                Console.WriteLine("Por favor digite uma opção valida");
                ans_ok = int.TryParse(Console.ReadLine(), out op);
            }
            return op;
        }
        public static void Header(int op)
        {
            Console.Clear();
            Console.WriteLine($"WATCH".PadLeft(50, ' '));
            Console.WriteLine("-".PadRight(100, '-'));
            Console.WriteLine("-".PadRight(100, '-'));
            if (op > 0 && op < 4)
            {
                Console.WriteLine($"{func[op]}".PadLeft(50, ' '));
                Console.WriteLine("-".PadRight(100, '-'));
                Console.WriteLine("-".PadRight(100, '-'));
            }

        }

    }

}

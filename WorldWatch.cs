using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    public  class WorldWatch
    {
        public static void WorldWatch1()
        {
            Init.Header(Init.op);

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.WriteLine("Digite o nome da regiao");
            var region = Console.ReadLine();
            Console.WriteLine("Digite a cidade");
            var city = Console.ReadLine();
            var teste = new HttpClient();
            var jsonTime = new WAPIPassWorldClock();


            try
            {
                var resposta = teste.GetStringAsync($"http://worldtimeapi.org/api/timezone/{region}/{city}");
                resposta.Wait();
                jsonTime = JsonConvert.DeserializeObject<WAPIPassWorldClock>(resposta.Result);
                if (resposta.Result == null || resposta.Status == TaskStatus.Faulted)
                {
                    Console.WriteLine("Erro");
                    Console.ReadKey();
                    WorldWatch1();

                }
                else
                {
                    var testando = new APIPassWorldClock();
                    testando.PassAPIWorldWatch(jsonTime);
                    Console.WriteLine(testando.ViewWorldWatch());
                    Console.ReadKey();
                    Init.op = -1;
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Erro");
                Console.WriteLine("verifique a regiao e tente novamente ");
                Console.ReadKey();
                WorldWatch1();
            }



        }
    }
}

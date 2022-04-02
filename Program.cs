using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // Isola tempo(10) do tipo(s)
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // s ou m (Buscando ultimo usuário)
            int time = int.Parse(data.Substring(0, data.Length - 1));  // Converter para minusculo
            int multiplier = 1;   //multiplicador

            if (type == 'm')
                multiplier = 60;  //Se for 'm" multiplica por 60

            if (time == 0)
                System.Environment.Exit(0);  // tempo 0 sai do aplicativo
            PreSart(time * multiplier); //Conversao implicita

        }

        static void PreSart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);              //thread 
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);


        }
        static void Start(int time)

        {
            int currentTime = 0;

            while (currentTime != time)     //laço de repeticao
            {
                Console.Clear();

                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}

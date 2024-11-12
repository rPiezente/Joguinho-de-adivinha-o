using System;
using System.Globalization;
using System.Threading;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Resultado();
        }

        static void Resultado()
        {
            Console.Clear();
            Random numero = new Random();
            int NumeroSecreto = numero.Next(1, 101);
            int tentativa = 1;

            Console.WriteLine("!!!Bem vindo ao jogo de adivinhação!!!");
            
            while (true)
            {
                Console.Write("Digite um número: ");
                
                int palpite;
                try
                {
                    palpite = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    continue;
                }

                if (palpite == NumeroSecreto)
                {
                    Console.Clear();
                    Console.WriteLine("PARABÉNS ACERTOUUU !!!");
                    Console.WriteLine($"O número secreto era {NumeroSecreto}");
                    Console.WriteLine($"Você precisou de {tentativa} tentativas para acertar");
                    break;
                }
                else if (palpite < NumeroSecreto)
                {
                    Console.Clear();
                    Console.WriteLine("!!!Bem vindo ao jogo de adivinhação!!!");
                    Console.WriteLine("Não foi dessa vez...");
                    Thread.Sleep(700);
                    Console.WriteLine("Número muito baixo");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("!!!Bem vindo ao jogo de adivinhação!!!");
                    Console.WriteLine("Não foi dessa vez...");
                    Thread.Sleep(700);
                    Console.WriteLine("Número muito alto");
                }

                tentativa++;
            }

            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Deseja jogar novamente?");
            Console.WriteLine("0) NÃO           1) SIM");
            
            int JogarNovamente;
            try
            {
                JogarNovamente = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entrada inválida. Saindo do jogo.");
                return;
            }

            if (JogarNovamente == 1)
                Resultado();
            else
            {
                Console.Clear();
                System.Environment.Exit(0);
            }
        }
    }
}
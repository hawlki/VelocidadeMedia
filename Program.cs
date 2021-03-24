using System;

namespace velocidadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Insira os dados a seguir:");
            Console.Write("Distância em metros: ");
            String D = Console.ReadLine();
            Console.Write("Tempo em segundos: ");
            String T = Console.ReadLine();

            Double distancia = Convert.ToDouble(D);
            Double Tempo = Convert.ToDouble(T);
            Double velocidadeMedia = distancia / Tempo;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"A velocidade média é {velocidadeMedia} m/s");

            Console.ResetColor();
            Console.WriteLine("Toque em uma tecla para limpar sua tela");
            Console.ReadKey();

            Console.Clear();


        }
    }
}

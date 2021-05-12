using System;

namespace Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {
             string [] nomes = new string [3];
            // var i = 0;

            Console.WriteLine($"Digite {nomes.Length} nomes: ");

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º nome: ");
                nomes [i] = Console.ReadLine().ToLower();
                
            }

            Console.WriteLine("[Busca] Digite o nome que você está a procura: ");
            string nomeBusca = Console.ReadLine();

            bool achado = false;


            foreach (var cadaNome in nomes)
            {
                if (nomeBusca == cadaNome) 
                {
                    achado = true;
                } 
            }

            // if (achado == true)
            if (achado)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("ACHEI");
                // Console.WriteLine($"Aqui está: {nomes[i]}");

            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("NÃO ACHEI");
            }

            
            // for (var i = 0; i < 10; i++)
            // {
            //     if (nomeBusca == nomes[i]) 
            //     {
            //         achado = true;
            //     } 
            // }
            
            // if (achado) {

            //     Console.ForegroundColor = ConsoleColor.DarkGreen;
            //     Console.WriteLine("ACHEI");
            //     // Console.WriteLine($"Aqui está: {nomes[i]}");

            // } else {  

            //     Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //     Console.WriteLine("NÃO ACHEI");
            //     // Console.WriteLine($"Aqui está: {nomes[i]}");
            // }
        }
    }
}

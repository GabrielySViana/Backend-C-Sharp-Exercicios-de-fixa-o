using System;

namespace Exercício7
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [3];

            Console.WriteLine($"Digite {numeros.Length} números:");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º valor:");
                numeros [i] = int.Parse(Console.ReadLine());
                
            }


            int ct = 0;
            foreach (var item in numeros)
            {
                Console.WriteLine($"Digite o {ct+1}º valor: {item}");
                ct++;
            }

            for (var i = (numeros.Length - 1); i >= 0; i--)
            {
                Console.WriteLine($"Valor: {numeros[i]}");
                
            }
            
            // int c = (numeros.Length - 1);
            // foreach (var item in numeros)
            // {
            //     Console.WriteLine($"Valor: {numeros[c]}");
            //     ct--;
            // }

          
            
            // Array.Reverse(numeros);
             
            //     Console.WriteLine($"Valor: {numeros[numeros.Length]}");
        }
    }
}

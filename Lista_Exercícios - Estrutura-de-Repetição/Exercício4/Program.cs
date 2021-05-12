using System;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] valores = new int [10];

            Console.WriteLine($"Digite {valores.Length} valores");


            for (var i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Digite o {(i+1)}º valor:");
                valores [i] = int.Parse(Console.ReadLine());
                
            }


            int c = 0;
            foreach (var item in valores)
            {
                Console.WriteLine($"{c+1}º valor: {item}");
                c++;
            }
            
   

            Array.Sort(valores);
            Console.WriteLine($"Maior número: {valores[0]}");
            Console.WriteLine($"Menor número: {valores[valores.Length - 1]}");  
        }
    }
}

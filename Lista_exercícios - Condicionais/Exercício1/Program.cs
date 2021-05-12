using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

            Console.WriteLine("Em qual ano você nasceu?");
            int nascimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - nascimento;

            if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Você poderá votar neste ano!");

            }  else if (idade >= 18)
            {
                Console.WriteLine("Você deve votar neste ano!");
            }
            else
            {
                Console.WriteLine("Você não poderá votar neste ano!");
            }
        }
    }
}

using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            int litros;
            bool condicao = false;

            double alcool = 4.90;
            double gasolina = 5.30;

            do
            {
                Console.WriteLine("Qual tipo de combustível você deseja? (A / G)");
                Console.WriteLine("A-álcool | G-gasolina");
                string combustivel = Console.ReadLine().ToLower();
                
                switch (combustivel)
                {
                    case "a":
                        Console.WriteLine("Quantos litros você deseja abastastecer?");
                        litros = int.Parse(Console.ReadLine());

                        if (litros <= 20) {
                            double valorA = (alcool*0.97)*litros;
                            Console.WriteLine($"Você ganhou 3% de desconto! Total a pagar: " + valorA.ToString("C"));

                        }
                        else
                        {
                            double valorA = (alcool*0.95)*litros;
                            Console.WriteLine("Você ganhou 5% de desconto! Total a pagar: " + valorA.ToString("C"));
                        }
                        condicao = true;
                        break;

                    case "g":
                        Console.WriteLine("Quantos litros você deseja abastastecer?");
                        litros = int.Parse(Console.ReadLine());

                        if (litros > 20) {

                            double valorG = (gasolina*0.94)*litros;
                            Console.WriteLine($"Você ganhou 6% de desconto! Total a pagar: " + valorG.ToString("C"));
                            
                        } 
                        else {
                            double valorG = (gasolina*0.96)*litros;
                            Console.WriteLine("Você ganhou 4% de desconto! Total a pagar: " + valorG.ToString("C"));
                        }
                        condicao = true;
                        break;

                    default:
                        Console.WriteLine($"Opção inválida! Tente novamente.");
                        break;
                }
            } while (condicao == false);
        }
    }
}

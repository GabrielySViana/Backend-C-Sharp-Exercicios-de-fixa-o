using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. 
            // Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que: 
            // - Se quantidade <= 5 o desconto será de 2% 
            // - Se quantidade > 5 e quantidade <=10 o desconto será de 3% 
            // - Se quantidade > 10 o desconto será de 5%

            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine().ToLower();
            
            Console.WriteLine($"Digite a quantidade de {nomeProduto}: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o preço unitário de {nomeProduto}: ");
            double precoProduto = double.Parse(Console.ReadLine());

           
            double total = quantidadeProduto * precoProduto;
            Console.WriteLine($"Valor total: {total.ToString("C")}: ");

            if (quantidadeProduto <= 5)
            {
                double valor2 = total*0.98;
                Console.WriteLine($"Você ganhou 2% de desconto! Total a pagar: {valor2.ToString("C")}: ");
                
            } else if (quantidadeProduto > 5 && quantidadeProduto <=10)
            {
                double valor3 = total*0.97;
                Console.WriteLine($"Você ganhou 3% de desconto! Total a pagar: {valor3.ToString("C")}: ");
                
            } else
            {
                double valor5 = total*0.95;
                Console.WriteLine($"Você ganhou 5% de desconto! Total a pagar: {valor5.ToString("C")}: ");
                
            }
            
        }
    }
}

using System;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 1; i <= 10; i++)
          {
            Console.WriteLine($"\nTabuada do {i}");  

              for (var t = 1; t <= 10; t++)
              {
                    Console.WriteLine($"{i} x {t} = {(i*t)}");
              }
          }
        }
    }
}

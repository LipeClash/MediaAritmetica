using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Média Aritmética de 3 números ---");

            Console.WriteLine("Digite o primeiro número:");
            Console.ReadLine();
            Console.WriteLine("Digite o segundo número:");
            Console.ReadLine();
            Console.WriteLine("Digite o terceiro número:");
            Console.ReadLine();
            Console.WriteLine("\n");

            double A = 6;
            double B = 8;
            double C = 10;
            double soma = A + B + C;
            double Media = soma / 3;
             
            Console.WriteLine($"{A} + {B} + {C} = {soma}");

            Console.WriteLine($"{soma} / 3 = {Media}");
            Console.WriteLine("\n");
            Console.WriteLine("MÉDIA 8.0");

        }
    }
}

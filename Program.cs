using System;
using System.Globalization;

namespace provaDeLogica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1.2:
            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            // casas decimais conforme exemplos.
            // Fórmula: area = pi*raio**2
            // pi = 3.14159

            const double pi = 3.14159;
            double raio, area;
            
            Console.WriteLine("Entre com valor do raio da circunferência: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * (raio*raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}

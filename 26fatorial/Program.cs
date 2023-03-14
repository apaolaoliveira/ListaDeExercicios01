using System.Drawing;

namespace _26fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
                 a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
                 b.Pesquise sobre “fatorial”
             */

            Console.Write("Digite o um número de 1 a 31 para descobrir o seu fatorial: ");
            Console.WriteLine();

            int a = int.Parse(Console.ReadLine());

            int resultado = 1;
            Console.Write($"{a}! = ");
           
            for (int i = a; i >= 1; i--)
            {
                resultado *= i;
                Console.Write($"{i}");
                
                if (i > 1)
                {
                    Console.Write(" x ");
                }
            }
            Console.WriteLine($" = {resultado}");
            Console.ReadLine();
        }
    
    }
}
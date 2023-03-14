using System.Runtime.Intrinsics.X86;

namespace _22resultadoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

            Console.Write("Digite o valor A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma de A e B é: {c}");

            Console.ReadLine();
        }
    }
}
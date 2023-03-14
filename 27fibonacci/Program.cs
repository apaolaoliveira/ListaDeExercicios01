namespace _27fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.

            int n1 = 1;
            int n2 = 0;
            int soma;

            Console.Write("Digite um número: ");

            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;

                Console.WriteLine($"A sequência em Fibonacci é: {soma}");

            }
            Console.ReadLine();
        }
    }
}
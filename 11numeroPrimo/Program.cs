namespace _11numeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar se um número é primo.

            double numero;
            double divisores = 0;

            Console.Write("Digite o número para verificar se é primo: ");
            numero = double.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Digite um número inteiro positivo maior que 1.");
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                        divisores++;
                }
                if (divisores == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("É um número primo.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Não é um número primo.");
                }
            }

            Console.ReadKey();
        }
    }
}
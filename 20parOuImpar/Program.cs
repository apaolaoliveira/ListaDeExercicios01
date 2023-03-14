namespace _20parOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

            int num;

            Console.Write("Digite um número qualquer: ");
            num = int.Parse(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            } 
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            Console.ReadKey();
        }
    }
}
namespace _14diasVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
               Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
               de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS. */

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diasDeVida = idade * 365;

            Console.WriteLine();
            Console.WriteLine($"Olá, {nome}! Você já viveu {diasDeVida} dias.");
            Console.ReadKey();
        }
    }
}
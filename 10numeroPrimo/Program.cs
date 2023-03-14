namespace _10calcularMediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a média ponderada de duas provas realizadas por um aluno

            Console.Write("Digite a nota da primeira prova: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");
            float peso1 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            
            Console.Write("Digite a nota da segunda prova: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o peso da segunda prova: ");
            float peso2 = float.Parse(Console.ReadLine());

            float mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine();
            Console.WriteLine($"A média ponderada é: {mediaPonderada:F2}");
            Console.ReadKey();
        }
    }
}
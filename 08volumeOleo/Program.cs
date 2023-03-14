namespace _08volumeOleo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de uma lata de óleo

            Console.Write("Informe a altura da lata (em centímetros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Informe o raio da lata (em centímetros): ");
            double raio = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine();
            Console.WriteLine($"O volume da lata é {volume:F2} centímetros cúbicos.");

            Console.ReadKey();
        }
    }
}
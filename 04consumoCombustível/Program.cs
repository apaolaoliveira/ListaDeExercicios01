namespace _04consumoCombustível
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
             Inicial e Final do Percurso do Veículo, além do Consumo de Combustível */

            Console.Write("Digite a quilometragem inicial do percurso: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final do percurso: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível em litros: ");
            double combustivel = double.Parse(Console.ReadLine());

            double distancia = kmFinal - kmInicial;
            double consumoPorKm = combustivel / distancia;

            Console.WriteLine();
            Console.WriteLine($"O consumo de combustível por km é de {consumoPorKm.ToString("F2")} litros.");
            Console.ReadKey();
        }
    }
}
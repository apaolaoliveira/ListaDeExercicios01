namespace _15conversorTemperatura3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler
              uma temperatura Celsius e imprima em Fahrenheit (pesquise como fazer este tipo de conversão).*/

            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine();
            Console.WriteLine($"A temperatura em Fahrenheit é {fahrenheit:F0}ºF.");
            Console.ReadKey();
        }
    }
}
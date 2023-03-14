namespace _06conversorTerperatura2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converter a temperatura da escala Celsius para a escala Fahrenheit

            double celsius, fahrenheit;

            Console.Write("Informe a temperatura em graus Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit + "°F.");
            Console.ReadKey();
        }
    }
}
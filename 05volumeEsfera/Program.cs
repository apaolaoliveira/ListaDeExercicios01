using System.Globalization;

namespace _05volumeEsfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o volume de uma esfera

            Console.Write("Digite o valor do raio (metade do diâmetro): ");

            double raio = double.Parse(Console.ReadLine());
            double raioCubo = Math.Pow(raio, 3);
            double volume = (4.0 / 3.0) * Math.PI * raioCubo;
            Console.WriteLine();

            Console.WriteLine("Volume = " + volume.ToString("F3"));
            Console.ReadKey();
        }
    }
}
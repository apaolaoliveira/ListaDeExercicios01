namespace volumeCaixaRetangular01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o volume de uma caixa retangular 

            double comprimento, largura, altura, volume;

            Console.WriteLine("Informe os valores abaixo em metros para descobrir o volume da caixa. ");
            Console.WriteLine();

            Console.Write("Comprimento: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Largura: ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine();
            Console.WriteLine($"O volume da caixa é: {volume} metros cúbicos.");
            Console.ReadKey();
        }
    }
}
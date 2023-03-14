namespace _12dimensoesTerreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A imobiliária "Imóbilis" vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
            terreno e depois exibir a área do terreno.*/

            double largura, comprimento, area;
            
            Console.Write("Digite a largura do terreno em metros: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno em metros: ");
            comprimento = double.Parse(Console.ReadLine());

            area = largura * comprimento;

            Console.WriteLine();
            Console.WriteLine("A área do terreno é de " + area + " metros quadrados.");
            Console.ReadKey();
        }
    }
}
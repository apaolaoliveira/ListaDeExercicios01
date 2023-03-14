namespace _03volumeCilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o volume de um Cilindro pela fórmula: V = πr²h

            double raio, altura, volume;

            Console.Write("Informe o raio da base do cilindro em metros: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura do cilindro em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é: {volume:F2} metros cúbicos."); 
            //colocando o :F2 consigo restringir o valor do volume a duas casas decimais
            Console.ReadKey();
        }
    }
}
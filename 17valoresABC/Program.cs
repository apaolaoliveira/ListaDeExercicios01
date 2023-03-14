namespace _17valoresABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

            double A, B, C;

            Console.Write("Digite o valor A: ");
            A = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            B = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            C = Double.Parse(Console.ReadLine());

            double soma = A + B;

            Console.WriteLine();
            if (soma < C)
            {
                Console.WriteLine("A soma de A + B é menor que C");
            } else
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }

            Console.ReadLine();
        }
    }
}
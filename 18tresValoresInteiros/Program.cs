namespace _18tresValoresInteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

            int valor1, valor2, valor3, aux;

            Console.WriteLine("Digite três valores inteiros para serem ordenados de forma crescente.");

            Console.WriteLine();
            Console.Write("Valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.Write("Valor 3: ");
            valor3 = int.Parse(Console.ReadLine());


            if (valor1 > valor2)
            {
                aux = valor1;
                valor1 = valor2;
                valor2 = aux;
            }

            if (valor1 > valor3)
            {
                aux = valor1;
                valor1 = valor3;
                valor3 = aux;
            }

            if (valor2 > valor3)
            {
                aux = valor2;
                valor2 = valor3;
                valor3 = aux;
            }

            Console.WriteLine();
            Console.WriteLine("Valores ordenados: " + valor1 + ", " + valor2 + ", " + valor3 + ".");

            Console.ReadKey();
        }
    }
}
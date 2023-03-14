namespace _16salarioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para ler o salário de um funcionário e aumenta-lo em 15%. Após o aumento, desconte 8% de
               impostos. Imprima o salário inicial, o salário com o aumento e o salário final.*/

            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            double salarioComAumento = salario * 1.15;
            double salarioFinal = salarioComAumento * 0.92;

            Console.WriteLine();
            Console.WriteLine($"Salário inicial: R${salario:F2}");
            Console.WriteLine($"Salário com aumento de 15%: R${salarioComAumento:F2}");
            Console.WriteLine($"Salário final após 8% de impostos descontados: R${salarioFinal:F2}");

            Console.ReadKey();
        }
    }
}
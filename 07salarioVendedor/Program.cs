namespace _07salarioVendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
               vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/

            double salarioBase, totalVendas, comissao, salarioTotal;

            Console.Write("Informe o salário base do vendedor: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Informe a comissão a ser aplicada sobre as vendas (em %): ");
            comissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioBase + (totalVendas * (comissao * salarioBase / 100));

            Console.WriteLine("O salário total do vendedor é: R$ {0:N2}", salarioTotal);
            Console.ReadLine();
        }
    }
}
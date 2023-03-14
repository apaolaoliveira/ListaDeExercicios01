namespace _13paesEBroas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
               pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
               venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
               Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
               quantidades de pães e de broas, e depois calcular os dados solicitados. */

            Console.Write("Digite a quantidade de pães vendidos: ");
            int qtdPao = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas: ");
            int qtdBroa = int.Parse(Console.ReadLine());

            double valorPao = qtdPao * 0.12;
            double valorBroa = qtdBroa * 1.50;
            double totalArrecadado = valorPao + valorBroa;
            double valorPoupanca = totalArrecadado * 0.1;

            Console.WriteLine();

            Console.WriteLine($"Valor arrecadado com a venda de pães e broas: R${totalArrecadado:F2}");
            Console.WriteLine($"Valor a ser guardado na conta de poupança: R${valorPoupanca:F2}");
            Console.ReadKey();
        }
    }
}
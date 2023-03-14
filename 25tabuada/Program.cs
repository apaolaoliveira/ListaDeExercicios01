namespace _25tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N. Mostre a
                tabuada na forma:
                   0 x N = 0
                   1 x N = 1N
                   2 x N = 2N
                        .
                        .
                        .
                  10 x N = 10N
            */

            Console.Write("Digite o número para gerar a tabuada: ");

            int tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultadoMultiplicacao = tabuada * i;

                Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao);
            }
            
            Console.ReadLine();
        }
    }
}
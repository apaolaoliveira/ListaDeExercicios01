namespace _23numerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

            Console.WriteLine("Clique Enter e veja todos os números ímpares entre 100 e 200.");
            Console.ReadLine();

            for (int i = 101; i < 200; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
namespace _19imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação
              sobre a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ².
              Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição.*/
            
            double peso;
            double altura;
            double imc;

            Console.Write("digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("digite sua altura com vírgula: ");
            altura = double.Parse(Console.ReadLine());


            imc = peso / Math.Pow(altura, 2);

            Console.WriteLine();

            if (imc < 18.5)
            {
                Console.Write("você está abaixo do peso.");
            }

            else if (imc >= 18.5 && imc <= 25)
            {
                Console.Write("você está com peso normal.");
            }

            else if (imc > 25 && imc <= 30)
            {
                Console.Write("você está acima do peso.");
            }

            else if (imc > 30)
            {
                Console.Write("você está obeso.");
            }

            Console.ReadKey();
        }
    }
}
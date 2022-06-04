using System;

namespace CaixaVolume
{

    public class VolumeCaixa
    {
        public static void Main(string[] agrs)
        {
            double mediaV, comprimento, largura, altura;

            Console.WriteLine("Insira o Comprimento do Retângulo");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Largura do Retângulo");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o Largura do Retângulo");
            altura = double.Parse(Console.ReadLine());

            mediaV = comprimento * largura * altura;

            //Para inserir o metro cúbico é ALT + 0179
            Console.WriteLine($"O volume do retângulo é: {mediaV}³");
        }
    }
}
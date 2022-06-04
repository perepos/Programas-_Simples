using System;

namespace Conversor
{

    public class Converte
    {
        public static void Main (string[] args)
        {
            double c, media;

            Console.WriteLine("Insira o valor em Celsius que deseja converter: ");

            c = double.Parse(Console.ReadLine());

            media = (c * 9 / 5) + 32;

            Console.WriteLine("Valor convertido: {0}", media);

        }

    }

}

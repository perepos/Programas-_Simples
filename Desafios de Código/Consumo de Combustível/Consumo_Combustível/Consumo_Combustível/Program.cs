using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_Combustível
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double km_rodados, litros;

            Console.WriteLine("Para levarmos em consideração do consumo aproximado\n você precisa" +
                "encher o tanque do seu veículo totalmente e zerar o odômetro, assim \n seremos mais " +
                "precisos quanto o resultado. ");

            Console.WriteLine("========================================================================");
            Console.WriteLine("Insira a distância percorrida: ");
            km_rodados = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o total de liros abastecidos: ");
            litros = double.Parse(Console.ReadLine());

            double media = km_rodados / litros;

            Console.WriteLine(media);

            Console.ReadKey();

        }
    }
}

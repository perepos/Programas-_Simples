using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Metodos
{

    class Entradas
    {
        public static void Login(string login)
        {
            int cont = 0;
            
            //Coloque a quantidade desejada de arrays e atribua seus respectivos valores.
            string[] NomesLogin = new string[4];
            {
                NomesLogin[0] = "Nome1";
                NomesLogin[1] = "Nome2";
                NomesLogin[2] = "Nome3";
                NomesLogin[3] = "Nome4";
            }

            while (login != NomesLogin[0] && login != NomesLogin[1] && login != NomesLogin[2] && login != NomesLogin[3])
            {

                Console.WriteLine("Login Inválido, Tente novamente! ");
                Console.Clear();
                Console.Write("Login: ");
                login = Console.ReadLine();

                if (cont >= 3)
                {
                    Console.WriteLine("Tentativas Excedidas\n Acesso Bloqueado!");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Inicio();
                }

                cont++;
                Console.Clear();
            }
        }

        public static void Senha(int senha)
        {
            //Coloque a quantidade desejada de arrays e atribua seus respectivos valores.
            int[] NomesLogin = new int[4];
            {
                NomesLogin[0] = 0;
                NomesLogin[1] = 0;
                NomesLogin[2] = 0;
                NomesLogin[3] = 0;
            }

            while (senha != NomesLogin[0] && senha != NomesLogin[1] && senha != NomesLogin[2] && senha != NomesLogin[3])
            {
                int cont = 0;
                Console.Write("Senha Inválida, Tente novamente! ");
                Console.Clear();
                Console.WriteLine("Senha: ");

                senha = int.Parse(Console.ReadLine());

                cont++;

                if (cont >= 3)
                {
                    Console.Write("Tentativas Excedidas\n Acesso Bloqueado!");
                    Console.ReadKey();
                    Program.Inicio();
                }

                Console.Clear();
            }
        }
    }

}

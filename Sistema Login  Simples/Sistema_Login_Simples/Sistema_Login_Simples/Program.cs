using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Metodos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.Inicio();
        }

        public static void Inicio()
        {
            Console.WriteLine("Bem Vindo! ");
            Console.WriteLine("Entre com sua conta");

            Console.Write("Login: ");
            string login = Console.ReadLine();

            Entradas.Login(login);

            Console.Write("Senha: ");
            int senha = int.Parse(Console.ReadLine());
            Entradas.Senha(senha);

            Console.WriteLine("Continue abaixo, seu código.");
            Console.ReadKey();
        }
    }
}

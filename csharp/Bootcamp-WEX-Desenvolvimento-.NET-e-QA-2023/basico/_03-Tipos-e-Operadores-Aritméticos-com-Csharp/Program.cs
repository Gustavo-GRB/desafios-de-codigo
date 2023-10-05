using System;

namespace AnaliseDadosTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário a quantidade de testes bem-sucedidos:
            int testesBemSucedidos = int.Parse(Console.ReadLine());

            // Solicita ao usuário a quantidade de testes totais:
            int testesTotais = int.Parse(Console.ReadLine());

            double taxaSucesso = (double)testesBemSucedidos / testesTotais;

            if (taxaSucesso >= 0.8)
            {
                Console.WriteLine("A funcionalidade esta pronta para lancamento.");
            }
            else
                Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");

        }
    }
}
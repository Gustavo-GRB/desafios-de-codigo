using System;

namespace SimulacaoFalhaTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite o nome do teste: ");
            string nomeTeste = Console.ReadLine();

            //Console.WriteLine("Digite a descrição do erro: ");
            string descricaoDoErro = Console.ReadLine();

            // Se o teste falhar, exibe a descrição do erro:
            Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");
        }
    }
}
using Fundamentos.Variaveis.Parametro;
using System;

namespace Fundamentos.Executar
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemplificacaoParametro exemplificacao = new ExemplificacaoParametro();
            
            Console.WriteLine("PassagemPorValor:");
            exemplificacao.ExibirValoresPorValor();

            Console.WriteLine("PassagemPorReferencia:");
            exemplificacao.ExibirValoresPorReferencia();
        }
    }
}
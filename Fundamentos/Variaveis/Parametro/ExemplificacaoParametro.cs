using System;

namespace Fundamentos.Variaveis.Parametro
{
    public class ExemplificacaoParametro
    {
        public void ExibirValoresPorReferencia()
        {
            int numero = 10;
            TrocaValoresPorReferencia(ref numero);
            Console.WriteLine(numero);
        }
        public static void TrocaValoresPorReferencia(ref int numeroParametro) 
        {
            numeroParametro = 100;
        }
        public void ExibirValoresPorValor()
        {
            int numero = 10;
            TrocaValoresPorValor(numero);
            Console.WriteLine(numero);
        }
        public static void TrocaValoresPorValor (int numeroParametro)
        {
            numeroParametro = 100;
        }
    }
}
using System;
using BenchmarkDotNet.Running;

namespace Simple.Brazilian.Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo !");

            //for (int i = 0; i < 100000; i++)
            //{
            //    var a = new Desempenho.AnalisaRemocaoAcentos();
            //    a.RemoveAcentosTextoLongoB();
            //}

            BenchmarkRunner.Run<Desempenho.AnalisaRemocaoAcentos>();
        }
    }
}

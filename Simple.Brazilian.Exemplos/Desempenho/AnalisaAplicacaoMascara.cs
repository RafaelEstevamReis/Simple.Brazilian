using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Brazilian.Exemplos.Desempenho
{
    [MemoryDiagnoser]
    public class AnalisaAplicacaoMascara
    {
        string[] mascaras = {
            "(__) _.____-____",
            "___.___.___-__",
            "__.___.___/____-__",
            "#__.__.__-___/__",
            "#__.__.__-___/__"
        };
        string[] textos = {
            "11912345678",
            "12345678901",
            "12345678000190",
            "1234567",
            "12345678901"
        };

        [Benchmark]
        public void AplicaMascarasA()
        {
            for (int i = 0; i < mascaras.Length; i++)
            {
                Formatters.Text.AplicaMascara(textos[i], mascaras[i]);
            }
        }

        //[Benchmark]
        //public void AplicaMascarasB()
        //{
        //    for (int i = 0; i < mascaras.Length; i++)
        //    {
        //        Formatters.Text.AplicaMascaraB(textos[i], mascaras[i]);
        //    }
        //}
    }
}

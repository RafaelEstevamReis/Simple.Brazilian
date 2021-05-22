using BenchmarkDotNet.Attributes;

namespace Simple.Brazilian.Exemplos.Desempenho
{
    [MemoryDiagnoser]
    public class AnalisaRemocaoAcentos
    {
        [Benchmark]
        public void RemoveAcentosTextoLongoA() => Formatters.Texto.RemoveAcentos(Externos.acentos_wikipedia_original, Formatters.OpcoesTexto.Padrao);
    }
}

using BenchmarkDotNet.Attributes;

namespace Simple.Brazilian.Exemplos.Desempenho
{
    [MemoryDiagnoser]
    public class AnalisaRemocaoAcentos
    {
        [Benchmark]
        public void RemoveAcentosTextoLongoA() => Formatters.Text.RemoveAccents(Externos.acentos_wikipedia_original, Formatters.TextOptions.Padrao);
    }
}

using BenchmarkDotNet.Attributes;

namespace Simple.Brazilian.Exemplos.Desempenho
{
    [MemoryDiagnoser]
    public class AnalisaRemocaoAcentos
    {
        [Benchmark]
        public void RemoveAcentosTextoLongoA() => Formatadores.Texto.RemoveAcentos(Externos.acentos_wikipedia_original, Formatadores.OpcoesTexto.Padrao);
    }
}

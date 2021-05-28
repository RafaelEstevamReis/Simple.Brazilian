using BenchmarkDotNet.Attributes;
using Simple.Brazilian.Documents;

namespace Simple.Brazilian.Exemplos.Desempenho
{
    [MemoryDiagnoser]
    public class AnalisaValidacaoDocumentos
    {
        string cpf = "00000000000";
        //string cpf = "79561606003";

        [Benchmark]
        public void ValidaCPF_A() => CPF.IsValid(cpf);
        //[Benchmark]
        //public void ValidaCPF_B() => CPF.IsValid_Original(cpf);
    }
}

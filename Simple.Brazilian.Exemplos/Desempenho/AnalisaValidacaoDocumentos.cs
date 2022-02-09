using BenchmarkDotNet.Attributes;

namespace Simple.Brazilian.Exemplos.Desempenho
{
    [MemoryDiagnoser]
    public class AnalisaValidacaoDocumentos
    {
        string cpf = "00000000000";
        string cnpj = "11444777000161";

        //[Benchmark]
        //public void ValidaCPF_A() => CPF.IsValid(cpf);
        //[Benchmark]
        //public void ValidaCPF_B() => CPF.IsValid_Original(cpf);


        //[Benchmark]
        //public void ValidaCNPJ_A() => CNPJ.IsValid(cnpj);
        //[Benchmark]
        //public void ValidaCNPJ_B() => CNPJ.IsValid_ORG(cnpj);
    }
}

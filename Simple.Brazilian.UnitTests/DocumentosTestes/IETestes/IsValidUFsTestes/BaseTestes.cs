using Simple.Brazilian.Documents;
using Simple.Brazilian.Information.Places;
using System;
using System.Collections.Generic;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.IETestes.IsValidUFsTestes
{
    public class BaseTestes
    {
        private static IEnumerable<T> EnumerateEnum<T>()
                  where T : Enum
        {
            foreach (var v in Enum.GetValues(typeof(T)))
            {
                yield return (T)v;
            }
        }

        // http://www.sintegra.gov.br/insc_est.html

        [Fact]
        public void IE_IsValid_Geral()
        {
            // Vazio e NULL são exceções
            Assert.False(IE.IsValid(null, UFs.SP));
            Assert.False(IE.IsValid("", UFs.SP));

            // SHARP
            Assert.True(IE.IsValid("513.110.286.112", UFs.SP));

            // IEs que falharam

            // Vazio não deve aceitar em nenhum UF
            foreach (UFs uf in EnumerateEnum<UFs>())
            {
                // Zeros são completados, e o acre aceita 13 zeros
                // Então o "vazio", tem um número para 'contaminar'
                Assert.False(IE.IsValid("100", uf));
            }
            // Texto não deve aceitar em nenhum UF
            foreach (UFs uf in EnumerateEnum<UFs>())
            {
                Assert.False(IE.IsValid("00A0000B", uf));
                Assert.False(IE.IsValid("00A00000B", uf));
                Assert.False(IE.IsValid("00A000000B", uf));
                Assert.False(IE.IsValid("00A0000000B", uf));
                Assert.False(IE.IsValid("00A00000000B", uf));
                Assert.False(IE.IsValid("00A000000000B", uf));
            }
        }
    }
}

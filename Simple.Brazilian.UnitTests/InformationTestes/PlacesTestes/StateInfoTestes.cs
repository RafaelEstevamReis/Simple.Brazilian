using Simple.Brazilian.Information.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Simple.Brazilian.UnitTests.InformationTestes.PlacesTestes
{
    public class StateInfoTestes
    {
        [Theory]
        [InlineData("Acre", "AC", "Rio Branco", 164_122.2)]
        [InlineData("Alagoas", "AL", "Maceió", 27_767.7)]
        [InlineData("Amapá", "AP", "Macapá", 142_814.6)]
        [InlineData("Amazonas", "AM", "Manaus", 1_570_745.7)]
        [InlineData("Bahia", "BA", "Salvador", 564_692.7)]
        [InlineData("Ceará", "CE", "Fortaleza", 148_825.6)]
        [InlineData("Distrito Federal", "DF", "Brasília", 5_822.1)]
        [InlineData("Espírito Santo", "ES", "Vitória", 46_077.5)]
        [InlineData("Goiás", "GO", "Goiânia", 340_086.7)]
        [InlineData("Maranhão", "MA", "São Luís", 331_983.3)]
        [InlineData("Mato Grosso", "MT", "Cuiabá", 903_357.9)]
        [InlineData("Mato Grosso do Sul", "MS", "Campo Grande", 357_125.0)]
        [InlineData("Minas Gerais", "MG", "Belo Horizonte", 586_528.3)]
        [InlineData("Pará", "PA", "Belém", 1_247_689.5)]
        [InlineData("Paraíba", "PB", "João Pessoa", 56_439.8)]
        [InlineData("Paraná", "PR", "Curitiba", 199_314.9)]
        [InlineData("Pernambuco", "PE", "Recife", 98_311.6)]
        [InlineData("Piauí", "PI", "Teresina", 251_529.2)]
        [InlineData("Rio de Janeiro", "RJ", "Rio de Janeiro", 43_696.1)]
        [InlineData("Rio Grande do Norte", "RN", "Natal", 52_796.8)]
        [InlineData("Rio Grande do Sul", "RS", "Porto Alegre", 281_748.5)]
        [InlineData("Rondônia", "RO", "Porto Velho", 237_576.2)]
        [InlineData("Roraima", "RR", "Boa Vista", 224_299.0)]
        [InlineData("Santa Catarina", "SC", "Florianópolis", 95_346.2)]
        [InlineData("São Paulo", "SP", "São Paulo", 248_209.4)]
        [InlineData("Sergipe", "SE", "Aracaju", 21_910.3)]
        [InlineData("Tocantins", "TO", "Palmas", 277_620.9)]
        public void StateInfo_FromWikipedia(string estado, string uf, string capital, double area)
        {
            // https://pt.wikipedia.org/wiki/Unidades_federativas_do_Brasil
            var dados = States.GetStateInfoByUF(uf);

            Assert.Equal(uf, dados.UF);
            Assert.Equal(estado, dados.Name);
            Assert.Equal(capital, dados.Capital);
            Assert.Equal(area, dados.AreaKm2);
        }
        [Fact]
        public void StateInfo_AlinhamentoArrays()
        {
            for (int i = 0; i < 27; i++)
            {
                var uf = States.UF[i];

                var dados = States.GetStateInfoByUF(uf);

                Assert.Equal(uf, dados.UF);
                Assert.Equal(States.IdIBGE[i], dados.IdIBGE);
            }
        }

        [Fact]
        public void StateInfo_CapitalListaCidades()
        {
            for (int i = 0; i < 27; i++)
            {
                var dados = States.GetStateInfoByUF(States.UF[i]);

                Assert.Contains(dados.Capital, dados.CityInfo.Select(o => o.Name));
            }
        }

        [Theory]
        [InlineData("AC", 22)]
        [InlineData("AL", 102)]
        [InlineData("AP", 16)]
        [InlineData("AM", 62)]
        [InlineData("BA", 417)]
        [InlineData("CE", 184)]
        [InlineData("DF", 1)]
        [InlineData("ES", 78)]
        [InlineData("GO", 246)]
        [InlineData("MA", 217)]
        [InlineData("MT", 141)]
        [InlineData("MS", 79)]
        [InlineData("MG", 853)]
        [InlineData("PA", 144)]
        [InlineData("PB", 223)]
        [InlineData("PR", 399)]
        [InlineData("PE", 185)]
        [InlineData("PI", 224)]
        [InlineData("RJ", 92)]
        [InlineData("RN", 167)]
        [InlineData("RS", 497)]
        [InlineData("RO", 52)]
        [InlineData("RR", 15)]
        [InlineData("SC", 295)]
        [InlineData("SP", 645)]
        [InlineData("SE", 75)]
        [InlineData("TO", 139)]
        public void StateInfo_ContagemCidades(string uf, int cidades)
        {
            var dados = States.GetStateInfoByUF(uf);
            Assert.Equal(cidades, dados.CityInfo.Length);
        }

    }
}

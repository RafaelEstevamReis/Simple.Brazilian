using Simple.Brazilian.Documents;
using Simple.Brazilian.Information.Places;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.IETestes.IsValidUFsTestes
{
    public class UFTestes
    {

        [Fact]
        public void IE_IsValid_AC()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("01.004.823/001-12", UFs.AC));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("01.924.949/332-30", UFs.AC));
            Assert.True(IE.IsValid("01.987.171/241-66", UFs.AC));
            Assert.True(IE.IsValid("01.903.900/094-09", UFs.AC));
            Assert.True(IE.IsValid("01.337.376/046-06", UFs.AC));
            Assert.True(IE.IsValid("01.993.035/018-00", UFs.AC));
            // Sem o Zero
            Assert.True(IE.IsValid("1.993.035/018-00", UFs.AC));
        }
        [Fact]
        public void IE_IsValid_AL()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("240000048", UFs.AL));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("248770241", UFs.AL));
            Assert.True(IE.IsValid("248109952", UFs.AL));
            Assert.True(IE.IsValid("248436635", UFs.AL));
            Assert.True(IE.IsValid("248020188", UFs.AL));
            Assert.True(IE.IsValid("248005820", UFs.AL));

            Assert.False(IE.IsValid("24800A820", UFs.AL));
        }
        [Fact]
        public void IE_IsValid_AP()
        {
            // Exemplo sintegra: 03.012.345-9 - o Site está ERRADO, a soma não é 79, é 74
            // Segundo o site: (9 x 0) + (8 x 3) + (7 x 0) + (6 x 1) + (5 x 2) + (4 x 3) + (3 x 4) + (2 x 5) = 79
            Assert.True(IE.IsValid("030123453", UFs.AP));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("031359507", UFs.AP));
            Assert.True(IE.IsValid("034560289", UFs.AP));

            // Um monte de exemplos pois essas regras são desnecessariamente complicadas
            Assert.True(IE.IsValid("038437244", UFs.AP));
            Assert.True(IE.IsValid("032576897", UFs.AP));
            Assert.True(IE.IsValid("038220512", UFs.AP));
            Assert.True(IE.IsValid("038609835", UFs.AP));
            Assert.True(IE.IsValid("030524784", UFs.AP));
            Assert.True(IE.IsValid("032207727", UFs.AP));
            Assert.True(IE.IsValid("032968744", UFs.AP));
            Assert.True(IE.IsValid("039254160", UFs.AP));
            Assert.True(IE.IsValid("030500567", UFs.AP));
            Assert.True(IE.IsValid("035302828", UFs.AP));
            Assert.True(IE.IsValid("033973768", UFs.AP));
            Assert.True(IE.IsValid("035808918", UFs.AP));
            Assert.True(IE.IsValid("038923530", UFs.AP));
            Assert.True(IE.IsValid("038761190", UFs.AP));

            Assert.False(IE.IsValid("038761A90", UFs.AP));

            // Sem o Zero
            Assert.True(IE.IsValid("38761190", UFs.AP));
        }
        [Fact]
        public void IE_IsValid_AM()
        {
            // Sintegra não tem exemplo
            // Exemplos da internet
            //   # Moto Honda
            Assert.True(IE.IsValid("07.000.220-7", UFs.AM));
            Assert.True(IE.IsValid("06.200.256-2", UFs.AM));
            Assert.True(IE.IsValid("04.156.817-6", UFs.AM));
            Assert.True(IE.IsValid("04.153.370-4", UFs.AM));
            //   # Nokia
            Assert.True(IE.IsValid("04.135.646-2", UFs.AM));
            Assert.True(IE.IsValid("06.200.267-8", UFs.AM));
            Assert.True(IE.IsValid("07.000.848-5", UFs.AM));
            //   # LG
            Assert.True(IE.IsValid("06.300.694-4", UFs.AM));
            Assert.True(IE.IsValid("06.200.685-1", UFs.AM));

            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("04.599.714-4", UFs.AM));
            Assert.True(IE.IsValid("34.642.294-9", UFs.AM));

            // Sem o zero
            Assert.True(IE.IsValid("4.599.714-4", UFs.AM));
        }
        [Fact]
        public void IE_IsValid_BA()
        {
            // Exemplos Sintegra
            // 8D Mod 10
            Assert.True(IE.IsValid("123456-63", UFs.BA));
            // 8D Mod 10
            Assert.True(IE.IsValid("612345-57", UFs.BA));
            // 9D Mod 10
            Assert.True(IE.IsValid("1000003-06", UFs.BA));
            // 9D Mod 11 => Não tem exemplo


            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            // RND com 8 MOD 10
            Assert.True(IE.IsValid("080063-58", UFs.BA));
            Assert.True(IE.IsValid("404453-55", UFs.BA));
            Assert.True(IE.IsValid("805386-91", UFs.BA));
            Assert.True(IE.IsValid("020200-60", UFs.BA));
            // RND com 8 MOD 11
            Assert.True(IE.IsValid("776596-87", UFs.BA));
            Assert.True(IE.IsValid("910156-00", UFs.BA));
            Assert.True(IE.IsValid("612.733.29", UFs.BA));
            // RND com 9 MOD 10
            // ?
            // RND com 9 MOD 11
            // ?

            // Outros
            Assert.True(IE.IsValid("031.112.264", UFs.BA));
            Assert.True(IE.IsValid("273.854.609", UFs.BA));
            Assert.True(IE.IsValid("063.180.808", UFs.BA));
            Assert.True(IE.IsValid("063.595.400", UFs.BA));
            Assert.True(IE.IsValid("076.813.702", UFs.BA));

            Assert.True(IE.IsValid("001.027.389", UFs.BA));
            Assert.True(IE.IsValid("026.641.885", UFs.BA));
            Assert.True(IE.IsValid("000.478.696", UFs.BA));
            Assert.True(IE.IsValid("004.539.298", UFs.BA));
            Assert.True(IE.IsValid("001.764.543", UFs.BA));
            Assert.True(IE.IsValid("000.608.880", UFs.BA));
            Assert.True(IE.IsValid("001.661.097", UFs.BA));
            Assert.True(IE.IsValid("000.665.571", UFs.BA));
            Assert.True(IE.IsValid("030.262.313", UFs.BA));
            Assert.True(IE.IsValid("006.235.527", UFs.BA));
            Assert.True(IE.IsValid("001.745.616", UFs.BA));
            Assert.True(IE.IsValid("009.871.889", UFs.BA));
            // Sem o zero
            Assert.True(IE.IsValid("09.871.889", UFs.BA));
        }
        [Fact]
        public void IE_IsValid_CE()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("060000015", UFs.CE));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("37241644-6", UFs.CE));
            Assert.True(IE.IsValid("14422067-9", UFs.CE));
            // Sem o zero
            Assert.True(IE.IsValid("60000015", UFs.CE));
        }
        [Fact]
        public void IE_IsValid_DF()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("073.00001.001-09", UFs.DF));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("07096293001-76", UFs.DF));
            Assert.True(IE.IsValid("07485863001-38", UFs.DF));

            Assert.False(IE.IsValid("0748586300B-38", UFs.DF));
            // Sem o zero
            Assert.True(IE.IsValid("7485863001-38", UFs.DF));
        }
        [Fact]
        public void IE_IsValid_ES()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("99999999-0", UFs.ES));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("75846082-1", UFs.ES));
            Assert.True(IE.IsValid("41036767-2", UFs.ES));
        }
        [Fact]
        public void IE_IsValid_GO()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("10.987.654-7", UFs.GO));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("10.792.054-9", UFs.GO));
            Assert.True(IE.IsValid("11.116.336-6", UFs.GO));

            // Mais exemplos pois a IE tem uma regra cheia de exceções
            Assert.True(IE.IsValid("10.021.500-9", UFs.GO));
            Assert.True(IE.IsValid("11.988.879-3", UFs.GO));
            Assert.True(IE.IsValid("11.606.756-0", UFs.GO));
            Assert.True(IE.IsValid("11.209.268-3", UFs.GO));
            Assert.True(IE.IsValid("10.093.194-4", UFs.GO));
            Assert.True(IE.IsValid("10.710.861-5", UFs.GO));
            Assert.True(IE.IsValid("11.209.740-5", UFs.GO));
            Assert.True(IE.IsValid("15.364.631-4", UFs.GO));
            Assert.True(IE.IsValid("11.456.209-1", UFs.GO));
            Assert.True(IE.IsValid("10.228.265-0", UFs.GO));
            Assert.True(IE.IsValid("15.318.106-0", UFs.GO));
            Assert.True(IE.IsValid("10.526.010-0", UFs.GO));
            Assert.True(IE.IsValid("10.153.283-0", UFs.GO));
            Assert.True(IE.IsValid("10.112.605-0", UFs.GO));

            Assert.True(IE.IsValid("15.015.458-5", UFs.GO));
            Assert.True(IE.IsValid("11.050.909-9", UFs.GO));
            Assert.True(IE.IsValid("15.066.530-0", UFs.GO));
            Assert.True(IE.IsValid("11.658.588-9", UFs.GO));
            Assert.True(IE.IsValid("10.057.108-5", UFs.GO));
            Assert.True(IE.IsValid("10.011.230-7", UFs.GO));
            Assert.True(IE.IsValid("10.008.585-7", UFs.GO));
            Assert.True(IE.IsValid("10.020.925-4", UFs.GO));
            Assert.True(IE.IsValid("15.000.657-8", UFs.GO));

            foreach (var ie in new string[] {"103010068", "100549365", "102082073",
                                             "100395961", "104329211", "103472517",
                                             "101126689", "103598685", "103598510",
                                             "102959579", "103014306", "105256030",
                                             "104787910", "105.14336-7"})
            {
                Assert.True(IE.IsValid(ie, UFs.GO));
            }

            // Este código errado passa ¬¬'
            Assert.False(IE.IsValid("15.000.A67-8", UFs.GO));

            // !! 2 casos não foram verificados pois não foram encontrados exemplos
            //   1. IE no intervalo [10103105 .. 10119997] inclusives
            //   2. "11094402"-0 e "11094402"-1
        }
        [Fact]
        public void IE_IsValid_MA()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("120000385", UFs.MA));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("12200609-7", UFs.MA));
            Assert.True(IE.IsValid("12034436-0", UFs.MA));
            Assert.True(IE.IsValid("1203443A-0", UFs.MA));
        }
        [Fact]
        public void IE_IsValid_MT()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("0013000001-9", UFs.MT));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("4443939274-0", UFs.MT));
            Assert.True(IE.IsValid("6049525229-1", UFs.MT));
            // Ocorreu erro de validação em cliente
            // Apesar do sintegra exigir 11 caracteres na validação, o site de consulta
            //  exibe sem zeros à esquerda, induzindo o operar a digitar sem
            Assert.True(IE.IsValid("13.760.531-5", UFs.MT));

            // Sem o zero
            Assert.True(IE.IsValid("013000001-9", UFs.MT));
        }
        [Fact]
        public void IE_IsValid_MS()
        {
            // Não tem exemplo no sintegra

            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("28294317-0", UFs.MS));
            Assert.True(IE.IsValid("28300088-0", UFs.MS));

            // Mais exemplos pois o Sintegra não tem exemplos
            foreach (var ie in new string[]{"282757961", "283278277", "283240784",
                                           "283380098", "283254130", "283231033",
                                           "283190817", "283531932", "283278455",
                                           "283571810", "283420049", "283522445",
                                           "283169109", "283641886", "283525118",
                                           "283304626"})
            {
                Assert.True(IE.IsValid(ie, UFs.MS));
            }

            Assert.False(IE.IsValid("2830008A-0", UFs.MS));
        }
        [Fact]
        public void IE_IsValid_MG()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("062.307.904/0081", UFs.MG));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("884.451.565/7678", UFs.MG));
            Assert.True(IE.IsValid("636.729.608/8387", UFs.MG));
            Assert.True(IE.IsValid("0620807250006", UFs.MG));

            foreach (var ie in new string[] {"0629566160029", "1940518120024", "7023259570005",
                                             "0627754310057", "7028774230051", "4397785510036",
                                             "00181926300-48", "7.042.464.220.176", "7072973200009",
                                             "1861400080005", "0013549440006", "2719187320012",
                                             "4811796120477", "0742720420040", "4793672720387",
                                             "0013549440189", "0013549440260", "0013549440340",
                                             "0162973200227", "7041777990034", "4701777990218",
                                             "0931777990444", "7.042.464.220.095", "4331400080278",
                                             "4801796120060", "4488821860002", "0625419930071",
                                             "0010374220026", "0620822140038", "0623110040017" })
            {
                Assert.True(IE.IsValid(ie, UFs.MG));
            }

            // Sem o zero
            Assert.True(IE.IsValid("620807250006", UFs.MG));
        }
        [Fact]
        public void IE_IsValid_PA()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("15-999999-5", UFs.PA));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("15-548390-0", UFs.PA));
            Assert.True(IE.IsValid("15-969737-9", UFs.PA));
            Assert.False(IE.IsValid("15-96973A-9", UFs.PA));
        }
        [Fact]
        public void IE_IsValid_PB()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("06000001-5", UFs.PB));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("11085251-6", UFs.PB));
            Assert.True(IE.IsValid("23361943-7", UFs.PB));

            // Sem o zero
            Assert.True(IE.IsValid("6000001-5", UFs.PB));
        }
        [Fact]
        public void IE_IsValid_PR()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("12345678-50", UFs.PR));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("574.48445-60", UFs.PR));
            Assert.True(IE.IsValid("845.51096-21", UFs.PR));
        }
        [Fact]
        public void IE_IsValid_PE()
        {
            // Exemplo sintegra novo
            Assert.True(IE.IsValid("0321418-40", UFs.PE));
            // Exemplo sintegra antigo
            Assert.True(IE.IsValid("18.1.001.0000004-9", UFs.PE));

            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("3691040-64", UFs.PE));
            Assert.True(IE.IsValid("1590348-68", UFs.PE));

            // Sem o zero
            //Assert.True(IE.IsValid("321418-40", UFs.PE));
            // Este UF não deve validar sem o zero, o comprimento muda o tipo de cálculo
        }
        [Fact]
        public void IE_IsValid_PI()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("012345679", UFs.PI));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("67721703-0", UFs.PI));
            Assert.True(IE.IsValid("05096031-8", UFs.PI));

            // Sem o zero
            Assert.True(IE.IsValid("5096031-8", UFs.PI));
        }
        [Fact]
        public void IE_IsValid_RJ()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("99.999.99-3", UFs.RJ));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("21.313.58-0", UFs.RJ));
            Assert.True(IE.IsValid("36.253.99-1", UFs.RJ));
        }
        [Fact]
        public void IE_IsValid_RN()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("20.040.040-1", UFs.RN));
            Assert.True(IE.IsValid("20.0.040.040-0", UFs.RN));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("20.966.787-7", UFs.RN));
            Assert.True(IE.IsValid("20.022.952-4", UFs.RN));
            // Estou preocupado com a soma*10, vou colocar testes adicionais
            Assert.True(IE.IsValid("20.353.218-0", UFs.RN));
            Assert.True(IE.IsValid("20.907.990-8", UFs.RN));
            Assert.True(IE.IsValid("20.825.624-5", UFs.RN));
            Assert.False(IE.IsValid("20.825.62A-5", UFs.RN));

        }
        [Fact]
        public void IE_IsValid_RS()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("2243658792", UFs.RS));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("784/4832038", UFs.RS));
            Assert.True(IE.IsValid("774/6046178", UFs.RS));
        }
        [Fact]
        public void IE_IsValid_RO()
        {
            // Tem a fórmula de antes de AGO/2000 
            Assert.True(IE.IsValid("101.62521-3", UFs.RO));
            // E a de depois
            Assert.True(IE.IsValid("0000000062521-3", UFs.RO));

            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("6735760712226-7", UFs.RO));
            Assert.True(IE.IsValid("7227711383970-1", UFs.RO));
            Assert.True(IE.IsValid("8803051978896-8", UFs.RO));
            Assert.True(IE.IsValid("5373881389504-0", UFs.RO));
            Assert.True(IE.IsValid("7053022719008-0", UFs.RO));

            // Sem o zero
            //Assert.True(IE.IsValid("62521-3", UFs.RO));
            // Este UF não deve validar sem o zero, o comprimento muda o tipo de cálculo
        }
        [Fact]
        public void IE_IsValid_RR()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("240061536", UFs.RR));
            foreach (var ie in new string[] {"24006628-1","24001755-6","24003429-0",
                                             "24001360-3","24008266-8","24006153-6",
                                             "24007356-2","24005467-4","24004145-5",
                                             "24001340-7"})
            {
                Assert.True(IE.IsValid(ie, UFs.RR));
            }

            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("24563429-3", UFs.RR));
            Assert.True(IE.IsValid("24154775-4", UFs.RR));
            Assert.False(IE.IsValid("2415477A-4", UFs.RR));
        }
        [Fact]
        public void IE_IsValid_SC()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("251.040.852", UFs.SC));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("344.816.451", UFs.SC));
            Assert.True(IE.IsValid("705.198.260", UFs.SC));
        }
        [Fact]
        public void IE_IsValid_SP()
        {
            // http://www.sintegra.gov.br/Cad_Estados/cad_SP.html
            // Exemplo sintegra
            Assert.True(IE.IsValid("110.042.490.114", UFs.SP));
            Assert.True(IE.IsValid("P-01100424.3/002", UFs.SP));
            Assert.True(IE.IsValid("p-01100424.3/002", UFs.SP));

            // SHARP
            Assert.True(IE.IsValid("513.110.286.112", UFs.SP));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("292.912.778.799", UFs.SP));
            Assert.True(IE.IsValid("146.453.240.956", UFs.SP));
            Assert.True(IE.IsValid("265.439.737.165", UFs.SP));
        }
        [Fact]
        public void IE_IsValid_SE()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("27123456-3", UFs.SE));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("90572556-5", UFs.SE));
            Assert.True(IE.IsValid("52592069-2", UFs.SE));
        }
        [Fact]
        public void IE_IsValid_TO()
        {
            // Exemplo sintegra
            Assert.True(IE.IsValid("29.01.022783-6", UFs.TO));
            // Gerador Randômico https://www.4devs.com.br/gerador_de_inscricao_estadual
            Assert.True(IE.IsValid("6503977694-4", UFs.TO));
            Assert.True(IE.IsValid("6503977694-4", UFs.TO));
            Assert.True(IE.IsValid("7903255900-2", UFs.TO));
            Assert.True(IE.IsValid("7903255900-2", UFs.TO));
            Assert.True(IE.IsValid("6003786664-0", UFs.TO));
        }
    }
}

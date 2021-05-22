using Simple.Brazilian.Formatters;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormatedoresTestes.TextoTestes
{
    public class RemoverAcentosTestes
    {
        /// <summary>
        /// Certifica que entrada NULL, retorna NULL
        /// </summary>
        [Fact]
        public void Texto_RemoveAcentos_CertificaNullRetornaNull()
        {
            Assert.Null(Texto.RemoveAcentos(null, null));
        }
        /// <summary>
        /// Certifica que entrada Vazio, retorna Vazio
        /// </summary>
        [Fact]
        public void Texto_RemoveAcentos_CertificaVazioRetornaVazio()
        {
            Assert.Equal(string.Empty, Texto.RemoveAcentos(string.Empty, null));
        }

        /// <summary>
        /// Certifica que números não são alterados
        /// </summary>
        [Fact]
        public void Texto_RemoveAcentos_CertificaNumerosRetornaNumeros()
        {
            // Números do teclado ABNT2
            string testeEntrada = "1234567890";
            Assert.Equal(testeEntrada, Texto.RemoveAcentos(testeEntrada, null));
        }
        /// <summary>
        /// Certifica que letras não são alteradas
        /// </summary>
        [Fact]
        public void Texto_RemoveAcentos_CertificaLetrasRetornaLetras()
        {
            // Letras do teclado ABNT2
            string testeEntrada = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            Assert.Equal(testeEntrada, Texto.RemoveAcentos(testeEntrada, null));
        }
        [Fact]
        public void Texto_RemoveAcentos_ExemploTexto()
        {
            string textoWikipedia =
@"Brasil, oficialmente República Federativa do Brasil, é o maior país da América do Sul e da região da América Latina, 
sendo o quinto maior do mundo em área territorial (equivalente a 47,3% do território sul-americano) e sexto em população (com mais de 210 milhões de habitantes). 
É o único país na América onde se fala majoritariamente a língua portuguesa e o maior país lusófono do planeta, 
além de ser uma das nações mais multiculturais e etnicamente diversas, em decorrência da forte imigração oriunda de variados locais do mundo. 
Sua atual Constituição, promulgada em 1988, concebe o Brasil como uma república federativa presidencialista, formada pela união dos 26 estados, 
do Distrito Federal e dos 5.570 municípios";
            // Acentos removidos manualmente
            string textoSemAcentos =
@"Brasil, oficialmente Republica Federativa do Brasil, e o maior pais da America do Sul e da regiao da America Latina, 
sendo o quinto maior do mundo em area territorial (equivalente a 47,3% do territorio sul-americano) e sexto em populacao (com mais de 210 milhoes de habitantes). 
E o unico pais na America onde se fala majoritariamente a lingua portuguesa e o maior pais lusofono do planeta, 
alem de ser uma das nacoes mais multiculturais e etnicamente diversas, em decorrencia da forte imigracao oriunda de variados locais do mundo. 
Sua atual Constituicao, promulgada em 1988, concebe o Brasil como uma republica federativa presidencialista, formada pela uniao dos 26 estados, 
do Distrito Federal e dos 5.570 municipios";

            Assert.Equal(textoSemAcentos, Texto.RemoveAcentos(textoWikipedia, null));
        }

        [Fact]
        public void Texto_RemovedorAcentos_TexteExterno()
        {
            // áéíóúýÁÉÍÓÚÝàèìòùÀÈÌÒÙâêîôûÂÊÎÔÛãéíõúñÃÉÍÕÚÑäëïöüÿÄËÏÖÜªº°¹²³åÅ
            // Ao procurar por "removedor de acentos" muitos utilizam este par:
            string com = "áéíóúýÁÉÍÓÚÝàèìòùÀÈÌÒÙãõñäëïöüÿÄËÏÖÜÃÕÑâêîôûÂÊÎÔÛçÇ¹²³åÅ";
            string sem = "aeiouyAEIOUYaeiouAEIOUaonaeiouyAEIOUAONaeiouAEIOUcC123aA";
            // Vou utilizar para ter uma fonte externa de teste

            Assert.Equal(sem, Texto.RemoveAcentos(com, null));
        }

        [Fact]
        public void Texto_RemovedorAcentos_TexteWikipediaCompleto()
        {
            var opcoes = new OpcoesTexto()
            {
                CaracterPadraoSubstituicao = '?'
            };
            Assert.Equal(Exemplos.Externos.acentos_wikipedia_semAcentos, Texto.RemoveAcentos(Exemplos.Externos.acentos_wikipedia_original, opcoes));
        }
    }
}

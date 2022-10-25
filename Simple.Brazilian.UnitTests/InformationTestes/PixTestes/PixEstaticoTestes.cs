using Simple.Brazilian.Information;
using Xunit;

namespace Simple.Brazilian.UnitTests.InformationTestes.PixTestes
{
    public class PixEstaticoTestes
    {
        [Fact]
        public void TestaPix_ExemploDocumentacao()
        {
            var payload = new Information.Models.PIX_Payload()
            {
                MerchantCartoes = "12345678901234",
                MerchantChavePix = "123e4567-e12b-12d1-a456-426655440000",
                MerchantOutro = "0123456789",
                Amount = 123.45M,
                ReferenceLabel = "RP12345678-2019",
                MerchantName = "NOME DO RECEBEDOR",
                MerchantCity = "BRASILIA",
                MerchantPostalCode = "70074900",
                InformacaoArbitraria = "0123.ABCD.3456.WXYZ",
                UniquePayment = false,
            };
            var qr = PIX.GerarQR_Estatico(payload);

            var esperado = "00020104141234567890123426580014BR.GOV.BCB.PIX0136123e4567-e12b-12d1-a456-42665544000027300012BR.COM.OUTRO011001234567895204000053039865406123.455802BR5917NOME DO RECEBEDOR6008BRASILIA61087007490062190515RP12345678-201980390012BR.COM.OUTRO01190123.ABCD.3456.WXYZ6304AD38";
            Assert.Equal(esperado, qr);
        }

        [Fact]
        public void TestaPix_Minimo()
        {
            var payload = Information.Models.PIX_Payload.PayloadMinimo(chavePix: "123e4567-e12b-12d1-a456-426655440000",
                                                                       nomeMerchant: "NOME DO RECEBEDOR",
                                                                       cidadeMerchant: "BRASILIA");
            var qr = PIX.GerarQR_Estatico(payload);

            var esperado = "00020126580014BR.GOV.BCB.PIX0136123e4567-e12b-12d1-a456-4266554400005204000053039865802BR5917NOME DO RECEBEDOR6008BRASILIA6304F029";
            Assert.Equal(esperado, qr);
        }
    }
}

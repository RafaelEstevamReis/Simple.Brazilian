using Simple.Brazilian.Formatters;
using Simple.Brazilian.Information.Models;
using System.Globalization;
using System.Text;

namespace Simple.Brazilian.Information
{
    // Referência
    // Manual BR-Code Versão 2.0.1

    /// <summary>
    /// Implementa gerador de BRCode para PIX
    /// </summary>
    public class PIX
    {
        // Constantes de identificação
        const string PAYLOAD_FORMAT_INDICATOR = "00";
        const string POINT_OF_INITIATION_METHOD = "01";
        const string MERCHANT_ACCOUNT_INFORMATION_CARD = "04";
        const string MERCHANT_ACCOUNT_INFORMATION = "26";
        const string MERCHANT_ACCOUNT_INFORMATION_GUI = "00";
        const string MERCHANT_ACCOUNT_INFORMATION_KEY = "01";
        const string MERCHANT_ACCOUNT_INFORMATION_OUTRO = "27";
        const string MERCHANT_CATEGORY_CODE = "52";
        const string MERCHANT_NAME = "59";
        const string MERCHANT_CITY = "60";
        const string MERCHANT_POSTAL = "61";
        const string TRANSACTION_CURRENCY = "53";
        const string TRANSACTION_AMOUNT = "54";
        const string COUNTRYCODE = "58";
        const string ADDITIONAL_FIELD_TEMPLATE = "62";
        const string ADDITIONAL_FIELD_REFERENCE_LABEL = "05";
        const string UNRESERVED_TEMPLATE_ARBITRARIA = "80";
        const string CRC16 = "63";

        /// <summary>
        /// Monta texto do BRCode para geração de QR Code estático
        /// </summary>
        /// <param name="payload">Dados do pagamento</param>
        /// <returns>Texto do BRCode</returns>
        public static string GerarQR_Estatico(PIX_Payload payload)
        {
            var sb = new StringBuilder();

            sb.Append(montaTLV(PAYLOAD_FORMAT_INDICATOR, "01"));
            if (payload.UniquePayment)
            {
                sb.Append(montaTLV(POINT_OF_INITIATION_METHOD, "12"));
            }

            montaAccountInformation(payload, sb);

            sb.Append(montaTLV(MERCHANT_CATEGORY_CODE, "0000"));
            sb.Append(montaTLV(TRANSACTION_CURRENCY, "986"));
            if (payload.Amount > 0)
            {
                string amount = payload.Amount.ToString("#0.00", CultureInfo.InvariantCulture);
                sb.Append(montaTLV(TRANSACTION_AMOUNT, amount));
            }
            sb.Append(montaTLV(COUNTRYCODE, "BR"));

            sb.Append(montaTLV(MERCHANT_NAME, Text.TruncateText(payload.MerchantName, 25)));
            sb.Append(montaTLV(MERCHANT_CITY, Text.TruncateText(payload.MerchantCity, 15)));
            if (!string.IsNullOrEmpty(payload.MerchantPostalCode))
            {
                sb.Append(montaTLV(MERCHANT_POSTAL, payload.MerchantPostalCode));
            }

            montaInformacoesAdicionais(payload, sb);

            var qrParcial = sb.ToString() + CRC16 + "04";
            var hexCRC = Validators.CRC16.ComputeHexCRC(qrParcial);
            sb.Append(montaTLV(CRC16, hexCRC));

            return sb.ToString();
        }

        private static void montaAccountInformation(PIX_Payload payload, StringBuilder sb)
        {
            if (!string.IsNullOrEmpty(payload.MerchantCartoes))
            {
                sb.Append(montaTLV(MERCHANT_ACCOUNT_INFORMATION_CARD, payload.MerchantCartoes));
            }
            if (!string.IsNullOrEmpty(payload.MerchantChavePix))
            {
                var gui = montaTLV(MERCHANT_ACCOUNT_INFORMATION_GUI, "BR.GOV.BCB.PIX");
                var chave = montaTLV(MERCHANT_ACCOUNT_INFORMATION_KEY, payload.MerchantChavePix);
                sb.Append(montaTLV(MERCHANT_ACCOUNT_INFORMATION, gui + chave));
            }
            if (!string.IsNullOrEmpty(payload.MerchantOutro))
            {
                var gui = montaTLV(MERCHANT_ACCOUNT_INFORMATION_GUI, "BR.COM.OUTRO");
                var chave = montaTLV(MERCHANT_ACCOUNT_INFORMATION_KEY, payload.MerchantOutro);
                sb.Append(montaTLV(MERCHANT_ACCOUNT_INFORMATION_OUTRO, gui + chave));
            }
        }
        private static void montaInformacoesAdicionais(PIX_Payload payload, StringBuilder sb)
        {
            if (!string.IsNullOrEmpty(payload.ReferenceLabel))
            {
                var referenceLabel = montaTLV(ADDITIONAL_FIELD_REFERENCE_LABEL, Text.TruncateText(payload.ReferenceLabel, 25));
                sb.Append(montaTLV(ADDITIONAL_FIELD_TEMPLATE, referenceLabel));
            }
            if (!string.IsNullOrEmpty(payload.InformacaoArbitraria))
            {
                var gui = montaTLV(MERCHANT_ACCOUNT_INFORMATION_GUI, "BR.COM.OUTRO");
                var arbitraria = montaTLV(MERCHANT_ACCOUNT_INFORMATION_KEY, Text.TruncateText(payload.InformacaoArbitraria, 25));
                sb.Append(montaTLV(UNRESERVED_TEMPLATE_ARBITRARIA, gui + arbitraria));
            }
        }

        private static string montaTLV(string type, string value)
        {
            var valorLimpo = Text.RemoveAccents(value);
            return $"{type}{value.Length:00}{valorLimpo}";
        }

    }
}

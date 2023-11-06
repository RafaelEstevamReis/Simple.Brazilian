namespace Simple.Brazilian.Information.Models;

/// <summary>
/// Dados do Payload do Pix
/// </summary>
public class PIX_Payload
{
    /// <summary>
    /// Identifica se o pagamento pode ser reaproveitado
    /// </summary>
    public bool UniquePayment { get; set; }

    /// <summary>
    /// Chave pix
    /// </summary>
    public string MerchantChavePix { get; set; }
    /// <summary>
    /// Merchant Account Information – Cartões
    /// </summary>
    public string MerchantCartoes { get; set; }
    /// <summary>
    /// Merchant Account Information - Outro
    /// </summary>
    public string MerchantOutro { get; set; }

    /// <summary>
    /// Valor da transação
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Nome do titular da conta/Lojista
    /// </summary>
    public string MerchantName { get; set; }

    /// <summary>
    /// Cidade do titular da conta/Lojista
    /// </summary>
    public string MerchantCity { get; set; }

    /// <summary>
    /// CEP do titular da conta/Lojista
    /// </summary>
    public string MerchantPostalCode { get; set; }

    /// <summary>
    /// Texto de Referencia/Id Transacao
    /// </summary>
    public string ReferenceLabel { get; set; }

    /// <summary>
    /// Informação Arbitrária
    /// </summary>
    public string InformacaoArbitraria { get; set; }
    
    /// <summary>
    /// Monta Payload mínimo
    /// </summary>
    /// <param name="chavePix">Chave Pix</param>
    /// <param name="nomeMerchant">Nome do titular da conta</param>
    /// <param name="cidadeMerchant">Cidade do titular da conta</param>
    /// <returns>Payload com os dados</returns>
    public static PIX_Payload PayloadMinimo(string chavePix, string nomeMerchant, string cidadeMerchant)
    {
        return new PIX_Payload()
        {
            UniquePayment = false,
            MerchantChavePix = chavePix,
            MerchantName = nomeMerchant,
            MerchantCity = cidadeMerchant,
        };
    }

}

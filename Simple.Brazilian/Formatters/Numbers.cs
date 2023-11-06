namespace Simple.Brazilian.Formatters;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// Formata números
/// </summary>
public class Numbers
{
    /// <summary>
    /// CultureInfo padrão a ser utilizado
    /// </summary>
    public static CultureInfo DefaultCulture { get; }
    private static readonly string[] tamanhoNumeroPlural = new string[] {
        "",
        "Mil",
        "Milhões",
        "Bilhões",
        "Trilhões",
        "Quatrilhões",
        "Quintilhões", // limite do ULONG
        "Sextilhões",
        "Septilhões",
    };
    private static readonly string[] tamanhoNumeroSingular = new string[] {
        "",
        "Mil",
        "Milhão",
        "Bilhão",
        "Trilhão",
        "Quatrilhão",
        "Quintilhão", // limite do ULONG
        "Sextilhão",
        "Septilhão",
    };
    static Numbers()
    {
#if NETSTANDARD1_0
        DefaultCulture = new CultureInfo("pt-BR");
#else
        DefaultCulture = new CultureInfo("pt-BR", false);
#endif
    }

    /// <summary>
    /// Parseia um texto para Int32
    /// </summary>
    /// <param name="text">Texto a ser convertido</param>
    /// <param name="OnError">Valor a ser retornado em caso de falha</param>
    /// <returns>Número convertido, ou valor padrão</returns>
    /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
    public static int ToInt(string text, int? OnError = 0)
    {
        if (int.TryParse(text, NumberStyles.Any, DefaultCulture, out int value)) return value;
        return processError(OnError);
    }
    /// <summary>
    /// Parseia um texto para Double
    /// </summary>
    /// <param name="text">Texto a ser convertido</param>
    /// <param name="OnError">Valor a ser retornado em caso de falha</param>
    /// <returns>Número convertido, ou valor padrão</returns>
    /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
    public static double ToDouble(string text, double? OnError = 0)
    {
        if (double.TryParse(text, NumberStyles.Any, DefaultCulture, out double value)) return value;
        return processError(OnError);
    }
    /// <summary>
    /// Parseia um texto para Decimal
    /// </summary>
    /// <param name="text">Texto a ser convertido</param>
    /// <param name="OnError">Valor a ser retornado em caso de falha</param>
    /// <returns>Número convertido, ou valor padrão</returns>
    /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
    public static decimal ToDecimal(string text, decimal? OnError = 0)
    {
        if (decimal.TryParse(text, NumberStyles.Any, DefaultCulture, out decimal value)) return value;
        return processError(OnError);
    }
    /// <summary>
    /// Converte número em texto usando DefaultCulture
    /// </summary>
    /// <param name="value">Valor a ser convertido</param>
    /// <returns>Texto convertido</returns>
    public static string ToText(int value)
    {
        return Convert.ToString(value, DefaultCulture);
    }
    /// <summary>
    /// Converte número em texto usando DefaultCulture com a quantidade definida de casas decimais
    /// </summary>
    /// <param name="value">Valor a ser convertido</param>
    /// <param name="decimals">Casas decimais</param>
    /// <returns>Texto convertido</returns>
    public static string ToText(double value, int decimals = 2)
    {
        var rounded = abntRounding(value, decimals);
        return rounded.ToString($"N{decimals}", DefaultCulture);
    }
    /// <summary>
    /// Converte número em texto usando DefaultCulture com a quantidade definida de casas decimais
    /// </summary>
    /// <param name="value">Valor a ser convertido</param>
    /// <param name="decimals">Casas decimais</param>
    /// <returns>Texto convertido</returns>
    public static string ToText(decimal value, int decimals = 2)
    {
        var rounded = abntRounding(value, decimals);
        return rounded.ToString($"N{decimals}", DefaultCulture);
    }
    /// <summary>
    /// Converte número em texto monetário usando DefaultCulture com a quantidade definida de casas decimais
    /// </summary>
    /// <param name="value">Valor a ser convertido</param>
    /// <param name="decimals">Casas decimais</param>
    /// <returns>Texto convertido</returns>
    public static string ToBRL(decimal value, int decimals = 2)
    {
        var rounded = abntRounding(value, decimals);
        return rounded.ToString($"C{decimals}", DefaultCulture);
    }

    /// <summary>
    /// Faz conversão tentando ser tolerante à qualquer cultura
    /// </summary>
    /// <param name="text">Texto a ser convertido</param>
    /// <param name="OnError">Valor a ser retornado em caso de falha</param>
    /// <returns>Número convertido, ou valor padrão</returns>
    /// <exception cref="FormatException">Lança FormatException caso não seja possível a conversão e OnError seja NULL</exception>
    public static decimal ConvertFromUnkown(string text, decimal? OnError = 0)
    {
        // Tolerar o máximo de formatos
        // Será sempre considerado que, em caso de mais de um símbolo,
        // o último será o separador decimal

        int posComa = -1;
        int posPoint = -1;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ',')
            {
                sb.Append(text[i]);
                posComa = i; // último
            }
            else if (text[i] == '.')
            {
                sb.Append(text[i]);
                posPoint = i; // último
            }
            else if (text[i] == ' ') sb.Append(text[i]);
            else if (text[i] == '-') sb.Append(text[i]);
            else if (text[i] == '\r') sb.Append(text[i]);
            else if (text[i] == '\n') sb.Append(text[i]);
            else if (text[i] >= '0' && text[i] <= '9') sb.Append(text[i]);
        }
        string limpo = sb.ToString().Trim();

        // Converte para InvariantCulture
        if (posPoint == -1 && posComa >= 0)
        {
            // Caso especial "$1,900"
            if (posComa == limpo.Length - 3) limpo = limpo.Replace(",", "");
            else limpo = limpo.Replace(",", ".");
        }
        else if (posPoint >= 0 && posComa >= 0)
        {
            if (posPoint < posComa)
            {
                limpo = limpo.Replace(".", "");
                limpo = limpo.Replace(",", ".");
            }
            else
            {
                limpo = limpo.Replace(",", "");
            }
        }

        // Trata como InvariantCulture
        if (decimal.TryParse(limpo, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value)) return value;
        return processError(OnError);
    }

    private static decimal abntRounding(decimal value, int decimals)
    {
        return Math.Round(value, decimals, MidpointRounding.ToEven);
    }
    private static double abntRounding(double value, int decimals)
    {
        return Math.Round(value, decimals, MidpointRounding.ToEven);
    }

    private static T processError<T>(T? value) where T : struct
    {
        if (value.HasValue) return value.Value;
        throw new FormatException();
    }

    /// <summary>
    /// Escreve número monetário por extenso
    /// </summary>
    /// <exception cref="NotSupportedException">Valores negativos não são suportados</exception>
    public static string MoedaExtenso(decimal valorReais)
    {
        if (valorReais == 0) return "Zero Reais";
        if (valorReais < 0) throw new NotSupportedException("Valores negativos não são suportados");

        ulong inteira = Convert.ToUInt64(valorReais);
        uint centavos = Convert.ToUInt32(valorReais * 100 % 100);

        StringBuilder sbTexto = new StringBuilder();
        if (inteira > 0)
        {
            var ext = NumeroExtenso(inteira);
            sbTexto.Append(ext);
            if (inteira == 1) sbTexto.Append(" Real");
            else
            {
                // termina com "hão" ou "hões"
                if(ext.EndsWith("hão") || ext.EndsWith("hões"))
                {
                    sbTexto.Append(" de");
                }
                sbTexto.Append(" Reais");
            }

            if (centavos > 0) sbTexto.Append(" e ");
        }
        if(centavos > 0)
        {
            sbTexto.Append(NumeroExtenso(centavos));
            if(centavos == 1) sbTexto.Append(" Centavo");
            else sbTexto.Append(" Centavos");

            if(inteira == 0) sbTexto.Append(" de Real");
        }

        return sbTexto.ToString();
    }

    /// <summary>
    /// Escreve número inteiro por extenso
    /// </summary>
    public static string NumeroExtenso(ulong numero)
    {
        if (numero == 0) return "Zero";

        // Quebra em blocos de 3 dígitos
        List<int> partes = new List<int>();
        while (numero > 0)
        {
            partes.Add((int)(numero % 1_000));
            numero /= 1_000;
        }
        // Processa os blocos
        StringBuilder sbTexto = new StringBuilder();
        for (int i = partes.Count - 1; i >= 0; i--)
        {
            // Se não tem bloco, não coloca
            if (partes[i] == 0)
            {
                // exceto no final, caso não tenha milhar mas tenha Centena, Dezena ou Unidade
                if (i == 1 && partes[0] > 0) sbTexto.Append("e ");

                continue;
            }

            if (i == 1 && partes[1] == 1)
            {
                // Não fazer "Um Mil"
            }
            else
            {
                extensoParte3(partes[i], sbTexto);
            }
            // Adiciona separação dos blocos
            if (i > 0)
            {
                sbTexto.Append(" ");

                if (partes[i] == 1) sbTexto.Append(tamanhoNumeroSingular[i]);
                else sbTexto.Append(tamanhoNumeroPlural[i]);

                // Na separação dos milhares e das centenas, a conjunção e apenas deverá ser usada quando o número termina nas centenas:
                if (i == 1 && partes[0] % 100 == 0 && partes[0] != 0)
                {
                    sbTexto.Append(" e ");
                }
                else if (i == 1 && partes[0] / 100 == 0 && partes[0] > 0)
                {
                    sbTexto.Append(" e ");
                }
                else
                {
                    // Quando o número é muito grande, a leitura é feita por classes.
                    // A conjunção e é usada para separar os algarismos da classe mas não deverá ser usada para separar as classes.
                    // Não deverá ser usada nem a conjunção e nem a vírgula
                    sbTexto.Append(" ");
                }
            }
        }
        return sbTexto.ToString().Trim();
    }

    private static void extensoParte3(int numero, StringBuilder sbTexto)
    {
        int centena = numero / 100;
        int dezena = numero / 10 % 10;
        int unidade = numero % 10;
        bool adicionarE = false;

        if (centena == 1 && (dezena > 0 || unidade > 0))
        {
            sbTexto.Append("Cento");
            adicionarE = true;
        }
        else if (centena > 0)
        {
            sbTexto.Append(numerosFixos(centena * 100));
            adicionarE = true;
        }

        if (dezena == 1)
        {
            if (adicionarE) sbTexto.Append(" e ");

            sbTexto.Append(numerosFixos(dezena * 10 + unidade));
            return;
        }

        if (dezena > 0)
        {
            if (adicionarE)
            {
                sbTexto.Append(" e ");
            }

            sbTexto.Append(numerosFixos(dezena * 10));
            adicionarE = true;
        }

        if (unidade > 0)
        {
            if (adicionarE) sbTexto.Append(" e ");
            sbTexto.Append(numerosFixos(unidade));
        }
    }

    private static string numerosFixos(int numeroBase)
        => numeroBase switch
        {
            1 => "Um",
            2 => "Dois",
            3 => "Três",
            4 => "Quatro",
            5 => "Cinco",
            6 => "Seis",
            7 => "Sete",
            8 => "Oito",
            9 => "Nove",
            10 => "Dez",
            11 => "Onze",
            12 => "Doze",
            13 => "Treze",
            14 => "Quatorze",
            15 => "Quinze",
            16 => "Dezesseis",
            17 => "Dezessete",
            18 => "Dezoito",
            19 => "Dezenove",
            20 => "Vinte",
            30 => "Trinta",
            40 => "Quarenta",
            50 => "Cinquenta",
            60 => "Sessenta",
            70 => "Setenta",
            80 => "Oitenta",
            90 => "Noventa",
            100 => "Cem",
            200 => "Duzentos",
            300 => "Trezentos",
            400 => "Quatrocentos",
            500 => "Quinhentos",
            600 => "Seiscentos",
            700 => "Setecentos",
            800 => "Oitocentos",
            900 => "Novecentos",
            _ => throw new ArgumentException("Número inválido"),
        };
}

﻿namespace Simple.Brazilian.Formatters;

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Formatadores textuais
/// </summary>
public static class Text
{
    /// <summary>
    /// Torna o texto compatível com ASCII sem acentuação. 
    /// Letras acentuadas serão convertidas e outros caracteres serão descartados
    /// </summary>
    /// <param name="texto">Texto a ser processado</param>
    /// <param name="opcoes">Opções de remoção</param>
    /// <returns>Retorno sem acentos</returns>
    public static string RemoveAccents(this string texto, TextOptions opcoes = null)
    {
        return removeAcentos(texto, opcoes ?? TextOptions.Padrao);
    }

    private static string removeAcentos(string textoEntrada, TextOptions opcoes)
    {
        if (string.IsNullOrEmpty(textoEntrada)) return textoEntrada;

        string busca = "áéíóúýàèìòùâêîôûãõäëïöüÿåçñ ÁÉÍÓÚÝÀÈÌÒÙÂÊÎÔÛÃÕÄËÏÖÜŸÅÇÑ ªº°¹²³";
        string troca = "aeiouyaeiouaeiouaoaeiouyacn AEIOUYAEIOUAEIOUAOAEIOUYACN aoo123";

        char[] texto = textoEntrada.ToCharArray();

        for (int i = 0; i < texto.Length; i++)
        {
            // Textos em ASCII baixo, mantém
            // 20..2F => !"#$%&'()*+´-./
            // 30..39 => Números
            // 3A..40 => :;<=>?@
            // 41..5A => Letras MAIÚSCULAS
            // 5B..60 => [\]^_`
            // 61..7A => Letras minúsculas
            // 7B..7E => {|}
            if (texto[i] >= 0x20 && texto[i] <= 0x7E)
            {
                continue;
            }

            // Pula linha
            if (texto[i] == '\r' || texto[i] == '\n')
            {
                continue;
            }

            // Busca na lista de subsituição
            int idx = busca.IndexOf(texto[i]);
            // Tem na lista
            if (idx >= 0)
            {
                texto[i] = troca[idx];
                continue;
            }

            texto[i] = opcoes.CaracterPadraoSubstituicao;
        }

        return new string(texto);
    }

    /// <summary>
    /// Aplica uma máscara no texto
    /// </summary>
    /// <param name="texto">Texto base para aplicar a máscara</param>
    /// <param name="mascara">Máscara a ser usada. O caracter underline '_' será trocado pelo texto, demais caracteres serão mantidos</param>
    /// <returns>Texto com a máscara aplicada</returns>
    public static string ApplyMask(string texto, string mascara)
    {
        if (texto is null) throw new ArgumentNullException(nameof(texto));
        if (texto.Length == 0) return texto;

        if (mascara is null) throw new ArgumentNullException(nameof(mascara));
        if (mascara.Length == 0) throw new ArgumentException($"O parâmetro {nameof(mascara)} não pode ser vazio");

        var result = mascara.ToCharArray();
        int idxTexto = 0;
        for (int i = 0; i < mascara.Length && idxTexto < texto.Length; i++)
        {
            if (mascara[i] != '_') continue;

            result[i] = texto[idxTexto];
            idxTexto++;

            if (idxTexto == texto.Length) return new string(result, 0, i + 1);

        }

        return new string(result);
    }

    /// <summary>
    /// Remove todos os caracteres, exceto letras e números
    /// </summary>
    /// <param name="texto">Texto a ser limpo</param>
    /// <returns>Texto desformatado</returns>
    public static string RemoveMask(string texto)
    {
        if (string.IsNullOrEmpty(texto)) return texto;

        StringBuilder sb = new StringBuilder(texto.Length);

        for (int i = 0; i < texto.Length; i++)
        {
            if (char.IsNumber(texto[i])) sb.Append(texto[i]);
            else if (char.IsLetter(texto[i])) sb.Append(texto[i]);
        }

        return sb.ToString();
    }

    /// <summary>
    /// Remove todos os espaços desnecessários.
    /// Espaços no início e no fim da string, espaços que aparecem mais de uma vez na cadeia e espaços no início e fim de cada linha (caso haja quebra).
    /// </summary>
    /// <param name="text">Texto a ser limpo</param>
    /// <returns>O texto com os espaços tratados</returns>
    public static string RemoveUnnecessarySpaces(string text)
    {
        if (text == null) return null;
        if (text == string.Empty) return string.Empty;

        var sb = new StringBuilder(text.Length);
        for (int i = 0; i < text.Length; i++)
        {
            bool isWS = char.IsWhiteSpace(text[i]);
            bool isLast = i == text.Length - 1;

            if (isWS && sb.Length == 0) continue; // LeftTrim
            if (isWS && isLast) continue; // Last part of RightTrun

            // Keep new lines
            if (text[i] == 10)
            {
                sb.Append('\n');
                continue;
            }
            if (text[i] == 13)
            {
                sb.Append('\r');
                continue;
            }
            // remove spaces after new lines
            if (isWS && i > 0 && (text[i - 1] == 10 || text[i - 1] == 13)) continue;
            // remove duplicate spaces, looking foward
            if (isWS && !isLast && char.IsWhiteSpace(text[i + 1])) continue;

            sb.Append(text[i]);
        }
        return sb.ToString();
    }
    /// <summary>
    /// Retorna o texto com comprimento até o limite
    /// </summary>
    /// <param name="text">Texto a ser limitado</param>
    /// <param name="maxLen">Comprimento a ser utilizado</param>
    /// <returns>Texto até o limite de comprimento definido</returns>
    public static string TruncateText(string text, int maxLen)
    {
        if (maxLen <= 0) throw new ArgumentException($"{nameof(maxLen)} deve ser maior ou igual à 1");

        if (text == null) return null;
        if (text == string.Empty) return string.Empty;

        if (text.Length <= maxLen) return text;
        return text.Substring(0, maxLen);
    }

    /// <summary>
    /// Retorna o texto removendo todos os caracteres não permitidos
    /// </summary>
    /// <param name="text">Texto a ser avaliado</param>
    /// <param name="allowed">Caracteres permitidos</param>
    /// <returns>Texto contendo apenas caracteres permitidos</returns>
    public static string Filter(string text, string allowed)
        => Filter(text, allowed.ToCharArray());
    /// <summary>
    /// Retorna o texto removendo todos os caracteres não permitidos
    /// </summary>
    /// <param name="text">Texto a ser avaliado</param>
    /// <param name="allowed">Caracteres permitidos</param>
    /// <returns>Texto contendo apenas caracteres permitidos</returns>
    public static string Filter(string text, char[] allowed)
        => Filter(text, new HashSet<char>(allowed));

    /// <summary>
    /// Retorna o texto removendo todos os caracteres não permitidos
    /// </summary>
    /// <param name="text">Texto a ser avaliado</param>
    /// <param name="allowed">Caracteres permitidos</param>
    /// <returns>Texto contendo apenas caracteres permitidos</returns>
#if NET20
    internal 
#else
    public
#endif
    /**/ static string Filter(string text, HashSet<char> allowed)
    {
        if (allowed is null)
        {
            throw new ArgumentNullException(nameof(allowed));
        }

        if (string.IsNullOrEmpty(text)) return text;
        if (allowed.Count == 0) return string.Empty;

        StringBuilder sb = new StringBuilder(capacity: text.Length);

        foreach (var c in text)
        {
            if (!allowed.Contains(c)) continue;
            sb.Append(c);
        }

        return sb.ToString();
    }

    public enum CharacterType
    {
        Numbers,
        UppercaseLetters,
        LowercaseLetters,
        Symbols,
        Punctuation,
        Whitespace,
    }
    /// <summary>
    /// Verifica se o texto contém qualquer caracter do tipo escolhido
    /// </summary>
    public static bool ContainsAny(string text, CharacterType type)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (type == CharacterType.Numbers && char.IsDigit(c)) return true;
            if (type == CharacterType.UppercaseLetters && char.IsUpper(c)) return true;
            if (type == CharacterType.LowercaseLetters && char.IsLower(c)) return true;
            if (type == CharacterType.Symbols && char.IsSymbol(c)) return true;
            if (type == CharacterType.Punctuation && char.IsPunctuation(c)) return true;
            if (type == CharacterType.Whitespace && char.IsWhiteSpace(c)) return true;
        }
        return false;
    }
    /// <summary>
    /// Verifica se o texto contém apenas caracteres do tipo escolhido
    /// </summary>
    public static bool ContainsOnly(string text, CharacterType type)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (type == CharacterType.Numbers && !char.IsDigit(c)) return false;
            if (type == CharacterType.UppercaseLetters && !char.IsUpper(c)) return false;
            if (type == CharacterType.LowercaseLetters && !char.IsLower(c)) return false;
            if (type == CharacterType.Symbols && !char.IsSymbol(c)) return false;
            if (type == CharacterType.Punctuation && !char.IsPunctuation(c)) return false;
            if (type == CharacterType.Whitespace && !char.IsWhiteSpace(c)) return false;
        }
        return true;
    }

    /// <summary>
    ///  Verifica se as strings são iguais ignorando acentos e utilizando InvariantCultureIgnoreCase
    ///  NETSTANDARD1_0 utilizará .ToLower() antes da comparação
    /// </summary>
    public static bool EqualsText(this string a, string b)
    {
        var a1 = RemoveAccents(a);
        var b1 = RemoveAccents(b);

#if NETSTANDARD1_0
        return a1.ToLower().Equals(b1.ToLower());
#else
        return a1.Equals(b1, StringComparison.InvariantCultureIgnoreCase);
#endif

    }
}

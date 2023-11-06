using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.Brazilian.Formatters;

internal class Pluralizer
{
    public static string[] InvariantWords { get; set; } =
    {
        "lápis",
        "atlas",
        "jeans",
        "nós",
    };
    public static Dictionary<string, string> ExceptionalCases { get; set; } = new Dictionary<string, string>();

    public static string Pluralize(string word)
    {
        if (word is null)
        {
            throw new ArgumentNullException(nameof(word));
        }
        if (string.IsNullOrEmpty(word.Trim()))
        {
            return string.Empty;
        }

        var lowerWrod = word.ToLower();
        var resultado = simplePluralize(lowerWrod);

        var l0 = char.IsLower(word[0]);
        var l1 = char.IsLower(word[1]);

        // Começa lower
        if (l0) return resultado;
        if (l1) // Upper depois Lower
        {
            var c0 = resultado[0].ToString();
            return c0.ToUpper() + resultado.Substring(1);
        }
        return resultado.ToUpper(); // tudo upper
    }

    private static string simplePluralize(string word)
    {
        if (IsInvariant(word))
        {
            return word;
        }
        if (ExceptionalCases.ContainsKey(word))
        {
            return ExceptionalCases[word];
        }

        // Verifica a terminação da palavra no singular
        string lastTwoChars = word.Length > 1 ? word.Substring(word.Length - 2) : "";
        string lastChar = word.Substring(word.Length - 1);

        if (lastChar == "s" || lastChar == "x")
        {
            // Casos especiais: palavras que terminam em 's' ou 'x'
            return word + "es";
        }
        else if (lastTwoChars == "ão")
        {
            // Casos especiais: palavras terminadas em 'ão'
            if(word.Length > 3 && word[word.Length -3] == 'ç') return word.Substring(0, word.Length - 2) + "ões";

            var silabas = DividirPalavraSilabas(word);
            if(silabas.Length == 2) return word.Substring(0, word.Length - 2) + "ãos";

            return word.Substring(0, word.Length - 2) + "ães";
        }
        else if ((lastTwoChars == "al") && word.Length > 2)
        {
            return word.Substring(0, word.Length - 1) + "is";
        }
        else if ((lastTwoChars == "el" || lastTwoChars == "ol") && word.Length > 2)
        {
            // adiciona acento
            var letraBase = word[word.Length - 2];
            if (letraBase == 'o') letraBase = 'ó';
            if (letraBase == 'e') letraBase = 'é';

            return word.Substring(0, word.Length - 2) + letraBase + "is";
        }
        else if ((lastTwoChars == "el" || lastTwoChars == "ol" || lastTwoChars == "ul") && word.Length > 2)
        {
            return word.Substring(0, word.Length - 1) + "is";
        }
        else if (lastChar == "m")
        {
            return word.Substring(0, word.Length - 1) + "ns";
        }
        else if (lastChar == "l" || lastChar == "z")
        {
            // Casos especiais: palavras que terminam em 'l', ou 'z'
            return word + "es";
        }
        else if (lastTwoChars == "or" && word.Length > 2)
        {
            // Caso "motor"
            return word + "es";
        }
        else
        {
            // Regra padrão: adiciona 's' ao final
            return word + "s";
        }
    }
    private static bool IsInvariant(string word)
    {
        return Array.Exists(InvariantWords, w => w.Equals(word, StringComparison.OrdinalIgnoreCase));
    }

    public static string DividirPalavraSilabas(string palavra, string divisor)
        => DivisaoSilabica(palavra).Replace(".", divisor);
    public static string[] DividirPalavraSilabas(string palavra)
        => DivisaoSilabica(palavra).Split('.');

    /// <summary>
    /// Algoritmo de divisão silábica
    /// Usa o paper `Divisão Silábica Automática do Texto Escrito e Falado` do
    /// CEFAT por Paulo Duarte Ferreira Gouveia, João Paulo Ramos Teixeira, e Diamantino Rui da Silva Freitas
    /// </summary>
    /// <param name="pal"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static string DivisaoSilabica(string pal)
    {
        if (pal is null) throw new ArgumentNullException(nameof(pal));
        if (pal == "") return string.Empty;

        pal += '\0';
        StringBuilder corrente = new StringBuilder();

        int i = 0;
        corrente.Append(pal[i]); // put(pal[i])
        if (!ehVogal(pal[i]))
        {
            i++;
            if (pal[i] == '\0') return corrente.ToString();
            corrente.Append(pal[i]); // put(pal[i])
            if (!ehVogal(pal[i]))
            {
                i++;
                corrente.Append(pal[i]); // put(pal[i])
            }
        }

        while (i < 128) // não processar mais do que 128 letras
        {
            i++;
            if (pal[i] == '\0') return corrente.ToString();

            if (ehVogal(pal[i]))
            {
                if (ehSemivogal(pal[i - 1], pal[i]))
                {
                    corrente.Append(pal[i]); // put(pal[i])
                    continue;
                }
                corrente.Append('.'); // put('.') separador
                corrente.Append(pal[i]); // put(pal[i])
                continue;
            }

            i++; // avança e faz loopback
            if (pal[i] == '\0')
            {
                corrente.Append(pal[i - 1]); // put(pal[i-1])
                return corrente.ToString();
            }
            if (ehVogal(pal[i]))
            {
                corrente.Append('.'); // put('.') separador
                corrente.Append(pal[i - 1]); // put(pal[i-1])
                corrente.Append(pal[i]); // put(pal[i])
                continue; // ...v.c/v/
            }

            if (ehVogal(pal[i + 1]))
            {
                if (seg(pal[i - 1], pal[i]))
                {
                    corrente.Append('.'); // put('.') separador
                    corrente.Append(pal[i - 1]); // put(pal[i-1])
                }
                else // contrário
                {
                    corrente.Append(pal[i - 1]); // put(pal[i-1])
                    corrente.Append('.'); // put('.') separador
                }
                // continua o fluxo ...
                corrente.Append(pal[i]); // put(pal[i])
                i++;
                corrente.Append(pal[i]); // put(pal[i])
                continue;
            }
            if (ehVogal(pal[i + 2]))
            {
                if (seg(pal[i - 1], pal[i]) || pal[i] == 's')
                {
                    corrente.Append(pal[i - 1]); // put(pal[i-1])
                    corrente.Append(pal[i]); // put(pal[i])
                    corrente.Append('.'); // put('.') separador
                }
                else
                {
                    corrente.Append(pal[i - 1]); // put(pal[i-1])
                    corrente.Append('.'); // put('.') separador
                    corrente.Append(pal[i]); // put(pal[i])
                }
            }
            else
            {
                corrente.Append(pal[i - 1]); // put(pal[i-1])
                corrente.Append(pal[i]); // put(pal[i])
                corrente.Append('.'); // put('.') separador
                i++;
                corrente.Append(pal[i]); // put(pal[i])
            }

            i++;
            // continua o fluxo ...
            corrente.Append(pal[i]); // put(pal[i])
            i++;
            corrente.Append(pal[i]); // put(pal[i])
            continue;
        }

        throw new Exception("Word too long (128+)");
    }
    static bool seg(char x, char y)
    {
        if (x == 'c' && y == 'h') return true;
        if (x == 'l' && y == 'h') return true;
        if (x == 'n' && y == 'h') return true;
        if (x == 'g' && y == 'r') return true;

        return false;
    }

    static bool ehSemivogal(char x, char y)
    {
        if (!ehVogal(x)) return false;

        if (y == 'í') return false;

        if (x == 'u') return true;
        //if (x == 'i') return true;
        if (x == 'ã') return true;

        if (x == 'i') // detectar hiato
        {
            // caso i+vogal
            // Se a letra 'i' não acentuada for seguida por outra vogal não acentuada este encontro vocálico pode ser pronunciado de duas maneiras distintas:
            // 1.Como ditongo crescente 'ia', 'ie', 'ii', 'io', 'iu', com a pronúncia das duas vogais em uma mesma sílaba e realização de 'i' como semivogal.
            //  Exemplos: fé - rias, a - gên - cia.
            // 2.Como hiato 'i-a', 'i-e', 'i-i', 'i-o', 'i-u', com a separação das duas vogais em duas sílabas distintas e a representação de 'i' como vogal.
            //  Exemplos: fé - ri -as, a - gên - ci - a.

            return false;
        }

        return true;
    }

    static bool ehVogal(char c)
        => !ehConsoante(c);
    static bool ehConsoante(char c)
    {
        // Define quais caracteres são considerados consoantes
        string consoantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZçÇ";
        return consoantes.Contains(c.ToString());
    }


}

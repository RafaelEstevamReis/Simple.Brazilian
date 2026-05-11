#if !NET20
namespace Simple.Brazilian.Formatters;

using System;
using System.Collections.Generic;
using System.Linq;

public class Names
{
    /// <summary>
    /// Abrevia um nome completo com configurações flexíveis.
    /// </summary>
    public static string AbbreviateName(string fullName, NameAbbreviationOptions? options = null)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

        options ??= new NameAbbreviationOptions()
        {
            AbbreviateLastName = false,
            MaxMiddleInitials = 99,
            RemovePrepositions = true,
        };

        // Divide e limpa os nomes
        var parts = fullName.Trim()
                            .Split([' '], options: StringSplitOptions.RemoveEmptyEntries)
                            .Where(p => !string.IsNullOrWhiteSpace(p))
                            .ToList();

        if (parts.Count == 0) return string.Empty;
        if (parts.Count == 1) return parts[0];

        // Remove preposições se configurado
        if (options.RemovePrepositions)
        {
            parts = parts.Where(p => !options.Prepositions.Contains(p)).ToList();
        }

        if (parts.Count == 0) return string.Empty;
        if (parts.Count == 1) return parts[0];

        string firstName = parts[0];
        string lastName = parts[parts.Count - 1];
        var middleParts = parts.Skip(1).Take(parts.Count - 2).ToList();

        // Limita quantidade de iniciais do meio
        if (middleParts.Count > options.MaxMiddleInitials)
        {
            middleParts = middleParts.Take(options.MaxMiddleInitials).ToList();
        }

        // Gera iniciais dos nomes do meio
        var middleInitials = middleParts.Select(m => char.ToUpper(m[0]) + ".");

        // Trata o último nome
        string finalLastName = options.AbbreviateLastName
            ? char.ToUpper(lastName[0]) + "."
            : lastName;

        var resultParts = new List<string> { firstName };
        resultParts.AddRange(middleInitials);
        resultParts.Add(finalLastName);

        return string.Join(" ", resultParts);
    }
}
public class NameAbbreviationOptions
{
    /// <summary>
    /// Quantidade máxima de iniciais para os nomes do meio (padrão = todas)
    /// </summary>
    public int MaxMiddleInitials { get; set; } = 99;

    /// <summary>
    /// Se true, abrevia também o último sobrenome (ex: João S. Santos → João S. S.)
    /// </summary>
    public bool AbbreviateLastName { get; set; } = false;

    /// <summary>
    /// Se true, remove preposições como "da", "de", "do", "das", "dos", "e" antes de abreviar
    /// </summary>
    public bool RemovePrepositions { get; set; } = true;

    /// <summary>
    /// Lista personalizada de preposições para remover
    /// </summary>
    public string[] Prepositions { get; set; } =
    [
        "da", "de", "do", "das", "dos", "e", "da", "dos", "das"
    ];
}
#endif
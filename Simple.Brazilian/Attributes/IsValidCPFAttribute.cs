#if NET8_0_OR_GREATER || NETCOREAPP3_1_OR_GREATER
namespace Simple.Brazilian.Attributes;

using Simple.Brazilian.Documents;
using System.ComponentModel.DataAnnotations;

public class IsValidCPFAttribute: ValidationAttribute
{
    public override bool IsValid(object value)
    {
        return CPF.IsValid(value?.ToString());
    }
}
#endif
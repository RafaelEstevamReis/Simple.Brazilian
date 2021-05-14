using Simple.Brazilian.Documentos;
using System;

namespace Simple.Brazilian.Extensoes
{
    public static class MaskAs
    {
        public static string Mask(this string valor, Enums.As As)
        {
            switch (As)
            {
                case Enums.As.CEP:
                    return CEP.Mask(valor);
                case Enums.As.CNPJ:
                    return CNPJ.Mask(valor);
                case Enums.As.CPF:
                    return CPF.Mask(valor);
                //case Enums.As.IE:
                //    return IE.Mask(valor);
                case Enums.As.PIS:
                    return PIS.Mask(valor);
                //case Enums.As.RG:
                //    return RG.Mask(valor);

                default:
                   throw new NotImplementedException();
            }
        }
    }
}

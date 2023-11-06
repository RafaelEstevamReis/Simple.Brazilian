namespace Simple.Brazilian.Documents;

using Simple.Brazilian.Information.Places;
using Simple.Brazilian.Validators;
using System;

/// <summary>
/// Validador de IE
/// </summary>
public static class IE
{
    /// <summary>
    /// Verifica se a Inscrição Estuadual é válida para determinado UF
    /// </summary>
    /// <param name="ie">Inscrição Estuadual a ser validada</param>
    /// <param name="uf">Unidade federativa que deve ser utilizada na validação</param>
    /// <returns>True caso a IE seja válida nesta UF, false se não</returns>
    public static bool IsValid(string ie, UFs uf)
    {
        if (string.IsNullOrEmpty(ie)) return false;
        // Os comprimentos são importantes, máscaras devem ser removidas antes
        ie = Formatters.Text.RemoveMask(ie);

        return uf switch
        {
            UFs.AC => validar_AC(ie),
            UFs.AL => validar_AL(ie),
            UFs.AM => validar_AM(ie),
            UFs.AP => validar_AP(ie),
            UFs.BA => validar_BA(ie),
            UFs.CE => validar_CE(ie),
            UFs.DF => validar_DF(ie),
            UFs.ES => validar_ES(ie),
            UFs.EX => false,
            UFs.GO => validar_GO(ie),
            UFs.MA => validar_MA(ie),
            UFs.MG => validar_MG(ie),
            UFs.MS => validar_MS(ie),
            UFs.MT => validar_MT(ie),
            UFs.PA => validar_PA(ie),
            UFs.PB => validar_PB(ie),
            UFs.PE => validar_PE(ie),
            UFs.PI => validar_PI(ie),
            UFs.PR => validar_PR(ie),
            UFs.RJ => validar_RJ(ie),
            UFs.RN => validar_RN(ie),
            UFs.RO => validar_RO(ie),
            UFs.RR => validar_RR(ie),
            UFs.RS => validar_RS(ie),
            UFs.SC => validar_SC(ie),
            UFs.SE => validar_SE(ie),
            UFs.SP => validar_SP(ie),
            UFs.TO => validar_TO(ie),
            _ => throw new NotImplementedException(),
        };
    }

    /// <summary>
    /// Aplica a máscara de IE
    /// </summary>
    /// <param name="ie">Texto para aplicar a máscara</param>
    /// <param name="uf">Especifica qual UF deve ser usada para aplicar a máscara</param>
    /// <returns>Texto com a máscara</returns>
    public static string Mask(string ie, UFs uf)
    {
        if (ie is null) throw new ArgumentNullException(nameof(ie));
        if (ie == string.Empty) return string.Empty;

        if (uf == UFs.AL) return ie; // AL não tem máscara

        string mask = mascaraUF(ie, uf);
        return Formatters.Text.ApplyMask(ie, mask);
    }
    private static string mascaraUF(string ie, UFs uf)
    {
        switch (uf)
        {
            case UFs.AC: return "__.___.___/___-__";
            case UFs.AP:
            case UFs.AM: return "__.___.___-_";
            case UFs.BA:
                if (ie.Length == 8) return "______-__";
                return "___.___.___";
            case UFs.CE: return "________-_";
            case UFs.DF: return "___._____.___-__";
            case UFs.ES: return "________-_";
            case UFs.GO: return "__.___.___-_";
            case UFs.MA: return "________-_";
            case UFs.MT: return "___.___.___-_";
            case UFs.MS: return "________-_";
            case UFs.MG: return "___.___.___/____";
            case UFs.PA: return "__-______-_";
            case UFs.PB: return "________-_";
            case UFs.PR: return "___._____-__";
            case UFs.PE:
                if (ie.Length == 9) return "_______-__";
                return "__._.___._______-_";
            case UFs.PI: return "________-_";
            case UFs.RJ: return "__.___.__-_";
            case UFs.RN:
                if (ie.Length == 9) return "__.___.___-_";
                return "__._.___.___-_";
            case UFs.RS: return "___/_______";
            case UFs.RO:
                if (ie.Length == 9) return "___._____-_";
                return "_____________-_";
            case UFs.RR: return "________-_";
            case UFs.SC: return "___.___.___";
            case UFs.SP:
                if(ie.Length > 0)
                {
                    if (ie[0] == 'P' || ie[0] == 'p') return "_-________._/___";
                }
                return "___.___.___.___";
            case UFs.SE: return "________-_";
            case UFs.TO: return "__.__.______-_";

            case UFs.AL: // Não tem, não deveria ter chego aqui
            default:
                throw new ArgumentException("Invalid UF", nameof(uf));
        }
    }

    /// <summary>
    /// Remove a máscara
    /// </summary>
    /// <param name="cep">Texto com a máscara aplicada</param>
    /// <returns>Texto com a máscara removida</returns>
    public static string Unmask(string cep) => Formatters.Text.RemoveMask(cep);

    private static bool validar_AC(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_AC.html
        if (!ajustaZeros(ref IE, 13)) return false;

        return verifricaDV11Duplo(IE);
    }
    private static bool validar_AL(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_AL.html
        if (IE.Length != 9) return false;
        if (IE[0] != '2') return false;
        if (IE[1] != '4') return false;

        // Terceiro caracter é o TIPO de empresa, 
        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_AP(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_AP.html
        // modificar o zero aqui é complicado, 
        // mas vou checar assim mesmo
        if (!ajustaZeros(ref IE, 9)) return false;

        if (IE[0] != '0') return false;
        if (IE[1] != '3') return false;

        string parte = IE.Substring(0, 8);

        #region valores P e D
        int p;
        int d;
        if (!int.TryParse(parte, out int iPart)) return false;

        if (iPart <= 17000)
        {
            p = 5;
            d = 0;
        }
        else if (iPart <= 19022)
        {
            p = 9;
            d = 1;
        }
        else
        {
            p = 0;
            d = 0;
        }
        #endregion

        int soma = p + ModValidation.SumMultiplySequence(parte, 2, 9, true);
        int diff = 11 - (soma % 11);

        char dv = diff.ToString()[0];
        if (diff == 10) dv = '0';
        if (diff == 11) dv = d.ToString()[0];

        return dv == IE[8];
    }
    private static bool validar_AM(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_AM.html
        if (!ajustaZeros(ref IE, 9)) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    #region BA
    private static bool validar_BA(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_BA.html
        if (IE.Length == 9)
        {
            return validar_BA_9(IE);
        }
        if (IE.Length == 8)
        {
            return validar_BA_8(IE);
        }
        return false;
    }
    private static bool validar_BA_8(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_AM.html
        int mod = 10;
        if (IE[0] == '6' || IE[0] == '7' || IE[0] == '9') mod = 11;

        string parte = IE.Substring(0, 6);
        var dv = soma2a9RL_DVMOD10_SUB(parte, mod);

        if (dv != IE[7]) return false;
        parte = IE.Substring(0, 6) + dv; // dv anterior
        dv = soma2a9RL_DVMOD10_SUB(parte, mod);

        return dv == IE[6];
    }
    private static bool validar_BA_9(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_AM.html
        int mod = 10;
        if (IE[1] == '6' || IE[1] == '7' || IE[1] == '9') mod = 11;

        string parte = IE.Substring(0, 7);
        var dv = soma2a9RL_DVMOD10_SUB(parte, mod);

        if (dv != IE[8]) return false;
        parte = IE.Substring(0, 7) + dv; // dv anterior
        dv = soma2a9RL_DVMOD10_SUB(parte, mod);

        return dv == IE[7];
    }
    #endregion
    private static bool validar_CE(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_CE.html
        if (!ajustaZeros(ref IE, 9)) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_DF(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_DF.html
        // modificar o zero aqui é complicado, 
        // mas vou checar assim mesmo
        if (!ajustaZeros(ref IE, 13)) return false;

        if (IE[0] != '0') return false;
        if (IE[1] != '7') return false;

        return verifricaDV11Duplo(IE);
    }
    private static bool validar_ES(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_ES.html
        if (IE.Length != 9) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_GO(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_GO.html
        if (IE.Length != 9) return false;

        // Começa com 10, 11 ou 15
        if (IE[0] != '1') return false;
        if (IE[1] != '0'
           && IE[1] != '1'
           && IE[1] != '5') return false;

        // Dois dígitos
        string parte = IE.Substring(0, 8);
        int resto = ModValidation.SumMultiplySequence(parte, 2, 9, true) % 11;
        char dv;

        if (resto == 0)
        {
            dv = '0';
        }
        else if (resto == 1)
        {
            if (!int.TryParse(parte, out int valIE)) return false;

            // Quando o resto da divisão for um (1), e a inscrição for maior ou igual a 10103105 e menor ou igual a 10119997, ...
            //  o dígito verificador será um (1);

            if (valIE >= 10103105 && valIE <= 10119997)
            {
                dv = '1';
            }
            else
            {
                // Quando o resto da divisão for um (1), e a inscrição estiver fora do intervalo citado acima, o dígito verificador será zero (0);
                dv = '0';
            }
        }
        else
        {
            dv = (11 - resto).ToString()[0];
        }

        if (parte == "11094402")
        {
            // Quando a inscrição for 11094402 o dígito verificador pode ser zero (0) e pode ser um (1);
            return dv == '0' || dv == '1';
        }

        return dv == IE[8];
    }
    private static bool validar_MA(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_MA.html
        if (IE.Length != 9) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_MT(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_MT.html
        if (!ajustaZeros(ref IE, 11)) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_MS(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_MT.html
        if (IE.Length != 9) return false;

        if (IE[0] != '2') return false;
        if (IE[1] != '8') return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_MG(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_MG.html
        if (!ajustaZeros(ref IE, 13)) return false;

        // Retira o DV
        // Insere um "0" depois na quarta posição
        string parte = IE.Substring(0, 3) + "0" + IE.Substring(3, 8);
        // Soma-se algarismos da multiplicação
        int soma = 0;
        for (int i = 0; i < 12; i++)
        {
            int p = 1 + (i % 2);
            var prod = p * (parte[i] - '0');
            foreach (var d in prod.ToString())
            {
                soma += d - '0';
            }
        }
        int dv1 = (10 - (soma % 10)) % 10;

        parte = IE.Substring(0, 11) + dv1.ToString();

        int soma2 = ModValidation.SumMultiplySequence(parte, 2, 11, true);
        int mod = soma2 % 11;
        if (mod < 2) return IE[12] == '0';

        return (11 - mod).ToString()[0] == IE[12];
    }
    private static bool validar_PA(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_PA.html
        if (IE.Length != 9) return false;

        if (IE[0] != '1') return false;
        if (IE[1] != '5') return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_PB(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_PB.html
        if (!ajustaZeros(ref IE, 9)) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_PR(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_PR.html
        if (IE.Length != 10) return false;

        string parte = IE.Substring(0, 8);
        char dv = soma2a7RL_DV11_11SUB(parte);

        if (IE[8] != dv) return false;
        dv = soma2a7RL_DV11_11SUB(parte + dv);

        return dv == IE[9];
    }
    private static bool validar_PE(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_PE.html
        if (IE.Length == 9)
        {
            // Novo
            return verifricaDV11Duplo(IE);
        }
        else if (IE.Length == 14)
        {
            // Antigo
            int soma = somaPesos(IE.Substring(0, 13), new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 1 });
            char dv = ((11 - (soma % 11)) % 10).ToString()[0];
            return IE[13] == dv;
        }
        else
        {
            return false;
        }
    }
    private static bool validar_PI(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_PI.html
        if (!ajustaZeros(ref IE, 9)) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_RJ(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_RJ.html
        if (IE.Length != 8) return false;

        return soma2a7RL_DV11_11SUB(IE.Substring(0, 7)) == IE[7];
    }
    private static bool validar_RN(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_RN.html
        if (IE.Length < 9 || IE.Length > 10) return false;
        // Vai de 2 a 10, não 9
        var r = ModValidation.CalculateMult10Mod11(IE.Substring(0, IE.Length - 1), 2, 10);

        if (r == 10) return IE[IE.Length - 1] == '0';
        return IE[IE.Length - 1] == r.ToString()[0];
    }
    private static bool validar_RS(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_RS.html
        if (IE.Length != 10) return false;

        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_RO(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_RO.html
        if (IE.Length == 9)
        {
            string parte = IE.Substring(3, 5);
            return ModValidation.CalculateMult10Mod11Char(parte, 2, 9) == IE[8];
        }
        else if (IE.Length == 14)
        {
            string parte = IE.Substring(0, IE.Length - 1);
            int dv = 11 - ModValidation.CalculateMod11(parte, 2, 9);
            if (dv > 9) dv -= 10;

            return dv.ToString()[0] == IE[13];
        }

        return false;
    }
    private static bool validar_RR(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_RR.html
        if (IE.Length != 9) return false;

        int soma = ModValidation.SumMultiplySequence(IE.Substring(0, 8), 1, 9, false);
        int dv = soma % 9; // Pq 9 ?? Elimina entropia, Retia o '9' como DV
        return IE[8] == dv.ToString()[0];
    }
    private static bool validar_SC(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_SC.html
        if (IE.Length != 9) return false;
        return ModValidation.CheckDocumentMod1129(IE);
    }
    private static bool validar_SE(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_SE.html
        if (IE.Length != 9) return false;
        return ModValidation.CheckDocumentMod1129(IE);
    }
    #region SP
    private static bool validar_SP(string IE)
    {
        if (IE.Length == 13 && (IE[0] == 'P' || IE[0] == 'p'))
        {
            // P0MMMSSSSD000
            return validar_SP_Rural(IE);
        }
        else if (IE.Length == 12)
        {
            return validar_SP_Industrial(IE);
        }
        return false; // SP é 12 ou 13
    }
    private static bool validar_SP_Industrial(string IE)
    {
        // SP usa um cálculo completamente arbitrário que não pode usar os cálculos já existentes
        // São dois estágios com DV nas posições 9 e 12
        // No primeiro, os pesos são "1,3,4,5,6,7,8 e 10"; Não tem o 9

        // 1º estágio
        string parte = IE.Substring(0, 8);
        int soma = somaPesos(parte, new int[] { 1, 3, 4, 5, 6, 7, 8, 10 }, true);
        int dv = (soma % 11) % 10; // 10 => 0

        if (IE[8].ToString() != dv.ToString()) return false; // Primeiro dígito

        parte = IE.Substring(0, 11);
        soma = somaPesos(parte, new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        dv = (soma % 11) % 10; // 10 => 0

        return IE[11].ToString() == dv.ToString();
    }
    private static bool validar_SP_Rural(string IE)
    {
        // A IE de produtor rural é completamente diferente
        // O "P" é ignorado
        // Os últimos 3 são ignorados
        string parte = IE.Substring(1, 8);
        // Não tem o 9 ....
        int soma = somaPesos(parte, new int[] { 1, 3, 4, 5, 6, 7, 8, 10 }, true);
        int dv = (soma % 11) % 10; // 10 => 0

        return IE[9].ToString() == dv.ToString();
    }
    #endregion
    private static bool validar_TO(string IE)
    {
        // http://www.sintegra.gov.br/Cad_Estados/cad_TO.html
        if (IE.Length != 11) return false;

        // A IE deve ignorar dígitos na conta, para não fazer toda a soma na mão
        //  vou criar uma nova IE com ZEROS nas posições para que anule a soma

        string ie2 = IE.Substring(0, 2) + IE.Substring(4, 7);

        return ModValidation.CheckDocumentMod1129(ie2);
    }

    // Helpers

    private static bool verifricaDV11Duplo(string IE)
    {
        string parte = IE.Substring(0, IE.Length - 1);

        if (!ModValidation.CheckDocumentMod1129(parte)) return false;
        return ModValidation.CheckDocumentMod1129(IE);
    }

    private static bool ajustaZeros(ref string IE, int Len)
    {
        if (IE.Length > Len) return false;

        if (IE.Length < Len)
        {
            IE = IE.PadLeft(Len, '0');
        }

        return true;
    }

    private static char soma2a9RL_DVMOD10_SUB(string Parte, int Mod)
    {
        int soma = ModValidation.SumMultiplySequence(Parte, 2, 9, true);
        int dv = Mod - (soma % Mod);
        if (dv > 9) return '0';
        return dv.ToString()[0];
    }
    private static char soma2a7RL_DV11_11SUB(string Parte)
    {
        int soma = ModValidation.SumMultiplySequence(Parte, 2, 7, true);
        int dv = 11 - (soma % 11);
        if (dv > 9) return '0';
        return dv.ToString()[0];
    }

    private static int somaPesos(string Valores, int[] Pesos, bool direcaoLR = false)
    {
        if (Valores == null) throw new ArgumentNullException();
        if (Pesos == null) throw new ArgumentNullException();

        if (Valores.Length == 0 || Pesos.Length == 0) throw new ArgumentException();

        int sum = 0;
        // Decrease
        if (direcaoLR)
        {
            for (int i = 0; i < Valores.Length; i++)
            {
                // Increase
                sum += (Valores[i] - '0') * Pesos[i % Pesos.Length];
            }
        }
        else
        {
            // Decrease
            for (int i = 0; i < Valores.Length; i++)
            {
                // Increase
                sum += (Valores[Valores.Length - 1 - i] - '0') * Pesos[i % Pesos.Length];
            }
        }

        return sum;
    }

}

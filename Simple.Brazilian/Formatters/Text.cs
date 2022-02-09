using System;
using System.Text;

namespace Simple.Brazilian.Formatters
{
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
        public static string RemoveAcentos(this string texto, TextOptions opcoes = null)
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
        /// <param name="texto">Texto a ser limpo</param>
        /// <returns>O texto com os espaços tratados</returns>
        public static string RemoveEspacosDesnecessarios(string texto)
        {
            if (texto == null) return null;
            if(texto == string.Empty) return string.Empty;

            var textoTrim = texto.Trim();
            if (textoTrim.Length == 0) return "";

            var sb = new StringBuilder(textoTrim.Length);
            for (int i = 0; i < textoTrim.Length; i++)
            {
                if (textoTrim[i] == 10)
                {
                    sb.Append('\n');
                    continue;
                }
                if (textoTrim[i] == 13)
                {
                    sb.Append('\r');
                    continue;
                }

                if (char.IsWhiteSpace(textoTrim[i]) && char.IsWhiteSpace(textoTrim[i + 1])) continue;
                if (char.IsWhiteSpace(textoTrim[i]) && (char.IsWhiteSpace(textoTrim[i - 1]) && textoTrim[i] == 10 && textoTrim[i] == 13)) continue;
                if (char.IsWhiteSpace(textoTrim[i]) && (textoTrim[i - 1] == 10 || textoTrim[i - 1] == 13)) continue;
                sb.Append(textoTrim[i]);
            }
            return sb.ToString();
        }
    }
}

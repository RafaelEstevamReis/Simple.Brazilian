using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.Brazilian.Formatters
{
    /// <summary>
    /// Formatadores textuais
    /// </summary>
    public static class Texto
    {
        /// <summary>
        /// Torna o texto compatível com ASCII sem acentuação. 
        /// Letras acentuadas serão convertidas e outros caracteres serão descartados
        /// </summary>
        /// <param name="texto">Texto a ser processado</param>
        /// <param name="opcoes">Opções de remoção</param>
        /// <returns>Retorno sem acentos</returns>
        public static string RemoveAcentos(this string texto, OpcoesTexto opcoes = null)
        {
            return removeAcentos(texto, opcoes ?? OpcoesTexto.Padrao);
        }

        private static string removeAcentos(string textoEntrada, OpcoesTexto opcoes)
        {
            if (string.IsNullOrEmpty(textoEntrada)) return textoEntrada;

            string busca = "áéíóúýàèìòùâêîôûãõäëïöüÿåçñ ÁÉÍÓÚÝÀÈÌÒÙÂÊÎÔÛÃÕÄËÏÖÜŸÅÇÑ ªº°¹²³";
            string troca = "aeiouyaeiouaeiouaoaeiouyacn AEIOUYAEIOUAEIOUAOAEIOUYACN aoo123";

            char[] texto = textoEntrada.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                // Pula linha
                if (texto[i] == '\r' || texto[i] == '\n')
                {
                    continue;
                }
                // Textos em ASCII baixo, mantém
                if (texto[i] >= 0x20 && texto[i] <= 0x7A)
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
        public static string AplicaMascara(string texto, string mascara)
        {
            if (texto is null) throw new ArgumentNullException(nameof(texto));
            if (mascara is null) throw new ArgumentNullException(nameof(mascara));

            if (mascara.Length == 0) throw new ArgumentException($"O parâmetro {nameof(mascara)} não pode ser vazio");

            StringBuilder sb = new StringBuilder(mascara.Length);
            int idxTexto = 0;
            for (int i = 0; i < mascara.Length && idxTexto < texto.Length; i++)
            {
                if (mascara[i] == '_')
                {
                    sb.Append(texto[idxTexto]);
                    idxTexto++;
                }
                else
                {
                    sb.Append(mascara[i]);
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Remove todos os caracteres, exceto letras e números
        /// </summary>
        /// <param name="texto">Texto a ser limpo</param>
        /// <returns>Texto desformatado</returns>
        public static string RemoveMascara(string texto)
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
    }
}

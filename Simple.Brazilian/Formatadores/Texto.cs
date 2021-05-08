using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.Brazilian.Formatadores
{
    public static class Texto
    {
        /// <summary>
        /// Torna o texto compatível com ASCII sem acentuação. 
        /// Letras acentuadas serão convertidas e outros caracteres serão descartados
        /// </summary>
        /// <param name="Texto">Texto a ser processado</param>
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


        public static string RemoveMascara(string texto)
        {
            throw new NotImplementedException();
        }
    }
}

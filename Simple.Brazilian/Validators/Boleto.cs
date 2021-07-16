using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Brazilian.Validators
{
    public static class Boleto
    {
        /// <summary>
        /// Executa cálculo do Mod10 no texto, retorna INT
        /// </summary>
        private static int Mod10(string str)
        {
            int mult = 2;
            int sum = 0;

            for (int i = (str.Length - 1); i >= 0; i--)
            {
                char c = str[i];

                int res = Convert.ToInt32(c.ToString()) * mult;
                sum += res > 9 ? (res - 9) : res;
                mult = mult == 2 ? 1 : 2;
            }

            int diferenca = 10 - (sum % 10);
            return diferenca % 10;
        }
        /// <summary>
        /// Executa cálculo do Mod10 no texto, retorna []INT
        /// </summary>
        public static int[] CalculateMod10_old(string LinhaDigitavelBoleto)
        {
            int[] camposDV = new int[3];
            int soma = 0;

            for (int i = 0; i < 29; i++)
            {
                int digito = Convert.ToInt32(LinhaDigitavelBoleto[i..(i + 1)]);
                int peso = i % 2 == 0 ? 2 : 1;

                int valor = digito * peso;

                if (valor < 10)
                {
                    soma += valor;
                }
                else
                {
                    int d1 = valor % 10;
                    int d2 = valor / 10;

                    soma += d1;
                    soma += d2;
                }

                if (i == 8) camposDV[0] = 30 - (soma % 10);
                if (i == 18) camposDV[1] = 40 - ((soma - camposDV[0]) % 10);
                if (i == 28) camposDV[2] = 40 - ((soma - (camposDV[0] + camposDV[1])) % 10);
            }
            return camposDV;
        }
    }
}

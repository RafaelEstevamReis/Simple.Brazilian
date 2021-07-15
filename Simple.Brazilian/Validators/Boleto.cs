using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Brazilian.Validators
{
    public static class Boleto
    {
        public static int[] CalculateMod10(string LinhaDigitavelBoleto)
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

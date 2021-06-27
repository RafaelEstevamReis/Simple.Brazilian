using System;

namespace Simple.Brazilian.Information.Places
{
    public class States
    {
        public static readonly string[] UF = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
        public static readonly string[] Names = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" };
        public static readonly int[] IdIBGE = { 12, 27, 13, 16, 29, 23, 53, 32, 52, 21, 31, 50, 51, 15, 25, 26, 22, 41, 33, 24, 11, 14, 43, 42, 28, 35, 17 };
        public static readonly string[] Capital = { "Rio Branco", "Maceió", "Macapá", "Manaus", "Salvador", "Fortaleza", "Brasília", "Vitória", "Goiânia", "São Luís", "Cuiabá", "Campo Grande", "Belo Horizonte", "Belém", "João Pessoa", "Curitiba", "Recife", "Teresina", "Rio de Janeiro", "Natal", "Porto Alegre", "Porto Velho", "Boa Vista", "Florianópolis", "São Paulo", "Aracaju", "Palmas" };
        public static readonly double[] AreaKm2 = { 164_122.2, 27_767.7, 142_814.6, 1_570_745.7, 564_692.7, 148_825.6, 5_822.1, 46_077.5, 340_086.7, 331_983.3, 903_357.9, 357_125.0, 586_528.3, 1_247_689.5, 56_439.8, 199_314.9, 98_311.6, 251_529.2, 43_696.1, 52_796.8, 281_748.5, 237_576.2, 224_299.0, 95_346.2, 248_209.4, 21_910.3, 277_620.9, };

        public State GetStateByUF(string uf) => getByIndex(UF.IndexOf(uf,  StringComparison.CurrentCultureIgnoreCase));
        public State GetStateByName(string name) => getByIndex(Names.IndexOf(name, StringComparison.CurrentCultureIgnoreCase));
        public State GetStateByName(int id) => getByIndex(IdIBGE.IndexOf(id));

        private State getByIndex(int index) => State.FromIndex(index);
    }
}

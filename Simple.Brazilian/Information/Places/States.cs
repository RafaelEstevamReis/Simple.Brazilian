namespace Simple.Brazilian.Information.Places;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Informações sobre estados
/// </summary>
public class States
{
    /// <summary>
    /// Lista de siglas de UFs em ordem alfabética 
    /// </summary>
    public static readonly string[] UF = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
    /// <summary>
    /// Lista de nomes de UFs em ordem alfabética de UF
    /// </summary>
    public static readonly string[] Names = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" };
    /// <summary>
    /// Lista de códigos do IBGE das UFs em ordem alfabética de UF
    /// </summary>
    public static readonly int[] IdIBGE = { 12, 27, 16, 13, 29, 23, 53, 32, 52, 21, 51, 50, 31, 15, 25, 41, 26, 22, 33, 24, 43, 11, 14, 42, 35, 28, 17 };
    /// <summary>
    /// Lista de capitais dos UFs em ordem alfabética de UF
    /// </summary>
    public static readonly string[] Capital = { "Rio Branco", "Maceió", "Macapá", "Manaus", "Salvador", "Fortaleza", "Brasília", "Vitória", "Goiânia", "São Luís", "Cuiabá", "Campo Grande", "Belo Horizonte", "Belém", "João Pessoa", "Curitiba", "Recife", "Teresina", "Rio de Janeiro", "Natal", "Porto Alegre", "Porto Velho", "Boa Vista", "Florianópolis", "São Paulo", "Aracaju", "Palmas" };
    /// <summary>
    /// Lista de área dos UFs em ordem alfabética de UF
    /// </summary>
    public static readonly double[] AreaKm2 = { 164_122.2, 27_767.7, 142_814.6, 1_570_745.7, 564_692.7, 148_825.6, 5_822.1, 46_077.5, 340_086.7, 331_983.3, 903_357.9, 357_125.0, 586_528.3, 1_247_689.5, 56_439.8, 199_314.9, 98_311.6, 251_529.2, 43_696.1, 52_796.8, 281_748.5, 237_576.2, 224_299.0, 95_346.2, 248_209.4, 21_910.3, 277_620.9, };

    private static readonly IStateData[] lstStateData = {
        new StateSpecific.RO(),
        new StateSpecific.AC(),
        new StateSpecific.AM(),
        new StateSpecific.RR(),
        new StateSpecific.PA(),
        new StateSpecific.AP(),
        new StateSpecific.TO(),
        new StateSpecific.MA(),
        new StateSpecific.PI(),
        new StateSpecific.CE(),
        new StateSpecific.RN(),
        new StateSpecific.PB(),
        new StateSpecific.PE(),
        new StateSpecific.AL(),
        new StateSpecific.SE(),
        new StateSpecific.BA(),
        new StateSpecific.MG(),
        new StateSpecific.ES(),
        new StateSpecific.RJ(),
        new StateSpecific.SP(),
        new StateSpecific.PR(),
        new StateSpecific.SC(),
        new StateSpecific.RS(),
        new StateSpecific.MS(),
        new StateSpecific.MT(),
        new StateSpecific.GO(),
        new StateSpecific.DF(),
    };
    private static readonly Dictionary<UFs, IStateData> dicStateData = lstStateData.ToDictionary(o => o.UF);

    private static CityInfo[] cityInfo = null;
    /// <summary>
    /// Obtém uma lista com todos os municípios, seus nomes e códigos IBGE
    /// </summary>
    public static CityInfo[] CityInfo
    {
        get
        {
            if (cityInfo == null) initializeCityInfo();
            return cityInfo;
        }
    }

    private static void initializeCityInfo()
    {
        cityInfo = retrieveCityData(Places.CityInfo.rawCityData).ToArray();
    }
    private static IEnumerable<CityInfo> retrieveCityData(string municipios)
    {
        StringReader str = new StringReader(municipios);
        string line;
        while ((line = str.ReadLine()) != null)
        {
            var data = line.Split('\t');
            if (data.Length < 3) continue;

            yield return new CityInfo()
            {
                IdState = int.Parse(data[0]),
                IdCity = int.Parse(data[1]),
                Name = data[2],
                CompleteId = data[0] + data[1],
            };
        }
    }

    /// <summary>
    /// Obtém um objeto "StateInfo"
    /// </summary>
    /// <param name="uf">Sigla da UF</param>
    public static StateInfo GetStateInfoByUF(string uf) => StateInfo.FromIndex(UF.IndexOf(uf, StringComparison.CurrentCultureIgnoreCase));
    /// <summary>
    /// Obtém um objeto "StateInfo"
    /// </summary>
    /// <param name="name">Nome da UF (com acentos)</param>
    public static StateInfo GetStateInfoByName(string name) => StateInfo.FromIndex(Names.IndexOf(name, StringComparison.CurrentCultureIgnoreCase));
    /// <summary>
    /// Obtém um objeto "StateInfo"
    /// </summary>
    /// <param name="id">Id do IBGE</param>
    public static StateInfo GetStateInfoByName(int id) => StateInfo.FromIndex(IdIBGE.IndexOf(id));
    /// <summary>
    /// Obtém um objeto "StateInfo"
    /// </summary>
    /// <param name="uf">Item do enum UFs</param>
    public static StateInfo GetStateInfo(UFs uf) => GetStateInfoByName((int)uf);
    /// <summary>
    /// Obtém o objeto IStateData para o UF desejado
    /// </summary>
    /// <exception cref="Exception">UF=EX não é permitido</exception>
    public static IStateData GetStateDataObject(UFs uf)
    {
        if (uf == UFs.EX) throw new Exception("EX não é um UF válido");
        return dicStateData[uf];
    }

}

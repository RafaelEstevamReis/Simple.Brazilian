using Simple.Brazilian.Documents;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CNPJTestes
{
    public class AlfanumericoTestes
    {
        [Theory]
        [InlineData("13.YVJ.S1L/0001-66")]
        [InlineData("16.RN7.71K/0001-35")]
        [InlineData("1S.XTV.ZMT/0001-58")]
        [InlineData("5J.DV5.DS9/0001-01")]
        [InlineData("5L.Y0H.JHE/0001-00")]
        [InlineData("5Z.549.SAG/0001-08")]
        [InlineData("9Z.6P2.0JW/0001-67")]
        [InlineData("AN.5ZG.9V9/0001-82")]
        [InlineData("CE.S79.CDG/0001-33")]
        [InlineData("GV.5KA.HB7/0001-72")]
        [InlineData("KW.Z1N.TM3/0001-09")]
        [InlineData("LT.0AN.17D/0001-39")]
        [InlineData("P3.0W9.7RJ/0001-90")]
        [InlineData("RG.KMM.YM4/0001-22")]
        [InlineData("VP.RWK.JKA/0001-17")]
        [InlineData("WG.R7T.50D/0001-20")]
        [InlineData("XX.PB2.4RJ/0001-89")]
        [InlineData("ZB.8JP.3RV/0001-64")]
        [InlineData("ZD.BLG.EEK/0001-32")]
        [InlineData("ZT.CLG.115/0001-51")]
        public void CNPJ_AlfaNumerico_IsValid_MatrizGeradosGovBR(string entrada)
        {
            Assert.True(CNPJ.IsValid(entrada));
        }


        [Theory]
        [InlineData("5Z.549.SAG/KBWG-66")]
        [InlineData("AN.5ZG.9V9/1XRL-61")]
        [InlineData("AN.5ZG.9V9/25AX-30")]
        [InlineData("AN.5ZG.9V9/7RNV-39")]
        [InlineData("AN.5ZG.9V9/9D3M-50")]
        [InlineData("AN.5ZG.9V9/9N5R-46")]
        [InlineData("AN.5ZG.9V9/9TL9-51")]
        [InlineData("AN.5ZG.9V9/AMXG-66")]
        [InlineData("AN.5ZG.9V9/NWA7-24")]
        [InlineData("AN.5ZG.9V9/Z71N-62")]
        [InlineData("AN.5ZG.9V9/ZGJA-30")]
        [InlineData("AN.5ZG.9V9/ZMW2-36")]
        [InlineData("P3.0W9.7RJ/4CE9-00")]
        [InlineData("P3.0W9.7RJ/EB1Y-24")]
        public void CNPJ_AlfaNumerico_IsValid_FilialGeradosGovBR(string entrada)
        {
            Assert.True(CNPJ.IsValid(entrada));
        }

        [Theory]
        [InlineData("13YVJS1L000166", "13.YVJ.S1L/0001-66")]
        [InlineData("16RN771K000135", "16.RN7.71K/0001-35")]
        [InlineData("5Z549SAGKBWG66", "5Z.549.SAG/KBWG-66")]
        [InlineData("AN5ZG9V91XRL61", "AN.5ZG.9V9/1XRL-61")]
        public void CNPJ_AlfaNumerico_Mask_GeradosGovBR(string entrada, string saida)
        {
            Assert.Equal(saida, CNPJ.Mask(entrada));
        }

        [Theory]
        [InlineData("13.YVJ.S1L/0001-66", "13YVJS1L000166")]
        [InlineData("16.RN7.71K/0001-35", "16RN771K000135")]
        [InlineData("5Z.549.SAG/KBWG-66", "5Z549SAGKBWG66")]
        [InlineData("AN.5ZG.9V9/1XRL-61", "AN5ZG9V91XRL61")]
        public void CNPJ_AlfaNumerico_Unmask_GeradosGovBR(string entrada, string saida)
        {
            Assert.Equal(saida, CNPJ.Unmask(entrada));
        }
    }
}

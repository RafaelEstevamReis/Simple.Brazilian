namespace Simple.Brazilian.Formatadores
{
    public class OpcoesTexto
    {
        // Uma vez definido, o padrão não deve ser alterado
        public static OpcoesTexto Padrao => new OpcoesTexto
        {
            CaracterPadraoSubstituicao = ' ',
        };

        public char CaracterPadraoSubstituicao { get; set; }


    }
}

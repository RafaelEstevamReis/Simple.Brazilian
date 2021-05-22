namespace Simple.Brazilian.Formatters
{
    /// <summary>
    /// Opções de texto
    /// </summary>
    public class OpcoesTexto
    {
        // Uma vez definido, o padrão não deve ser alterado
        /// <summary>
        /// Valor padrão para ser utilizado quando nenhuma opção é definida
        /// </summary>
        public static OpcoesTexto Padrao => new OpcoesTexto
        {
            CaracterPadraoSubstituicao = ' ',
        };
        /// <summary>
        /// Especifica o caractere que deverá ser utilizado para a substituição
        /// </summary>
        public char CaracterPadraoSubstituicao { get; set; }


    }
}

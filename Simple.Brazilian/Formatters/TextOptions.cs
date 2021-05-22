namespace Simple.Brazilian.Formatters
{
    /// <summary>
    /// Opções de texto
    /// </summary>
    public class TextOptions
    {
        // Uma vez definido, o padrão não deve ser alterado
        /// <summary>
        /// Valor padrão para ser utilizado quando nenhuma opção é definida
        /// </summary>
        public static TextOptions Padrao => new TextOptions
        {
            CaracterPadraoSubstituicao = ' ',
        };
        /// <summary>
        /// Especifica o caractere que deverá ser utilizado para a substituição
        /// </summary>
        public char CaracterPadraoSubstituicao { get; set; }


    }
}

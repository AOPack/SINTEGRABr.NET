using SintegraBr.Common;

namespace SintegraBr.Classes
{
    /// <summary>
    /// REGISTRO TIPO 11 - DADOS COMPLEMENTARES DO INFORMANTE
    /// </summary>
    public class Registro11 : RegistroBaseSintegra
    {
        public Registro11()
        {
            Tipo = "11";
        }

        /// <summary>
        /// Logradouro
        /// </summary>
        [SintegraCampos(2, "LOGRADOURO", "X", 34, 0, true)]
        public string Logradouro { get; set; }

        /// <summary>
        /// Número
        /// </summary>
        [SintegraCampos(3, "NUMERO", "N", 5, 0, true)]
        public string Numero { get; set; }

        /// <summary>
        /// Complemento
        /// </summary>
        [SintegraCampos(4, "COMPLEMENTO", "X", 22, 0, false)]
        public string Complemento { get; set; }

        /// <summary>
        /// Bairro
        /// </summary>
        [SintegraCampos(5, "BAIRRO", "X", 15, 0, true)]
        public string Bairro { get; set; }

        /// <summary>
        /// Código de Enderaçamento Postal
        /// </summary>
        [SintegraCampos(6, "CEP", "N", 8, 0, true)]
        public string Cep { get; set; }

        /// <summary>
        /// Pessoa responsável para contatos
        /// </summary>
        [SintegraCampos(7, "NOME DO CONTATO", "X", 28, 0, true)]
        public string NomeContato { get; set; }

        /// <summary>
        /// Número dos telefones para contatos
        /// </summary>
        [SintegraCampos(8, "TELEFONE", "N", 12, 0, true)]
        public string Telefone { get; set; }
    }
}

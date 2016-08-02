using System;
using SintegraBr.Common;

namespace SintegraBr.Classes
{
    public enum CodEstruturaArquivo
    {
        /// <summary>
        /// Estrutura conforme Convênio ICMS 57/95, na versão estabalecidade pelo Convênio
        /// ICMS 31/99 e com as alterações promovidas até o Convênio ICMS 30/02.
        /// </summary>
        Cod1 = 1,
        /// <summary>
        /// Estrutura conforme Convênio ICMS 57/95, na versão estabelecida pelo Convênio
        /// ICMS 69/02 e com as alterações promovidas pelo Convênio ICMS 142/02.
        /// </summary>
        Cod2 = 2,
        /// <summary>
        /// Estrutura conforme Convênio ICMS 57/95, com as alterações promovidas pelo
        /// Convênio ICMS 76/03.
        /// </summary>
        Cod3 = 3
    }

    public enum CodNaturezaOperacoes
    {
        /// <summary>
        /// Interestaduais somente operações sujeitas ao regime de Substituição Tributária
        /// </summary>
        Cod1 = 1,
        /// <summary>
        /// Interestaduais - operações com ou sem Substituição Tributária
        /// </summary>
        Cod2 = 2,
        /// <summary>
        /// Totalidade das operações do informante
        /// </summary>
        Cod3 = 3
    }

    public enum CodFinalidadeArquivo
    {
        /// <summary>
        /// Normal
        /// </summary>
        Cod1 = 1,
        /// <summary>
        /// Retificação total
        /// </summary>
        Cod2 = 2,
        /// <summary>
        /// Retificação aditiva (vedado)
        /// </summary>
        Cod3 = 3,
        /// <summary>
        /// Desfazimento
        /// </summary>
        Cod5 = 5
    }

    /// <summary>
    /// REGISTRO TIPO 10 - MESTRE DO ESTABELECIMENTO
    /// </summary>
    public class Registro10 : RegistroBaseSintegra
    {
        public Registro10()
        {
            Tipo = "10";
        }

        /// <summary>
        /// CGC/MF -> CNPJ do estabelecimento informante
        /// </summary>
        [SintegraCampos(2, "CNPJ", "N", 14, 0, true)]
        public string Cnpj { get; set; }

        /// <summary>
        /// Inscrição estadual do estabelecimento informante
        /// </summary>
        [SintegraCampos(3, "INSCRIÇÃO ESTADUAL", "X", 14, 0, true)]
        public string InscrEstadual { get; set; }

        /// <summary>
        /// Nome comercial (razão social/denominação) do contribuinte
        /// </summary>
        [SintegraCampos(4, "NOME DO CONTRIBUINTE", "X", 35, 0, true)]
        public string NomeContribuinte { get; set; }

        /// <summary>
        /// Município onde está domiciliado o estabelecimento informante
        /// </summary>
        [SintegraCampos(5, "MUNICÍPIO", "X", 30, 0, true)]
        public string Municipio { get; set; }

        /// <summary>
        /// Unidade da federação referente ao município
        /// </summary>
        [SintegraCampos(6, "UF", "X", 2, 0, true)]
        public string Uf { get; set; }

        /// <summary>
        /// Número do fax do estabelecimento informante
        /// </summary>
        [SintegraCampos(7, "FAX", "N", 10, 0, true)]
        public string Fax { get; set; }

        /// <summary>
        /// A data de início do período referente às informações prestadas
        /// </summary>
        [SintegraCampos(8, "DATA INICIAL", "N", 8, 0, true)]
        public DateTime DataInicial { get; set; }

        /// <summary>
        /// A data do fim do período referente às informações prestadas
        /// </summary>
        [SintegraCampos(9, "DATA FINAL", "N", 8, 0, true)]
        public DateTime DataFinal { get; set; }

        /// <summary>
        /// Código da identificação da estrutura do arquivo magnético entregue
        /// </summary>
        [SintegraCampos(10, "CÓDIGO DA ESTRUTURA", "X", 1, 0, true)]
        public int CodEstrutura { get; set; }

        /// <summary>
        /// Código da identificação da natureza das operações informadas
        /// </summary>
        [SintegraCampos(11, "CÓDIGO DAS OPERAÇÕES", "X", 1, 0, true)]
        public int CodOperacoes { get; set; }

        /// <summary>
        /// Código de finalidade utilizado no arquivo magnético
        /// </summary>
        [SintegraCampos(12, "CÓDIGO DA FINALIDADE", "X", 1, 0, true)]
        public int CodFinalidade { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    public class Registro10 : RegistroBaseSintegra
    {
        public Registro10()
        {
            Tipo = "10";
        }

        [SintegraCampos(2, "CGC/MF", "N", 14, 0, true)]
        public string CgcMf { get; set; }

        [SintegraCampos(3, "INSCRIÇÃO ESTADUAL", "X", 14, 0, true)]
        public string InscricaoEstadual { get; set; }

        [SintegraCampos(4, "NOME DO CONTRIBUINTE", "X", 35, 0, true)]
        public string NomeContribuinte { get; set; }

        [SintegraCampos(5, "MUNICÍPIO", "X", 30, 0, true)]
        public string Municipio { get; set; }

        [SintegraCampos(6, "UF", "X", 2, 0, true)]
        public string Uf { get; set; }

        [SintegraCampos(7, "FAX", "N", 10, 0, true)]
        public string Fax { get; set; }

        [SintegraCampos(8, "DATA INICIAL", "N", 8, 0, true)]
        public DateTime DataInicial { get; set; }

        [SintegraCampos(9, "DATA FINAL", "N", 8, 0, true)]
        public DateTime DataFinal { get; set; }

        [SintegraCampos(10, "CÓDIGO DA ESTRUTURA", "X", 1, 0, true)]
        public int CodEstrutura { get; set; }

        [SintegraCampos(11, "CÓDIGO DAS OPERAÇÕES", "X", 1, 0, true)]
        public int CodOperacoes { get; set; }

        [SintegraCampos(12, "CÓDIGO DA FINALIDADE", "X", 1, 0, true)]
        public int CodFinalidade { get; set; }
    }
}

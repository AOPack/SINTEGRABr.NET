using System;
using System.Collections.Generic;
using SintegraBr.Common;

namespace SintegraBr.Classes
{
    /// <summary>
    /// REGISTRO TIPO 90 - TOTALIZAÇÃO DO ARQUIVO
    /// </summary>
    public class Registro90
    {
        public class Registro90Temp
        {
            public string TIPO_A_SER_TOTALIZADO { get; set; }

            public int TOTAL_DE_REGISTROS { get; set; }
        }

        private string TIPO
        {
            get { return "90"; }
        }

        private string CNPJ { get; set; }

        private string IE { get; set; }

        private List<Registro90Temp> TotalizadoresDeRegistros { get; set; }

        private string NUMERO_REGISTROS_TIPO_90 { get; set; }

        public Registro90(string inscrCnpj, string inscrEstadual, List<string> linhas)
        {
            var registros = new List<Registro90.Registro90Temp>();

            foreach (var linha in linhas)
            {
                if (linha != null)
                {
                    string registroAtual = linha.Substring(0, 2);

                    if (registroAtual != "10" && registroAtual != "11")
                    {
                        //bool contemRegistroAtual = registros.Count(ct => ct.TIPO_A_SER_TOTALIZADO == registroAtual) > 0;
                        bool contemRegistroAtual = registros.Exists(ext => ext.TIPO_A_SER_TOTALIZADO == registroAtual);

                        if (contemRegistroAtual)
                            registros.Find(f => f.TIPO_A_SER_TOTALIZADO == registroAtual).TOTAL_DE_REGISTROS += 1;
                        else
                            registros.Add(new Registro90Temp()
                            {
                                TIPO_A_SER_TOTALIZADO = registroAtual,
                                TOTAL_DE_REGISTROS = 1
                            });
                    }
                }
            }

            this.CNPJ = inscrCnpj;
            this.IE = inscrEstadual;

            registros.Add(new Registro90Temp() {TIPO_A_SER_TOTALIZADO = "99", TOTAL_DE_REGISTROS = linhas.Count + 1});

            this.TotalizadoresDeRegistros = registros;
        }

        /// <summary>
        /// Efetua a escrita do Registro 90 do arquivo.
        /// </summary>
        /// <returns>String</returns>
        public string EscreverRegistro90()
        {
            int tamanhoPosicaoTipo = 2;
            int posicaoInicialTipo = 31;

            int tamanhoPosicaoTotal = 8;
            int posicaoInicialTotal = 33;

            var r90 = new string(' ', 126);
            try
            {
                r90 = r90.PreencherValorNaLinha(1, 2, TIPO.PadLeft(2, ' '));
                r90 = r90.PreencherValorNaLinha(3, 16, CNPJ.PadLeft(14, ' '));
                r90 = r90.PreencherValorNaLinha(17, 30, IE.PadRight(14, ' '));

                foreach (var registroAtual in TotalizadoresDeRegistros)
                {
                    r90 = r90.PreencherValorNaLinha(posicaoInicialTipo, (posicaoInicialTipo + (tamanhoPosicaoTipo - 1)),
                        registroAtual.TIPO_A_SER_TOTALIZADO);
                    r90 = r90.PreencherValorNaLinha(posicaoInicialTotal,
                        (posicaoInicialTotal + (tamanhoPosicaoTotal - 1)),
                        registroAtual.TOTAL_DE_REGISTROS.ToString().PadLeft(8, '0'));

                    posicaoInicialTipo = posicaoInicialTotal + tamanhoPosicaoTotal;
                    posicaoInicialTotal = posicaoInicialTipo + tamanhoPosicaoTipo;
                }

                r90 = r90.PreencherValorNaLinha(126, 126, "1");

                return r90;
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao gerar registro tipo 90." + Environment.NewLine + e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SintegraBr.Classes;
using SintegraBr.Common;

namespace SintegraBr.Tests
{
    [TestClass]
    public class GeracaoUnitTests
    {
        [TestMethod]
        public void GerarRegistro10()
        {
            var r10 = new Registro10(
                Cnpj: "01234567000899",
                Ie: "1012345678",
                RazaoSocial: "EMPRESA DE TESTE",
                Municipio: "CIDADE DE DEUS",
                Uf: "GO",
                Fax: "123456789",
                DataInicial: DateTime.Now.ObterPrimeiroDiaMesAtual(),
                DataFinal: DateTime.Now.ObterUltimoDiaMesAtual(),
                CodFin: CodFinalidadeArquivo.Cod1
                );

            var result = r10.EscreverCampos();
        }

        [TestMethod]
        public void GerarRegistro11()
        {
            var r11 = new Registro11(
                Logradouro: "RUA SEM NOME PARA TESTE",
                Numero: "",
                Complemento: "",
                Bairro: "CENTRO",
                Cep: "36900000",
                NomeContato: "ADEMERIO EDUARDO MOREIRA",
                NumeroContato: "3333315808"
                );

            var result = r11.EscreverCampos();
        }

        [TestMethod]
        public void GerarRegistro90()
        {
            var linhas = new List<string>();

            var r50 = new Registro50();

            // Exemplo de nota de compra de material p/ uso ou consumo (copos descartáveis por exemplo)
            r50.Cnpj = "01234567000899";
            r50.InscrEstadual = "1012345678";
            r50.DataEmissaoRecebimento = DateTime.Now;
            r50.Uf = "GO";
            r50.Modelo = 55;
            r50.Serie = "001";
            r50.Numero = 123456;
            r50.Cfop = 1556;
            r50.Emitente = "T";
            r50.ValorTotal = 50.55M;
            r50.ValorOutras = 50.55M;
            r50.SituacaoNotaFiscal = "N";

            var result = r50.EscreverCampos();

            linhas.Add(result);

            var r90 = new Registro90("01234567000899", "1012345678", linhas);

            var arquivo = r90.EscreverRegistro90();
        }
    }
}

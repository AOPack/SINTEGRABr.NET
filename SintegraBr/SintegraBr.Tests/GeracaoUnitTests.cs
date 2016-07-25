using System;
using System.Text;
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
            var r10 = new Registro10();

            r10.CgcMf = "01234567000899";
            r10.InscricaoEstadual = "1012345678";
            r10.NomeContribuinte = "EMPRESA DE TESTE";
            r10.Municipio = "CIDADE DE DEUS";
            r10.Uf = "DF";
            r10.Fax = "123456789";
            r10.DataInicial = DateTime.Now.ObterPrimeiroDiaMesAtual();
            r10.DataFinal = DateTime.Now.ObterUltimoDiaMesAtual();
            r10.CodEstrutura = 3;
            r10.CodOperacoes = 3;
            r10.CodFinalidade = 1;

            var result = r10.EscreverCampos();
        }
    }
}

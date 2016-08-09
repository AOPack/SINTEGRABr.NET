using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SintegraBr.Common;

namespace SintegraBr.Tests
{
    [TestClass]
    public class ValidacaoUnitTests
    {
        /// <summary>
        /// Validar I.E. utilizando DLL do Sintegra
        /// </summary>
        [TestMethod]
        public void ConsisteInscricaoEstadualValida()
        {
            var result = ValidarIe.ConsisteInscricaoEstadual("INSCR_ESTADUAL", "GO");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ConsisteInscricaoEstadualInvalida()
        {
            var result = ValidarIe.ConsisteInscricaoEstadual("012345678", "GO");

            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// Validar I.E. por UF
        /// </summary>
        [TestMethod]
        public void ValidarInscricaoEstadualTrue()
        {
            var result = ValidarIe.Validar("INSCR_ESTADUAL", "GO");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ValidarInscricaoEstadualFalse()
        {
            var result = ValidarIe.Validar("012345678", "UF");

            Assert.AreEqual(false, result);
        }
    }
}

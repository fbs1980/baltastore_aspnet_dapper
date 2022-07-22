using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Tests.ValueObjects
{
    public class NameTests
    {

        [TestMethod]
        public void RetornaNotificacaoNomeInvalido()
        {
            var nome = new Name("", "Felipe");
            Assert.AreEqual(false, nome.IsValid);
            Assert.AreEqual(1, nome.Notifications.Count);
        }
    }
}

using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]

    public class DocumentTests
    {
        private readonly Document DocumentoValido;

        private readonly Document DocumentoInvalido;

        public DocumentTests()
        {
            DocumentoValido = new Document("28659170377");
            DocumentoInvalido = new Document("12345678910");
        }

        [TestMethod]
        public void RetornaNotificacaoDocumentoInvalido()
        {            
            Assert.AreEqual(false, DocumentoInvalido.IsValid);
            Assert.AreEqual(1, DocumentoInvalido.Notifications.Count);
        }

        [TestMethod]
        public void RetornaNotificacaoDocumentoValido()
        {
            Assert.AreEqual(true, DocumentoValido.IsValid);
            Assert.AreEqual(0, DocumentoValido.Notifications.Count);
        }        
    }
}
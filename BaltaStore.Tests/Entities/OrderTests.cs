

using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        private Customer _customer;

        public OrderTests()
        {
            var name = new Name("Felipe", "Bastos");
            var document = new Document("46718115533");
            var email = new Email("hello@balta.io");
            _customer = new Customer(name, document, email, "551999876542", "Rua Sete");
        }

        // Consigo criar novo pedido
        [TestMethod]
        public void CriarPedidoValido()
        {            
            var order = new Order(_customer);
            Assert.AreEqual(true, order.IsValid);
        }


        // Ao criar o pedio o status deve ser created
        [TestMethod]
        public void StatusPedidoCriado()
        {
            Assert.Fail();
        }


        // Ao adicionar o novo item, a quantidade de itens deve mudar
        [TestMethod]
        public void RetornaDoisQuandoAdicionaDoisItens()
        {
            Assert.Fail();
        }


        // Ao adicionar um novo item, deve subtrair a quantidade do produto
        [TestMethod]
        public void RetornaCincoQuandoCompradoCincoItens()
        {
            Assert.Fail();
        }


        // Ao confirmar pedido, deve gerar um número
        [TestMethod]
        public void RetornaNumeroQuandoPedido()
        {
            Assert.Fail();
        }


        // Ao pagar um pedido, o status deve ser PAGO
        [TestMethod]
        public void RetornaPagoQuandoPedidoPago()
        {
            Assert.Fail();
        }


        // Dados mais 10 produtos, devem haver duas entregas
        [TestMethod]
        public void RetornaDoisQuandoCromprarDez()
        {
            Assert.Fail();
        }


        // Ao cancelar o pedido, o status deve ser cancelado
        [TestMethod]
        public void StatusCanceladoQuandoPedidoCancelado()
        {
            Assert.Fail();
        }


        // Ao cancelar o pedido, deve cancelar as entregas
        [TestMethod]
        public void EntregaCanceladaQuandoPedidoCancelado()
        {
            Assert.Fail();
        }
    }
}

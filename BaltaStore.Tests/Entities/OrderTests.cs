

using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Enums;
using BaltaStore.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        private Customer _customer;
        private Order _order;
        private Product _mouse;
        private Product _keyboard;
        private Product _chair;
        private Product _monitor;

        public OrderTests()
        {
            var name = new Name("Felipe", "Bastos");
            var document = new Document("46718115533");
            var email = new Email("hello@balta.io");
            _customer = new Customer(name, document, email, "551999876542", "Rua Sete");
            _order = new Order(_customer);

            _mouse = new Product("Mouse Gamer", "Mouse Gamer", "mouse.jpg", 100M, 10);
            _keyboard = new Product("Teclado Gamer", "Teclado Game", "Teclado.jpg", 100M, 10);
            _chair = new Product("Cadeira Gamer", "Cadeira Gamer", "Cadeira.jpg", 100M, 10);
            _monitor = new Product("Monitor Gamer", "Monitor Gamer", "Monitor.jpg", 100M, 10);
        }

        // Consigo criar novo pedido
        [TestMethod]
        public void CriarPedidoValido()
        {            
            Assert.AreEqual(true, _order.IsValid);
        }


        // Ao criar o pedido, o status deve ser created
        [TestMethod]
        public void StatusPedidoCriado()
        {
            Assert.AreEqual(EOrderStatus.Created, _order.Status);
        }


        // Ao adicionar o novo item, a quantidade de itens deve mudar
        [TestMethod]
        public void RetornaDoisQuandoAdicionaDoisItens()
        {
            _order.AddItem(_monitor, 5);
            _order.AddItem(_mouse, 5);
            Assert.AreEqual(2, _order.Items.Count);
        }


        // Ao adicionar um novo item, deve subtrair a quantidade do produto
        [TestMethod]
        public void RetornaCincoQuandoCompradoCincoItens()
        {
            _order.AddItem(_mouse, 5);
            Assert.AreEqual(_mouse.QuantityOnHand, 5);
        }


        // Ao confirmar pedido, deve gerar um número
        [TestMethod]
        public void RetornaNumeroQuandoPedido()
        {
            _order.Place();
            Assert.AreNotEqual("", _order.Number);
        }


        // Ao pagar um pedido, o status deve ser PAGO
        [TestMethod]
        public void RetornaPagoQuandoPedidoPago()
        {
            _order.Pay();
            Assert.AreEqual(EOrderStatus.Paid, _order.Status);
        }


        // Dados mais 10 produtos, devem haver duas entregas
        [TestMethod]
        public void RetornaDoisQuandoCromprarDez()
        {
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.Shipp();

            Assert.AreEqual(2, _order.Deliveries.Count);
        }


        // Ao cancelar o pedido, o status deve ser cancelado
        [TestMethod]
        public void StatusCanceladoQuandoPedidoCancelado()
        {
            _order.Cancel();
            Assert.AreEqual(EOrderStatus.Canceled, _order.Status);
        }


        // Ao cancelar o pedido, deve cancelar as entregas
        [TestMethod]
        public void EntregaCanceladaQuandoPedidoCancelado()
        {
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.AddItem(_mouse, 1);
            _order.Shipp();

            _order.Cancel();
            foreach (var x in _order.Deliveries)
            {
                Assert.AreEqual(EDeliveryStatus.Canceled, x.Status);
            }            
        }
    }
}

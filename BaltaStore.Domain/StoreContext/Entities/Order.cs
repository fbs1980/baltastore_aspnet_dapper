using BaltaStore.Domain.StoreContext.Enums;

namespace BaltaStore.Domain.StoreContext.Entities
{
    internal class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,8).ToUpper();
        }
        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public IList<Delivery> Deliveries { get; private set; }

        //to Place An Order
        public void Place()
        {

        }

    }
}

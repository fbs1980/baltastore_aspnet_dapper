namespace BaltaStore.Domain.StoreContext.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
    }
}

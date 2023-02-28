namespace _4_Exercicio_3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }
        public OrderItem(int quantity)
        {
            Quantity = quantity;
            Price = Product.Price;
        }

        //Tem price em duas classes diferentes, pois o valor do produto pode mudar, mas não nos pedidos feitos,
        //por isso, para manter o histórico na hora da compra, mantemos o preço no pedido também.

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}

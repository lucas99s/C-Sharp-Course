using System;
using System.Collections.Generic;
using System.Text;
using _4_Exercicio_3.Entities.Enums;

namespace _4_Exercicio_3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem t in Items)
            {
                sum += t.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("ORDER SUMARY:");
            s.Append("Order moment: ");
            s.AppendLine(Moment.ToString("dd/MM/yyyy HH/mm/ss"));
            s.Append("Order status: ");
            s.AppendLine(Status.ToString());
            s.Append("Client: ");
            s.AppendLine($"{Client.Name} ({Client.BirthDate}) - {Client.Email}");
            s.AppendLine("Order items:");
            foreach(OrderItem i in Items)
            {
                s.AppendLine($"{i.Product.Name} $ {i.Price}, {i.SubTotal()}");
            }
            s.AppendLine(Total().ToString());
            return s.ToString();
        }
    }
}

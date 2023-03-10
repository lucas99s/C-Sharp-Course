using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Exercicio_2.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customFee) :base(name, price)
        {
            CustomFee = customFee;
        }
        public override string PriceTag()
        {
            return $"{Name}, $ {TotalPrice():F2} (Customs fee: {CustomFee:F2})";
        }
        public string TotalPrice()
        {
            return $"{Price + CustomFee}";
        }
    }
}

using System;

namespace BT3
{
    public class Product
    {

        public Product(string id, string productName, int quantity, decimal price, string origin, DateTime expirationDate)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
            Origin = origin;
            ExpirationDate = expirationDate;
        }
        public string Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
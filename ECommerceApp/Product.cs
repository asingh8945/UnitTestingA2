using System;

namespace ECommerceApp
{
    public class Product
    {
        // Properties
        public int ProdID { get; private set; }
        public string ProdName { get; private set; }
        public decimal ItemPrice { get; private set; }
        public int StockAmount { get; private set; }

        // Constructor
        public Product(int prodID, string prodName, decimal itemPrice, int stockAmount)
        {
            if (prodID < 5 || prodID > 50000) throw new ArgumentException("Product ID must be between 5 and 50000.");
            if (itemPrice < 5 || itemPrice > 5000) throw new ArgumentException("Price must be between $5 and $5000.");
            if (stockAmount < 5 || stockAmount > 500000) throw new ArgumentException("Stock must be between 5 and 500000.");
            if (string.IsNullOrWhiteSpace(prodName)) throw new ArgumentException("Product name cannot be empty.");

            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        // Increase Stock
        public void IncreaseStock(int amount)
        {
            if (amount < 0) throw new ArgumentException("Increase amount must be positive.");
            StockAmount += amount;
        }

        // Decrease Stock
        public void DecreaseStock(int amount)
        {
            if (amount < 0) throw new ArgumentException("Decrease amount must be positive.");
            if (StockAmount - amount < 0) throw new InvalidOperationException("Stock cannot be negative.");
            StockAmount -= amount;
        }
    }
}

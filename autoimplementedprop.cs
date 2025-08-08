using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsDataTypes
{
    internal class autoimplementedprop
    {
        public autoimplementedprop() { }

        // Auto-implemented properties
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public double CalculateTotalPrice()
        {
            return ProductPrice * ProductQuantity;
        }
        public double ApplyDiscount(double discountPercentage)
        {
            double discountAmount = (discountPercentage / 100) * CalculateTotalPrice();
            return CalculateTotalPrice() - discountAmount;
        }

        
        public void CheckInventory()
        {
            if (ProductQuantity <= 0)
            {
                Console.WriteLine("Product is out of stock.");
            }
            else
            {
                Console.WriteLine($"Current inventory: {ProductQuantity} units.");
            }
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Product Price: ${ProductPrice}");
            Console.WriteLine($"Product Quantity: {ProductQuantity}");
            Console.WriteLine($"Total Price: ${CalculateTotalPrice()}");
        }
    }
}

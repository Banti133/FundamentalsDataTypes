using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsDataTypes
{
    internal class ProductClass
    {
        private string productname;
        private double productprice;
        private int productquantity;
        private int finalquantity=5;

        //constructor is used to create the instance of the object
        public ProductClass() //default constructor
        { 
        }

        //parameterized constructor
        public ProductClass(string name, double price, int quantity)
        {
            productname = name; //initialization of the instance variables
            productprice = price;
            productquantity = quantity;
        }
        //properties to access the private variables
        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public double ProductPrice
        {
            get { return productprice; }
            set { productprice = value; }
        }
        public int ProductQuantity
        {
            get { return productquantity; }
            set { productquantity = value; }
        }
        //method to calculate the total price of the product
        public double CalculateTotalPrice()
        {
            return productprice * productquantity;
        }
        //method to apply discount
        public double ApplyDiscount(double discountPercentage)
        {
            double discountAmount = (discountPercentage / 100) * CalculateTotalPrice();
            return CalculateTotalPrice() - discountAmount;
        }
        //method to restock the product
        public void Restock(int additionalQuantity)
        {
            //int pro = 5;
            if(finalquantity < productquantity)
            {
                Console.WriteLine("Insufficient quantity.");
            }
            finalquantity = finalquantity - productquantity;
            finalquantity += additionalQuantity;
            Console.WriteLine($"{additionalQuantity} items added. New quantity: {finalquantity}");

        }


        //method to display the product details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product name: {productname}");
            Console.WriteLine($"Product price: ${productprice}");
            Console.WriteLine($"Product quantity: {productquantity}");
            Console.WriteLine("Final Discounted Price: " + CalculateTotalPrice());
        }
        public void CheckInventory()
        {
            Console.WriteLine("\n--- Checking inventory details ---");
            if (finalquantity < 10)
            {
                Console.WriteLine("Stock is low. Consider restocking soon.");
            }
            else if (finalquantity > 100)
            {
                Console.WriteLine("Stock is high. Monitor sales to avoid overstock.");
            }
            else
            {
                Console.WriteLine("Stock level is optimal.");
            }

            if (productprice > 1000)
            {
                Console.WriteLine("High-value product. Ensure security and proper handling.");
            }
            else if (productprice < 10)
            {
                Console.WriteLine("Low-value product. Consider promotional offers.");
            }
            else
            {
                Console.WriteLine("Product price is within normal range.");
            }
        }
    }

}

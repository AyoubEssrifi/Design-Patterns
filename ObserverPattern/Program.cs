using System;
using System.Net.Http.Headers;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject product = new Subject("Iphone", 1000, "Out of stock");
            Observer user1 = new Observer("Ayoub", product);
            Observer user2 = new Observer("Najwa", product);

            Console.WriteLine("The product " + product.ProductName + " is " + product.Availability);

            product.Availability = "Available";
        }
    }
}

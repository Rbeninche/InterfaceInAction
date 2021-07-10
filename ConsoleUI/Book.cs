using System;

namespace ConsoleUI
{
    public class Book : Inventory, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("Book has been purchased");
        }
    }
}

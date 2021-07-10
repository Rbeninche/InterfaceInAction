using System;

namespace ConsoleUI
{
    public class Equipment : Inventory, IRentable
    {
        public void EquipmentStatus()
        {
            Console.WriteLine("I'm available in stock");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("Vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("Vehicle has been returned");
        }
    }
}

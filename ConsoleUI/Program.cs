using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Inventory> inventory = new List<Inventory>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var book = new Book { ProductName = "Rich dad, poor dad", NumberOfPages = 300 };
            var vehicle = new Vehicle { DealerFee = 30, ProductName = "Toyota Camry" };

            var equipment = new Equipment { ProductName = " Computer", QuantityInStock = 3 };

            rentables.Add(vehicle);
            purchasables.Add(book);
            rentables.Add(equipment);

            //It is better to use multiple interfaces. If we had used classedwe would have to use if statement and check each datatypes(class).
            // This approach will use lots of CPU
            //For instance

            List<Inventory> inventory = new List<Inventory>();
            inventory.Add(book);
            inventory.Add(equipment);
            inventory.Add(vehicle);

            foreach (var item in inventory)
            {
                if(item is Book b)
                {
                    b.Purchase();
                }if(item is Vehicle v)
                {
                    v.Rent();
                    v.ReturnRental();

                }
                if(item is Equipment e)
                {
                    e.Rent();
                    e.EquipmentStatus();

                    
                }

            }



            Console.ReadLine();
        }
    }
}

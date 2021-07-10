namespace ConsoleUI
{
    public interface IInventory
    {
        string ProductName { get; set; }

        int QuantityInStock { get; set; }
    }
}

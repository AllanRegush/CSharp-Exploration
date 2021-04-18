namespace ConsoleUI.Interfaces
{
    public interface IInventoryItem
    {
        string ProductName { get; set; }
        int NumberInStock { get; set; }
    }
}

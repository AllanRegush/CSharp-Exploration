namespace ConsoleUI.Interfaces
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnItem();
    }
}

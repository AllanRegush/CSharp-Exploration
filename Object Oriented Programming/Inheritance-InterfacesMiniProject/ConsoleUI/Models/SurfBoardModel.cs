using ConsoleUI.Interfaces;

namespace ConsoleUI.Models
{
    public class SurfBoardModel : InventoryModel, IRentable
    {
        public void Rent()
        {
            NumberInStock -= 1;
        }

        public void ReturnItem()
        {
            NumberInStock += 1;
        }
    }
}

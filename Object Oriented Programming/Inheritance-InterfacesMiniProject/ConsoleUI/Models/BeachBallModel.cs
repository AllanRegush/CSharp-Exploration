using ConsoleUI.Interfaces;

namespace ConsoleUI.Models
{
    public class BeachBallModel : InventoryModel, IPurchasable, IRentable
    {
        public void Purchase()
        {
            NumberInStock -= 1;
        }

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

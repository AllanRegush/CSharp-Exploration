using ConsoleUI.Interfaces;

namespace ConsoleUI.Models
{
    public class SunScreenModel : InventoryModel, IPurchasable
    {
        public void Purchase()
        {
            NumberInStock -= 1;
        }
    }
}

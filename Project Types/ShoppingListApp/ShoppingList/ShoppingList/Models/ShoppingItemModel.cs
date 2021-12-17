using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Models
{
    internal class ShoppingItemModel
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public bool IsCrossedOff { get; set; }
    }
}

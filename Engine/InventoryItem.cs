using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //인벤토리 아이템
    public class InventoryItem
    {
        //인벤토리 요소
        public Item Details { get; set; }
        public int Quantity { get; set; }

        //생성자
        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }

    }
}

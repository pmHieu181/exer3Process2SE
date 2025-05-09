using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process2
{
    internal class ItemService
    {
        private readonly ItemRepository _itemRepo = new ItemRepository();

        public void AddItem(Item item)
        {
            _itemRepo.InsertItem(item);
        }

        public DataTable FilterItems(string itemName, string size)
        {
            return _itemRepo.FilterItems(itemName, size);
        }
        public DataTable GetTopPurchasedItems()
        {
            return _itemRepo.GetTopPurchasedItems();
        }
    }
}

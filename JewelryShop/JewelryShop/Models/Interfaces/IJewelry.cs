using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Models.Interfaces
{
    public interface IJewelry
    {

        Task CreateItem(JewelryItem item);

        Task UpdateItem(int id, JewelryItem item);

        Task<JewelryItem> DeleteItem(int id);

        Task DeleteItemFR(int id);


        Task<JewelryItem> GetItem(int id);

        Task<IEnumerable<JewelryItem>> GetItems();

        bool ItemExists(int id);
    }
}

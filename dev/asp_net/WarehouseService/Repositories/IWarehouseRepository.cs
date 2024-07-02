using WarehouseService.Models;

namespace WarehouseService.Repositories
{
    public interface IWarehouseRepository
    {
        IEnumerable<WarehouseItem> GetAllItems();
        WarehouseItem GetItemById(int id);
        void AddItem(WarehouseItem item);
        void UpdateItem(WarehouseItem item);
        void DeleteItem(int id);
    }

}

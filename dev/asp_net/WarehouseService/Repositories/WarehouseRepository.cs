using WarehouseService.Models;

namespace WarehouseService.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly WarehouseDbContext _context;

        public WarehouseRepository(WarehouseDbContext context)
        {
            _context = context;
        }

        public IEnumerable<WarehouseItem> GetAllItems()
        {
            return _context.WarehouseItems.ToList();
        }

        public WarehouseItem GetItemById(int id)
        {
            return _context.WarehouseItems.Find(id);
        }

        public void AddItem(WarehouseItem item)
        {
            _context.WarehouseItems.Add(item);
            _context.SaveChanges();
        }

        public void UpdateItem(WarehouseItem item)
        {
            _context.WarehouseItems.Update(item);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = _context.WarehouseItems.Find(id);
            if (item != null)
            {
                _context.WarehouseItems.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}

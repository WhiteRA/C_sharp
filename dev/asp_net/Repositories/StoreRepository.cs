using asp_net.Data;
using asp_net.Models;

namespace asp_net.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _context;

        public StoreRepository(StoreDbContext context)
        {
            _context = context;
        }

        public bool DeleteGroup(int groupId)
        {
            var group = _context.Groups.Find(groupId);
            if (group != null)
            {
                _context.Groups.Remove(group);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Product SetPrice(int productId, decimal newPrice)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                product.Price = newPrice;
                _context.SaveChanges();
                return product;
            }
            return null;
        }
    }

}

using asp_net.Models;

namespace asp_net.Repositories
{
    public interface IStoreRepository
    {
        bool DeleteGroup(int groupId);
        bool DeleteProduct(int productId);
        Product SetPrice(int productId, decimal newPrice);
    }

}

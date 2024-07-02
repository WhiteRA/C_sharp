using asp_net.Models;
using asp_net.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace asp_net.Controllers
{
    

    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpDelete("groups/{groupId}")]
        public ActionResult<DeleteResponseModel> DeleteGroup(int groupId)
        {
            var result = _storeRepository.DeleteGroup(groupId);
            if (result)
            {
                return Ok(new DeleteResponseModel { Message = "Group deleted successfully." });
            }
            return NotFound(new DeleteResponseModel { Message = "Group not found." });
        }

        [HttpDelete("products/{productId}")]
        public ActionResult<DeleteResponseModel> DeleteProduct(int productId)
        {
            var result = _storeRepository.DeleteProduct(productId);
            if (result)
            {
                return Ok(new DeleteResponseModel { Message = "Product deleted successfully." });
            }
            return NotFound(new DeleteResponseModel { Message = "Product not found." });
        }

        [HttpPut("products/{productId}/price")]
        public ActionResult<ProductResponseModel> SetPrice(int productId, [FromBody] decimal newPrice)
        {
            var product = _storeRepository.SetPrice(productId, newPrice);
            if (product != null)
            {
                return Ok(new ProductResponseModel
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Price = product.Price,
                    Message = "Price updated successfully."
                });
            }
            return NotFound(new ProductResponseModel { Message = "Product not found." });
        }
    }

}

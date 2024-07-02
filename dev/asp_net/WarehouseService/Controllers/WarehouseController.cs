using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Repositories;

namespace WarehouseService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseRepository _repository;

        public WarehouseController(IWarehouseRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<WarehouseItem>> GetAllItems()
        {
            return Ok(_repository.GetAllItems());
        }

        [HttpGet("{id}")]
        public ActionResult<WarehouseItem> GetItemById(int id)
        {
            var item = _repository.GetItemById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public ActionResult AddItem([FromBody] WarehouseItem item)
        {
            _repository.AddItem(item);
            return CreatedAtAction(nameof(GetItemById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, [FromBody] WarehouseItem item)
        {
            if (id != item.Id)
                return BadRequest();
            _repository.UpdateItem(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            _repository.DeleteItem(id);
            return NoContent();
        }
    }

}

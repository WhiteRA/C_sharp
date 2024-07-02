using asp_net.Models;
using asp_net.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO;
using CsvHelper;
using System.Formats.Asn1;

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

        [HttpGet("products/csv")]
        public IActionResult GetProductsCsv()
        {
            var products = _storeRepository.GetAllProducts();
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(products);
            }

            memoryStream.Position = 0;
            return File(memoryStream, "text/csv", "products.csv");
        }
    }

}

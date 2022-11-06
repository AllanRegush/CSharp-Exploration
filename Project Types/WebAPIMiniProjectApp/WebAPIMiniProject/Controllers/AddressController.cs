using Microsoft.AspNetCore.Mvc;
using WebAPIMiniProject.Models;

namespace WebAPIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly ILogger _logger;
        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post([FromBody] AddressModel model)
        {
            _logger.LogInformation($"Data: {model.Street} {model.City} {model.State} {model.ZipCode}");
        }
    }
}

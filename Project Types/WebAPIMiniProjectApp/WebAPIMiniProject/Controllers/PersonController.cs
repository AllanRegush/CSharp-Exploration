using Microsoft.AspNetCore.Mvc;
using WebAPIMiniProject.Models;

namespace WebAPIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly ILogger _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post([FromBody] PersonModel model)
        {
            _logger.LogInformation($"Data: {model.FirstName}, {model.LastName}");
        }
    }
}

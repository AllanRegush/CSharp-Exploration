using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloUserController : ControllerBase
    {
        [HttpGet]
        public string Get(string firstName = "", string lastName = "")
        {
            string output = "Hello User!";

            if (string.IsNullOrWhiteSpace(firstName) == false && string.IsNullOrWhiteSpace(lastName) == false)
                output = $"Hello {firstName} {lastName}";
            
            return output;
        }
    }
}

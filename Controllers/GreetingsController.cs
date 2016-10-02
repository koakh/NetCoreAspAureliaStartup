using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modern.Controllers
{
    public class GreetingsMessage {
        public string Message { get; set; }
    }

    [Route("api/[controller]")]
    public class GreetingsController : Controller
    {
        // GET api/values
        [HttpGet]
        public GreetingsMessage Get()
        {
            return new GreetingsMessage { Message = "Hello World from ASP.NET Core 1.0 Web API!!!" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

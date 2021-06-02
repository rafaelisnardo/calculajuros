using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Showmethecode : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("https://github.com/rafaelisnardo/calculajuros");
        }
    }
}

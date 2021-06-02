using API1.Model;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJuros : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            var juros = new Juros();
            return Ok(juros);
        }
    }
}
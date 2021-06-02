using API2.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace API2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CalculaJuros : ControllerBase
    {
        private const string URL = "https://localhost:5001/TaxaJuros/";
        static HttpClient client = new HttpClient();
        Juros valorJuros = new Juros();

        [HttpGet]
        public async Task<ActionResult> GetAsync(double valorinicial, int meses)
        {
            HttpResponseMessage response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                valorJuros = JsonConvert.DeserializeObject<Juros>(result);
            }

            var jurosComposto = new JuroComposto(valorinicial, valorJuros.ValorJuros, meses);
            return Ok(jurosComposto);
        }
    }
}
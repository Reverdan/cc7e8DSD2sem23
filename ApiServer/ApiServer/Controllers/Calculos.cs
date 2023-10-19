using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculos : ControllerBase
    {
        [HttpGet("Somar")]
        public String somar(Int16 numero1, Int16 numero2)
        {
            return (numero1 + numero2).ToString();
        }

        [HttpGet("Subtrair")]
        public String subtrair(Int16 numero1, Int16 numero2)
        {
            return (numero1 - numero2).ToString();
        }
    }
}

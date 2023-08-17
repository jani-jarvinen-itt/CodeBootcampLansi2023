using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTesti2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EkaTestiController : ControllerBase
    {
        [HttpGet]
        [Route("kello")]
        public DateTime Kellonaika()
        {
            return DateTime.Now;
        }

        [HttpGet]
        [Route("moi")]
        public string SanoMoi()
        {
            return "Moi maailma!";
        }
    }
}

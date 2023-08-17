using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTesti2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EkaTestiController : ControllerBase
    {
        public string SanoMoi()
        {
            return "Moi maailma!";
        }
    }
}

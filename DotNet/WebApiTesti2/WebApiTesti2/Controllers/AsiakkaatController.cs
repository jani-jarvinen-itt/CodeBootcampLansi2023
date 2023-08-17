using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTesti2.Models;

namespace WebApiTesti2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiakkaatController : ControllerBase
    {
        [HttpGet]
        public List<Customer> HaeSuomalaiset()
        {
            NorthwindContext konteksti = new();

            // LINQ-kysely
            var suomalaiset = from c in konteksti.Customers
                              where c.Country == "Finland"
                              select c;

            return suomalaiset.ToList();
        }
    }
}

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

            /*
            // datan lisäys
            konteksti.Customers.Add(new Customer()
            {
                CustomerId = "UUSIA",
                CompanyName = "Uusi Asiakas",
                Country = "Finland"
            });
            konteksti.SaveChanges();
            */

            // LINQ-kysely
            var suomalaiset = from c in konteksti.Customers
                              where c.Country == "Finland"
                              select c;

            return suomalaiset.ToList();
        }
    }
}

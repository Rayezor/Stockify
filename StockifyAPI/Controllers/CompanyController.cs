using Microsoft.AspNetCore.Mvc;
using StockifyAPI.Data;

namespace StockifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
 
        private ApiContext stockifyDB;

        // Check database connection
        public CompanyController()
        {
            stockifyDB = new ApiContext();
            stockifyDB.Database.EnsureCreated();

        }

        // GET: Route = "/GetAll" to return all companies
        [HttpGet("/GetAll")]
        public JsonResult GetAll()
        {
            var result = stockifyDB.Companies.ToList();
            
            return new JsonResult(Ok(result));
        }

    }
}

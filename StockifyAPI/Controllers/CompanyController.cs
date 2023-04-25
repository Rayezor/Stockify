using Microsoft.AspNetCore.Mvc;
using StockifyAPI.Data;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ApiContext _context;
        public CompanyController(ApiContext context)
        {
            _context = context;
        }


        // GET: api/<CompanyController>
        [HttpGet]
        public JsonResult Get(string id)
        {
            var result = _context.Companies.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            return new JsonResult(Ok(result));
        }

        // GET api/<CompanyController>/5
        [HttpGet("/GetAll")]
        public JsonResult GetAll()
        {
            var result = _context.Companies.ToList();
            
            return new JsonResult(Ok(result));
        }

    }
}

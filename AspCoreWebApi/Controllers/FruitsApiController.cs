using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsApiController : ControllerBase
    {
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry"
        };
        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;

        }
        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            return fruits.ElementAt(id);

        }
    }

   
 }

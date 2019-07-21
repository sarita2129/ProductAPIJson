using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIProject.Models;
using APIProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productservice = new ProductService();

        // GET: api/Products/5
        [HttpGet("{id}.json", Name = "Get")]
        public ActionResult Get(int id)
        {
            string result = _productservice.Get(id);
            if (result == null)
                return NotFound("Product does not exist");
            else
                return Ok(result);
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            string newproduct = _productservice.Add(product);
            if (newproduct == null)
                return NotFound("Product exist");
            else
                return Ok(newproduct);
        }

    }
}

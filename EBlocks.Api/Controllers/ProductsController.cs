using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBlocks.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBlocks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private INorthWindsService _service;

        public ProductsController(INorthWindsService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<IProduct> GetAllProducts()
        {
            List<IProduct> result = new List<IProduct>();

            result = this._service.ProductRepository.GetAll();

            return result;
        }

    }
}

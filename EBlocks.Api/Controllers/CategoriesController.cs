using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBlocks.Interfaces;
using EBlocks.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBlocks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private INorthWindsService _service;
        
        public CategoriesController(INorthWindsService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<ICategory>GetAllCategories()
        {
            List<ICategory> result = new List<ICategory>();
            
            result = this._service.CategoryRepository.GetAll();
            
            return result;
        }
    }
}

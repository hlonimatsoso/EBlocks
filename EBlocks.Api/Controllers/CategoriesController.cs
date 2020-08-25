using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBlocks.Interfaces;
using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBlocks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private INorthWindsService _service;
        private IMongoRepo<Category> _repo;

        public CategoriesController(INorthWindsService service, IMongoRepo<Category> repo )
        {
            this._service = service;
            this._repo = repo;
        }

        [HttpGet]
        public List<ICategory>GetAllCategories()
        {
            List<ICategory> result = new List<ICategory>();

            result = this._service.CategoryRepository.GetAll();
            //result = _repo.AsQueryable().ToList();
            
            return result;
        }

        [HttpPost("add")]
        public async Task AddCategory(string name, string description, string picture)
        {
            var category = new Category()
            {
                CategoryName = name,
                Description = description,
                Picture = picture
            };

            await _repo.InsertOneAsync(category);
        }
    }
}

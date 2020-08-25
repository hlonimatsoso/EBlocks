using EBlocks.Interfaces;
using EBlocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.Api.Repos
{
    public class CategoryRepo
    {
        private readonly IMongoRepo<Category> _categories;


        public CategoryRepo(IMongoRepo<Category> categoryRepo)
        {
            _categories = categoryRepo;
        }


    }
}

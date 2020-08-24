using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBlocks.Api.Repos
{
    public class DemoCategoryRepo : ICategoryRepository
    {

        private readonly List<ICategory> _category;

        public DemoCategoryRepo()
        {
            this._category = new List<ICategory> {
                new Category{ CategoryName = "2 Door",Description = "A car with 2 doors", CategoryID = new Guid("672c7f6e-19f8-4bbd-b0f2-4cf262a3599f")},
                new Category{CategoryName = "4 Door",Description = "A car with 4 doors",CategoryID = new Guid("c28571fd-02cd-4f0f-839d-63b851f52558")},
                new Category{CategoryName = "7 Seater",Description = "Full house family car",CategoryID = new Guid("25ce3e31-80c2-4fb9-8118-88eb059d462c")},
                new Category{CategoryName = "Cabriolet",Description = "Drop top",CategoryID = new Guid("6472a649-5eae-4808-a818-ce6f9ee454c2")}
            };

        }


        public bool Delete(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public List<ICategory> GetAll()
        {
            return this._category;
        }

        public ICategory GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ICategory entity)
        {
            this._category.Add(entity);
            return true;
        }

        public bool Update(ICategory entity)
        {
            throw new NotImplementedException();
        }
    }
}

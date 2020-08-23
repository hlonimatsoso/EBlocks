using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EBlocks.Api.Repos
{
    public class DemoProductRepo : IProductRepository
    {

        private readonly List<IProduct> _products;

        public DemoProductRepo()
        {
            this._products = new List<IProduct> {
            new Product{ProductID = 1,CategoryID = 1,Id = new Guid(),SupplierID = 1,Discontinued = false, ProductName="Product 1", QuantityPerUnit=1,ReorderLevel = 10,UnitPrice = 25, UnitsInStock = 100,UnitsOnOrder = 1},
            new Product{ProductID = 2,CategoryID = 2,Id = new Guid(),SupplierID = 1,Discontinued = false, ProductName="Product 2", QuantityPerUnit=1,ReorderLevel = 5,UnitPrice = 20, UnitsInStock = 55,UnitsOnOrder = 1 },
            new Product{ProductID = 3,CategoryID = 1,Id = new Guid(),SupplierID = 2,Discontinued = false, ProductName="Another product", QuantityPerUnit=3,ReorderLevel = 20,UnitPrice = 20, UnitsInStock = 9,UnitsOnOrder = 1}
            };

        }

        public event Action<IProduct> OnCreated;
        public event Action<IProduct> OnUpdated;
        public event Action<IProduct> OnDeleted;
        
        public bool Delete(IProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> GetAll()
        {
            return this._products;
        }

        public IProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IProduct entity)
        {
            this._products.Add(entity);
            return true;
        }

        public bool Update(IProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}

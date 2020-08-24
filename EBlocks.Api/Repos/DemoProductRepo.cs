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
            new Product{ProductID = 1,CategoryID = new Guid("672c7f6e-19f8-4bbd-b0f2-4cf262a3599f"),SupplierID = new Guid("f5205e63-069e-4c97-a1a3-aad77c92a769"),Discontinued = false, ProductName="M2", QuantityPerUnit=1,ReorderLevel = 10,UnitPrice = 25, UnitsInStock = 100,UnitsOnOrder = 1},
            new Product{ProductID = 2,CategoryID = new Guid("c28571fd-02cd-4f0f-839d-63b851f52558"),SupplierID = new Guid("f5205e63-069e-4c97-a1a3-aad77c92a769"),Discontinued = false, ProductName="M5", QuantityPerUnit=1,ReorderLevel = 5,UnitPrice = 20, UnitsInStock = 55,UnitsOnOrder = 1 },
            new Product{ProductID = 3,CategoryID = new Guid("6472a649-5eae-4808-a818-ce6f9ee454c2"),SupplierID = new Guid("53903e1c-b59e-4d6f-9dc1-0c761ed92d2b"),Discontinued = false, ProductName="Porsche (964) 911 Turbo", QuantityPerUnit=3,ReorderLevel = 20,UnitPrice = 20, UnitsInStock = 9,UnitsOnOrder = 1}
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

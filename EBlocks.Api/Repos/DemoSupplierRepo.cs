using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBlocks.Api.Repos
{
    public class DemoSupplierRepo : ISupplierRepository
    {

        private readonly List<ISupplier> _Suppliers;

        public DemoSupplierRepo()
        {
            this._Suppliers = new List<ISupplier> {
                new Supplier{CompanyName = "B M W",City="Bavaria",ContactName="M Division Boss",ContactTitle="Prof", Region="Gauteng", SupplierID = new Guid("f5205e63-069e-4c97-a1a3-aad77c92a769"),HomePage="www.bmw.co.za"},
                new Supplier{CompanyName = "Benz",City="Frankfurt",ContactName="AMG Boss",ContactTitle="Mr", Region="Gauteng" , SupplierID = new Guid("b885f01f-ea23-4c9a-948d-a9f667bebd2b"),HomePage="www.benz.co.za"},
                new Supplier{CompanyName = "Porsche",City="Studguard",ContactName="Turbo S Boss",ContactTitle="Dr", Region="Cape Town" , SupplierID = new Guid("53903e1c-b59e-4d6f-9dc1-0c761ed92d2b"),HomePage="www.ofporsche.co.za"}


            };

        }

        public event Action<ISupplier> OnCreated;
        public event Action<ISupplier> OnUpdated;
        public event Action<ISupplier> OnDeleted;


        public bool Delete(ISupplier entity)
        {
            this.OnDeleted?.Invoke(entity);
            throw new NotImplementedException();
        }

        public List<ISupplier> GetAll()
        {
            return this._Suppliers;
        }

        public ISupplier GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ISupplier entity)
        {
            this._Suppliers.Add(entity);
            this.OnCreated?.Invoke(entity);
            return true;
        }

        public bool Update(ISupplier entity)
        {
            throw new NotImplementedException();
        }
    }
}

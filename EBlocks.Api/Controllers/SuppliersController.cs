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
    public class SuppliersController : ControllerBase
    {
        private INorthWindsService _service;
        //private IOrderRepository _repo;
        public SuppliersController(INorthWindsService service)
        {
            //this._repo = repo;
            this._service = service;
        }

        [HttpGet]
        public List<ISupplier>GetAllSuppliers()
        {
            List<ISupplier> result = new List<ISupplier>();
            result = this._service.SupplierRepository.GetAll();
            //result = this._service.OrderRepository.GetAll();

            return result;
        }
    }
}

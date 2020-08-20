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
    public class OrdersController : ControllerBase
    {
        private INorthWindsService _service;

        public OrdersController(INorthWindsService service)
        {
            this._service = service;
        }

        [HttpGet]
        public List<IOrder>GetAllOrders()
        {
            List<IOrder> result = new List<IOrder>();

            result = this._service.OrderRepository.GetAll();

            return result;
        }
    }
}

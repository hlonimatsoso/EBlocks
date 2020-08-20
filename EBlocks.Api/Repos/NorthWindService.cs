using EBlocks.Interfaces;

namespace EBlocks.Api.Repos
{
    public class NorthWindService : INorthWindsService
    {
        public IOrderRepository OrderRepository { get ; set ; }
        public IProductRepository ProductRepository { get ; set ; }

        public NorthWindService(IOrderRepository orderRepo, IProductRepository productRepo)
        {
            this.OrderRepository = orderRepo;
            this.ProductRepository = productRepo;
        }
    }
}

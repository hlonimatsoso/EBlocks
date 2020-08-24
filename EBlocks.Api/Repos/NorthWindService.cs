using EBlocks.Interfaces;

namespace EBlocks.Api.Repos
{
    public class NorthWindService : INorthWindsService
    {
        public IOrderRepository OrderRepository { get ; set ; }
        public IProductRepository ProductRepository { get ; set ; }
        public IOrderDetailsRepository OrderDetailsRepository { get ; set ; }
        public ICategoryRepository CategoryRepository { get ; set ; }
        public ISupplierRepository SupplierRepository { get ; set ; }

        public NorthWindService(IOrderRepository orderRepo, IProductRepository productRepo, ICategoryRepository categoryRepo, IOrderDetailsRepository orderDetailsRepo, ISupplierRepository supplierRepo)
        {
            this.OrderRepository = orderRepo;
            this.ProductRepository = productRepo;
            this.OrderDetailsRepository = orderDetailsRepo;
            this.CategoryRepository = categoryRepo;
            this.SupplierRepository = supplierRepo;
        }
    }
}

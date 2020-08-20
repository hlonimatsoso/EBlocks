using EBlocks.Models;

namespace EBlocks.Interfaces
{
    public interface IProduct: IBaseCollection
    {
        int ProductID { get; set; }

        int SupplierID { get; set; }

        Supplier Supplier { get; set; }

        int CategoryID { get; set; }

        Category Category { get; set; }
    }
}

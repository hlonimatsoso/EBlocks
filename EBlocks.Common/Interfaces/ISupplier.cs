using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface ISupplier
    {
        int SupplierID { get; set; }

        string CompanyName { get; set; }

        string ContactName { get; set; }

        string ContactTitle { get; set; }

        string City { get; set; }

        string Region { get; set; }

        string Address { get; set; }
        int PostalCode { get; set; }

        string Phone { get; set; }

        string Fax { get; set; }

        string HomePage { get; set; }
    }
}

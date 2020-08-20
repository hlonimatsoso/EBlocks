using System;
using System.Collections.Generic;
using System.Text;

namespace EBlocks.Interfaces
{
    public interface IHttpResult<T>
    {
        int HttpCode { get; set; }
        
        bool IsSuccessfull { get; set; }

        string ErrorMesage { get; set; }

        T Result { get; set; }

    }
}

using MISA.UT.WS.AppConsole.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.UT.WS.AppConsole.Products
{
    public interface IProductService
    {
        bool IsValid(Order.Detail item);
    }
}

﻿using System;

namespace MISA.UT.WS.AppConsole.Orders
{
    public interface IOrderService
    {
        Guid? Create(Order order);
    }
}
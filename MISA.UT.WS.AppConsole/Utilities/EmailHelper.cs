﻿using MISA.UT.WS.AppConsole.Orders;
using MISA.UT.WS.AppConsole.Sessions;

namespace MISA.UT.WS.AppConsole.Utilities
{
    public class EmailHelper
    {
        public static string CreateOrderContent(UserInfo userInfo, Order order)
        {
            string templateContent = System.IO.File.ReadAllText(@"OrderEmailTemplate.txt");
            templateContent = templateContent.Replace("##Name##", userInfo.Name);
            templateContent = templateContent.Replace("##OrderId##", order.Id.ToString());
            return templateContent;
        }
    }
}

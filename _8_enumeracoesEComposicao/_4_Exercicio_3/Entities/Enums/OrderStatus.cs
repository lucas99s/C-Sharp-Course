using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Exercicio_3.Entities.Enums
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
